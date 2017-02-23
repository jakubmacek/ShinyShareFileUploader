using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShinyShareFileUploader.Properties;

namespace ShinyShareFileUploader
{
    public partial class StatusForm: Form
    {
        List<string> _urlsForClipboard = new List<string>();
        ConcurrentQueue<FileInfo> _filesToUpload = new ConcurrentQueue<FileInfo>();

        public StatusForm()
        {
            InitializeComponent();
        }

        async Task DoUpload()
        {
            FileInfo fileToUpload;
            while (_filesToUpload.TryDequeue(out fileToUpload))
            {
                currentFilePath.Text = fileToUpload.FullName;
                uploadProgressBar.Value = 0;

                var uploadedFileName = fileToUpload.Name.Replace(" ", "_");

                var webClient = new WebClient();
                webClient.Credentials = new NetworkCredential(uploadUserNameTextBox.Text, uploadPasswordTextBox.Text);

                webClient.UploadProgressChanged += (object se, UploadProgressChangedEventArgs ev) =>
                {
                    uploadProgressBar.Value = ev.ProgressPercentage;
                };

                webClient.UploadFileCompleted += (object se, UploadFileCompletedEventArgs ev) =>
                {
                    uploadProgressBar.Value = 100;
                    var downloadUrl = downloadUrlTextBox.Text + uploadedFileName;
                    _urlsForClipboard.Add(downloadUrl);
                };

                var destination = uploadUrlTextBox.Text + uploadedFileName;
                var source = fileToUpload.FullName;

                await webClient.UploadFileTaskAsync(destination, "PUT", source);
            }

            Clipboard.SetText(string.Join("\r\n", _urlsForClipboard));
            System.Media.SystemSounds.Asterisk.Play();
            Application.Exit();
        }

        async void browseButton_Click(object sender, EventArgs e)
        {
            if (browseFileDialog.ShowDialog() == DialogResult.OK)
            {
                _urlsForClipboard.Clear();
                _filesToUpload.Enqueue(new FileInfo(browseFileDialog.FileName));
                await DoUpload();
            }
        }

        void StatusForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        async void StatusForm_DragDrop(object sender, DragEventArgs e)
        {
            var paths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (paths == null)
                return;

            _urlsForClipboard.Clear();

            foreach (var path in paths)
                _filesToUpload.Enqueue(new FileInfo(path));

            await DoUpload();
        }

        void StatusForm_Load(object sender, EventArgs e)
        {
            downloadUrlTextBox.Text = Settings.Default.DownloadUrl;
            uploadUrlTextBox.Text = Settings.Default.UploadUrl;
            uploadUserNameTextBox.Text = Settings.Default.UploadUserName;

            if (!string.IsNullOrEmpty(Settings.Default.UploadPassword) && !string.IsNullOrEmpty(Settings.Default.UploadPasswordEntropy))
            {
                var entropy = Convert.FromBase64String(Settings.Default.UploadPasswordEntropy);
                var encryptedPasswordBytes = Convert.FromBase64String(Settings.Default.UploadPassword);
                var passwordBytes = ProtectedData.Unprotect(encryptedPasswordBytes, entropy, DataProtectionScope.CurrentUser);
                uploadPasswordTextBox.Text = Encoding.UTF8.GetString(passwordBytes);
            }

            downloadUrlTextBox.TextChanged += SettingsChanged;
            uploadUrlTextBox.TextChanged += SettingsChanged;
            uploadUserNameTextBox.TextChanged += SettingsChanged;
            uploadPasswordTextBox.TextChanged += SettingsChanged;
        }

        void SettingsChanged(object sender, EventArgs e)
        {
            Settings.Default.DownloadUrl = downloadUrlTextBox.Text;
            Settings.Default.UploadUrl = uploadUrlTextBox.Text;
            Settings.Default.UploadUserName = uploadUserNameTextBox.Text;

            if (string.IsNullOrEmpty(Settings.Default.UploadPasswordEntropy))
            {
                using (var crypto = new AesManaged())
                {
                    crypto.GenerateIV();
                    Settings.Default.UploadPasswordEntropy = Convert.ToBase64String(crypto.IV);
                }
            }

            var entropy = Convert.FromBase64String(Settings.Default.UploadPasswordEntropy);
            var passwordBytes = Encoding.UTF8.GetBytes(uploadPasswordTextBox.Text);
            var encryptedPasswordBytes = ProtectedData.Protect(passwordBytes, entropy, DataProtectionScope.CurrentUser);
            Settings.Default.UploadPassword = Convert.ToBase64String(encryptedPasswordBytes);

            Settings.Default.Save();
        }
    }
}

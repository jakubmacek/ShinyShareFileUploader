namespace ShinyShareFileUploader
{
    partial class StatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            this.browseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.uploadProgressBar = new System.Windows.Forms.ProgressBar();
            this.currentFilePath = new System.Windows.Forms.Label();
            this.downloadUrlLabel = new System.Windows.Forms.Label();
            this.label2d = new System.Windows.Forms.Label();
            this.uploadUserNameLabel = new System.Windows.Forms.Label();
            this.downloadUrlTextBox = new System.Windows.Forms.TextBox();
            this.uploadUrlTextBox = new System.Windows.Forms.TextBox();
            this.uploadUserNameTextBox = new System.Windows.Forms.TextBox();
            this.uploadPasswordLabel = new System.Windows.Forms.Label();
            this.uploadPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // browseButton
            //
            this.browseButton.Location = new System.Drawing.Point(12, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(103, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            //
            // uploadProgressBar
            //
            this.uploadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadProgressBar.Location = new System.Drawing.Point(12, 41);
            this.uploadProgressBar.Name = "uploadProgressBar";
            this.uploadProgressBar.Size = new System.Drawing.Size(632, 23);
            this.uploadProgressBar.TabIndex = 1;
            //
            // currentFilePath
            //
            this.currentFilePath.AutoSize = true;
            this.currentFilePath.Location = new System.Drawing.Point(124, 17);
            this.currentFilePath.Name = "currentFilePath";
            this.currentFilePath.Size = new System.Drawing.Size(0, 13);
            this.currentFilePath.TabIndex = 2;
            //
            // downloadUrlLabel
            //
            this.downloadUrlLabel.AutoSize = true;
            this.downloadUrlLabel.Location = new System.Drawing.Point(12, 73);
            this.downloadUrlLabel.Name = "downloadUrlLabel";
            this.downloadUrlLabel.Size = new System.Drawing.Size(83, 13);
            this.downloadUrlLabel.TabIndex = 3;
            this.downloadUrlLabel.Text = "Download URL:";
            //
            // label2d
            //
            this.label2d.AutoSize = true;
            this.label2d.Location = new System.Drawing.Point(12, 99);
            this.label2d.Name = "label2d";
            this.label2d.Size = new System.Drawing.Size(69, 13);
            this.label2d.TabIndex = 4;
            this.label2d.Text = "Upload URL:";
            //
            // uploadUserNameLabel
            //
            this.uploadUserNameLabel.AutoSize = true;
            this.uploadUserNameLabel.Location = new System.Drawing.Point(12, 125);
            this.uploadUserNameLabel.Name = "uploadUserNameLabel";
            this.uploadUserNameLabel.Size = new System.Drawing.Size(96, 13);
            this.uploadUserNameLabel.TabIndex = 5;
            this.uploadUserNameLabel.Text = "Upload user name:";
            //
            // downloadUrlTextBox
            //
            this.downloadUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadUrlTextBox.Location = new System.Drawing.Point(127, 70);
            this.downloadUrlTextBox.Name = "downloadUrlTextBox";
            this.downloadUrlTextBox.Size = new System.Drawing.Size(517, 20);
            this.downloadUrlTextBox.TabIndex = 6;
            //
            // uploadUrlTextBox
            //
            this.uploadUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadUrlTextBox.Location = new System.Drawing.Point(127, 96);
            this.uploadUrlTextBox.Name = "uploadUrlTextBox";
            this.uploadUrlTextBox.Size = new System.Drawing.Size(517, 20);
            this.uploadUrlTextBox.TabIndex = 7;
            //
            // uploadUserNameTextBox
            //
            this.uploadUserNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadUserNameTextBox.Location = new System.Drawing.Point(127, 122);
            this.uploadUserNameTextBox.Name = "uploadUserNameTextBox";
            this.uploadUserNameTextBox.Size = new System.Drawing.Size(517, 20);
            this.uploadUserNameTextBox.TabIndex = 8;
            //
            // uploadPasswordLabel
            //
            this.uploadPasswordLabel.AutoSize = true;
            this.uploadPasswordLabel.Location = new System.Drawing.Point(12, 151);
            this.uploadPasswordLabel.Name = "uploadPasswordLabel";
            this.uploadPasswordLabel.Size = new System.Drawing.Size(92, 13);
            this.uploadPasswordLabel.TabIndex = 9;
            this.uploadPasswordLabel.Text = "Upload password:";
            //
            // uploadPasswordTextBox
            //
            this.uploadPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadPasswordTextBox.Location = new System.Drawing.Point(127, 148);
            this.uploadPasswordTextBox.Name = "uploadPasswordTextBox";
            this.uploadPasswordTextBox.PasswordChar = '*';
            this.uploadPasswordTextBox.Size = new System.Drawing.Size(517, 20);
            this.uploadPasswordTextBox.TabIndex = 10;
            //
            // StatusForm
            //
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 186);
            this.Controls.Add(this.uploadPasswordTextBox);
            this.Controls.Add(this.uploadPasswordLabel);
            this.Controls.Add(this.uploadUserNameTextBox);
            this.Controls.Add(this.uploadUrlTextBox);
            this.Controls.Add(this.downloadUrlTextBox);
            this.Controls.Add(this.uploadUserNameLabel);
            this.Controls.Add(this.label2d);
            this.Controls.Add(this.downloadUrlLabel);
            this.Controls.Add(this.currentFilePath);
            this.Controls.Add(this.uploadProgressBar);
            this.Controls.Add(this.browseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatusForm";
            this.Text = "Shiny Share File Uploader";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.StatusForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.StatusForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog browseFileDialog;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ProgressBar uploadProgressBar;
        private System.Windows.Forms.Label currentFilePath;
        private System.Windows.Forms.Label downloadUrlLabel;
        private System.Windows.Forms.Label label2d;
        private System.Windows.Forms.Label uploadUserNameLabel;
        private System.Windows.Forms.TextBox downloadUrlTextBox;
        private System.Windows.Forms.TextBox uploadUrlTextBox;
        private System.Windows.Forms.TextBox uploadUserNameTextBox;
        private System.Windows.Forms.Label uploadPasswordLabel;
        private System.Windows.Forms.TextBox uploadPasswordTextBox;
    }
}


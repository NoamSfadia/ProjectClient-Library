namespace ProjectClient
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.ChangeUserTxtBox = new System.Windows.Forms.TextBox();
            this.SendNewUserButton = new System.Windows.Forms.Button();
            this.ChangeUserLabel = new System.Windows.Forms.Label();
            this.AccountSettingsPanel = new System.Windows.Forms.Panel();
            this.ChangeMailButton = new System.Windows.Forms.Button();
            this.ChangeMailTextBox = new System.Windows.Forms.TextBox();
            this.ChangeMailLabel = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ChangePasswordTextBox = new System.Windows.Forms.TextBox();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.BookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.BookGenreTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.BookRatingTextBox = new System.Windows.Forms.TextBox();
            this.UploadBookButton = new System.Windows.Forms.Button();
            this.UploadBookPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.smtpCodeSettings = new ProjectClient.SmtpCode();
            this.AccountSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadBookPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeUserTxtBox
            // 
            this.ChangeUserTxtBox.Enabled = false;
            this.ChangeUserTxtBox.Location = new System.Drawing.Point(6, 39);
            this.ChangeUserTxtBox.Name = "ChangeUserTxtBox";
            this.ChangeUserTxtBox.Size = new System.Drawing.Size(100, 22);
            this.ChangeUserTxtBox.TabIndex = 2;
            // 
            // SendNewUserButton
            // 
            this.SendNewUserButton.Enabled = false;
            this.SendNewUserButton.Location = new System.Drawing.Point(112, 39);
            this.SendNewUserButton.Name = "SendNewUserButton";
            this.SendNewUserButton.Size = new System.Drawing.Size(75, 22);
            this.SendNewUserButton.TabIndex = 1;
            this.SendNewUserButton.UseVisualStyleBackColor = true;
            this.SendNewUserButton.Click += new System.EventHandler(this.SendNewUserButton_Click);
            // 
            // ChangeUserLabel
            // 
            this.ChangeUserLabel.AutoSize = true;
            this.ChangeUserLabel.Location = new System.Drawing.Point(3, 20);
            this.ChangeUserLabel.Name = "ChangeUserLabel";
            this.ChangeUserLabel.Size = new System.Drawing.Size(154, 16);
            this.ChangeUserLabel.TabIndex = 0;
            this.ChangeUserLabel.Text = "Change Your Username:";
            // 
            // AccountSettingsPanel
            // 
            this.AccountSettingsPanel.Controls.Add(this.ChangeMailButton);
            this.AccountSettingsPanel.Controls.Add(this.ChangeMailTextBox);
            this.AccountSettingsPanel.Controls.Add(this.ChangeMailLabel);
            this.AccountSettingsPanel.Controls.Add(this.ChangePasswordButton);
            this.AccountSettingsPanel.Controls.Add(this.ChangePasswordTextBox);
            this.AccountSettingsPanel.Controls.Add(this.ChangePasswordLabel);
            this.AccountSettingsPanel.Controls.Add(this.SendNewUserButton);
            this.AccountSettingsPanel.Controls.Add(this.ChangeUserLabel);
            this.AccountSettingsPanel.Controls.Add(this.ChangeUserTxtBox);
            this.AccountSettingsPanel.Location = new System.Drawing.Point(12, 124);
            this.AccountSettingsPanel.Name = "AccountSettingsPanel";
            this.AccountSettingsPanel.Size = new System.Drawing.Size(200, 267);
            this.AccountSettingsPanel.TabIndex = 4;
            // 
            // ChangeMailButton
            // 
            this.ChangeMailButton.Location = new System.Drawing.Point(112, 173);
            this.ChangeMailButton.Name = "ChangeMailButton";
            this.ChangeMailButton.Size = new System.Drawing.Size(75, 22);
            this.ChangeMailButton.TabIndex = 8;
            this.ChangeMailButton.UseVisualStyleBackColor = true;
            this.ChangeMailButton.Click += new System.EventHandler(this.ChangeMailButton_Click);
            // 
            // ChangeMailTextBox
            // 
            this.ChangeMailTextBox.Location = new System.Drawing.Point(9, 173);
            this.ChangeMailTextBox.Name = "ChangeMailTextBox";
            this.ChangeMailTextBox.Size = new System.Drawing.Size(100, 22);
            this.ChangeMailTextBox.TabIndex = 7;
            // 
            // ChangeMailLabel
            // 
            this.ChangeMailLabel.AutoSize = true;
            this.ChangeMailLabel.Location = new System.Drawing.Point(9, 154);
            this.ChangeMailLabel.Name = "ChangeMailLabel";
            this.ChangeMailLabel.Size = new System.Drawing.Size(116, 16);
            this.ChangeMailLabel.TabIndex = 6;
            this.ChangeMailLabel.Text = "Change Your Mail:";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(112, 107);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(75, 21);
            this.ChangePasswordButton.TabIndex = 5;
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangePasswordTextBox
            // 
            this.ChangePasswordTextBox.Location = new System.Drawing.Point(9, 107);
            this.ChangePasswordTextBox.Name = "ChangePasswordTextBox";
            this.ChangePasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.ChangePasswordTextBox.TabIndex = 4;
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(6, 87);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(151, 16);
            this.ChangePasswordLabel.TabIndex = 3;
            this.ChangePasswordLabel.Text = "Change Your Password:";
            // 
            // BookAuthorTextBox
            // 
            this.BookAuthorTextBox.Location = new System.Drawing.Point(340, 325);
            this.BookAuthorTextBox.Name = "BookAuthorTextBox";
            this.BookAuthorTextBox.Size = new System.Drawing.Size(160, 22);
            this.BookAuthorTextBox.TabIndex = 5;
            // 
            // BookGenreTextBox
            // 
            this.BookGenreTextBox.Location = new System.Drawing.Point(340, 353);
            this.BookGenreTextBox.Name = "BookGenreTextBox";
            this.BookGenreTextBox.Size = new System.Drawing.Size(160, 22);
            this.BookGenreTextBox.TabIndex = 6;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(340, 297);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.BookNameTextBox.TabIndex = 7;
            this.BookNameTextBox.TextChanged += new System.EventHandler(this.BookNameTextBox_TextChanged);
            // 
            // BookRatingTextBox
            // 
            this.BookRatingTextBox.Location = new System.Drawing.Point(340, 381);
            this.BookRatingTextBox.Name = "BookRatingTextBox";
            this.BookRatingTextBox.Size = new System.Drawing.Size(160, 22);
            this.BookRatingTextBox.TabIndex = 8;
            // 
            // UploadBookButton
            // 
            this.UploadBookButton.Location = new System.Drawing.Point(340, 440);
            this.UploadBookButton.Name = "UploadBookButton";
            this.UploadBookButton.Size = new System.Drawing.Size(160, 23);
            this.UploadBookButton.TabIndex = 9;
            this.UploadBookButton.Text = "UPLOAD!";
            this.UploadBookButton.UseVisualStyleBackColor = true;
            this.UploadBookButton.Click += new System.EventHandler(this.UploadBookButton_Click);
            // 
            // UploadBookPhotoPictureBox
            // 
            this.UploadBookPhotoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UploadBookPhotoPictureBox.Image")));
            this.UploadBookPhotoPictureBox.Location = new System.Drawing.Point(340, 44);
            this.UploadBookPhotoPictureBox.Name = "UploadBookPhotoPictureBox";
            this.UploadBookPhotoPictureBox.Size = new System.Drawing.Size(160, 240);
            this.UploadBookPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UploadBookPhotoPictureBox.TabIndex = 10;
            this.UploadBookPhotoPictureBox.TabStop = false;
            this.UploadBookPhotoPictureBox.Click += new System.EventHandler(this.UploadBookPhotoPictureBox_Click);
            // 
            // smtpCodeSettings
            // 
            this.smtpCodeSettings.BackColor = System.Drawing.Color.Transparent;
            this.smtpCodeSettings.Location = new System.Drawing.Point(8, 12);
            this.smtpCodeSettings.Name = "smtpCodeSettings";
            this.smtpCodeSettings.Size = new System.Drawing.Size(185, 106);
            this.smtpCodeSettings.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(732, 588);
            this.Controls.Add(this.UploadBookPhotoPictureBox);
            this.Controls.Add(this.UploadBookButton);
            this.Controls.Add(this.BookRatingTextBox);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.BookGenreTextBox);
            this.Controls.Add(this.BookAuthorTextBox);
            this.Controls.Add(this.smtpCodeSettings);
            this.Controls.Add(this.AccountSettingsPanel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.AccountSettingsPanel.ResumeLayout(false);
            this.AccountSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadBookPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SmtpCode smtpCodeSettings;
        private System.Windows.Forms.TextBox ChangeUserTxtBox;
        private System.Windows.Forms.Button SendNewUserButton;
        private System.Windows.Forms.Label ChangeUserLabel;
        private System.Windows.Forms.Panel AccountSettingsPanel;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.TextBox ChangePasswordTextBox;
        private System.Windows.Forms.Label ChangePasswordLabel;
        private System.Windows.Forms.Button ChangeMailButton;
        private System.Windows.Forms.TextBox ChangeMailTextBox;
        private System.Windows.Forms.Label ChangeMailLabel;
        private System.Windows.Forms.TextBox BookAuthorTextBox;
        private System.Windows.Forms.TextBox BookGenreTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox BookRatingTextBox;
        private System.Windows.Forms.Button UploadBookButton;
        private System.Windows.Forms.PictureBox UploadBookPhotoPictureBox;
    }
}
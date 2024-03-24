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
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.UploadBookButton = new System.Windows.Forms.Button();
            this.UploadBookPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.BookSummaryTextBox = new System.Windows.Forms.RichTextBox();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.AccessSettingsLabel = new System.Windows.Forms.LinkLabel();
            this.SendSmtpCodeSettings = new System.Windows.Forms.Button();
            this.SmtpTextBox = new System.Windows.Forms.TextBox();
            this.InsertSmtpCode = new System.Windows.Forms.Label();
            this.AccountSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadBookPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeUserTxtBox
            // 
            this.ChangeUserTxtBox.Enabled = false;
            this.ChangeUserTxtBox.Location = new System.Drawing.Point(4, 32);
            this.ChangeUserTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeUserTxtBox.Name = "ChangeUserTxtBox";
            this.ChangeUserTxtBox.Size = new System.Drawing.Size(76, 20);
            this.ChangeUserTxtBox.TabIndex = 2;
            // 
            // SendNewUserButton
            // 
            this.SendNewUserButton.Enabled = false;
            this.SendNewUserButton.Location = new System.Drawing.Point(84, 32);
            this.SendNewUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendNewUserButton.Name = "SendNewUserButton";
            this.SendNewUserButton.Size = new System.Drawing.Size(56, 18);
            this.SendNewUserButton.TabIndex = 1;
            this.SendNewUserButton.UseVisualStyleBackColor = true;
            this.SendNewUserButton.Click += new System.EventHandler(this.SendNewUserButton_Click);
            // 
            // ChangeUserLabel
            // 
            this.ChangeUserLabel.AutoSize = true;
            this.ChangeUserLabel.Location = new System.Drawing.Point(2, 16);
            this.ChangeUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangeUserLabel.Name = "ChangeUserLabel";
            this.ChangeUserLabel.Size = new System.Drawing.Size(123, 13);
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
            this.AccountSettingsPanel.Location = new System.Drawing.Point(9, 101);
            this.AccountSettingsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AccountSettingsPanel.Name = "AccountSettingsPanel";
            this.AccountSettingsPanel.Size = new System.Drawing.Size(150, 217);
            this.AccountSettingsPanel.TabIndex = 4;
            // 
            // ChangeMailButton
            // 
            this.ChangeMailButton.Location = new System.Drawing.Point(84, 141);
            this.ChangeMailButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeMailButton.Name = "ChangeMailButton";
            this.ChangeMailButton.Size = new System.Drawing.Size(56, 18);
            this.ChangeMailButton.TabIndex = 8;
            this.ChangeMailButton.UseVisualStyleBackColor = true;
            this.ChangeMailButton.Click += new System.EventHandler(this.ChangeMailButton_Click);
            // 
            // ChangeMailTextBox
            // 
            this.ChangeMailTextBox.Location = new System.Drawing.Point(7, 141);
            this.ChangeMailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeMailTextBox.Name = "ChangeMailTextBox";
            this.ChangeMailTextBox.Size = new System.Drawing.Size(76, 20);
            this.ChangeMailTextBox.TabIndex = 7;
            // 
            // ChangeMailLabel
            // 
            this.ChangeMailLabel.AutoSize = true;
            this.ChangeMailLabel.Location = new System.Drawing.Point(7, 125);
            this.ChangeMailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangeMailLabel.Name = "ChangeMailLabel";
            this.ChangeMailLabel.Size = new System.Drawing.Size(94, 13);
            this.ChangeMailLabel.TabIndex = 6;
            this.ChangeMailLabel.Text = "Change Your Mail:";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(84, 87);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(56, 17);
            this.ChangePasswordButton.TabIndex = 5;
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangePasswordTextBox
            // 
            this.ChangePasswordTextBox.Location = new System.Drawing.Point(7, 87);
            this.ChangePasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePasswordTextBox.Name = "ChangePasswordTextBox";
            this.ChangePasswordTextBox.Size = new System.Drawing.Size(76, 20);
            this.ChangePasswordTextBox.TabIndex = 4;
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(4, 71);
            this.ChangePasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(121, 13);
            this.ChangePasswordLabel.TabIndex = 3;
            this.ChangePasswordLabel.Text = "Change Your Password:";
            // 
            // BookAuthorTextBox
            // 
            this.BookAuthorTextBox.Location = new System.Drawing.Point(206, 233);
            this.BookAuthorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookAuthorTextBox.Name = "BookAuthorTextBox";
            this.BookAuthorTextBox.Size = new System.Drawing.Size(121, 20);
            this.BookAuthorTextBox.TabIndex = 5;
            this.BookAuthorTextBox.Visible = false;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(206, 209);
            this.BookNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.BookNameTextBox.TabIndex = 7;
            this.BookNameTextBox.Visible = false;
            this.BookNameTextBox.TextChanged += new System.EventHandler(this.BookNameTextBox_TextChanged);
            // 
            // UploadBookButton
            // 
            this.UploadBookButton.Location = new System.Drawing.Point(206, 392);
            this.UploadBookButton.Margin = new System.Windows.Forms.Padding(2);
            this.UploadBookButton.Name = "UploadBookButton";
            this.UploadBookButton.Size = new System.Drawing.Size(121, 19);
            this.UploadBookButton.TabIndex = 9;
            this.UploadBookButton.Text = "UPLOAD!";
            this.UploadBookButton.UseVisualStyleBackColor = true;
            this.UploadBookButton.Visible = false;
            this.UploadBookButton.Click += new System.EventHandler(this.UploadBookButton_Click);
            // 
            // UploadBookPhotoPictureBox
            // 
            this.UploadBookPhotoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadBookPhotoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UploadBookPhotoPictureBox.Image")));
            this.UploadBookPhotoPictureBox.Location = new System.Drawing.Point(206, 10);
            this.UploadBookPhotoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.UploadBookPhotoPictureBox.Name = "UploadBookPhotoPictureBox";
            this.UploadBookPhotoPictureBox.Size = new System.Drawing.Size(120, 195);
            this.UploadBookPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UploadBookPhotoPictureBox.TabIndex = 10;
            this.UploadBookPhotoPictureBox.TabStop = false;
            this.UploadBookPhotoPictureBox.Visible = false;
            this.UploadBookPhotoPictureBox.Click += new System.EventHandler(this.UploadBookPhotoPictureBox_Click);
            // 
            // BookSummaryTextBox
            // 
            this.BookSummaryTextBox.Location = new System.Drawing.Point(206, 282);
            this.BookSummaryTextBox.Name = "BookSummaryTextBox";
            this.BookSummaryTextBox.Size = new System.Drawing.Size(180, 96);
            this.BookSummaryTextBox.TabIndex = 11;
            this.BookSummaryTextBox.Text = "";
            this.BookSummaryTextBox.Visible = false;
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(206, 255);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(121, 21);
            this.GenreComboBox.TabIndex = 12;
            this.GenreComboBox.Visible = false;
            // 
            // AccessSettingsLabel
            // 
            this.AccessSettingsLabel.AutoSize = true;
            this.AccessSettingsLabel.Location = new System.Drawing.Point(16, 24);
            this.AccessSettingsLabel.Name = "AccessSettingsLabel";
            this.AccessSettingsLabel.Size = new System.Drawing.Size(145, 13);
            this.AccessSettingsLabel.TabIndex = 13;
            this.AccessSettingsLabel.TabStop = true;
            this.AccessSettingsLabel.Text = "Click here to access settings!";
            this.AccessSettingsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AccessSettingsLabel_LinkClicked);
            // 
            // SendSmtpCodeSettings
            // 
            this.SendSmtpCodeSettings.Location = new System.Drawing.Point(118, 73);
            this.SendSmtpCodeSettings.Name = "SendSmtpCodeSettings";
            this.SendSmtpCodeSettings.Size = new System.Drawing.Size(31, 23);
            this.SendSmtpCodeSettings.TabIndex = 14;
            this.SendSmtpCodeSettings.UseVisualStyleBackColor = true;
            this.SendSmtpCodeSettings.Visible = false;
            this.SendSmtpCodeSettings.Click += new System.EventHandler(this.SendSmtpCodeSettings_Click);
            // 
            // SmtpTextBox
            // 
            this.SmtpTextBox.Location = new System.Drawing.Point(9, 76);
            this.SmtpTextBox.Name = "SmtpTextBox";
            this.SmtpTextBox.Size = new System.Drawing.Size(100, 20);
            this.SmtpTextBox.TabIndex = 15;
            this.SmtpTextBox.Visible = false;
            // 
            // InsertSmtpCode
            // 
            this.InsertSmtpCode.AutoSize = true;
            this.InsertSmtpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InsertSmtpCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InsertSmtpCode.Location = new System.Drawing.Point(6, 57);
            this.InsertSmtpCode.Name = "InsertSmtpCode";
            this.InsertSmtpCode.Size = new System.Drawing.Size(162, 16);
            this.InsertSmtpCode.TabIndex = 16;
            this.InsertSmtpCode.Text = "Insert Code From Mail:";
            this.InsertSmtpCode.Visible = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(549, 478);
            this.Controls.Add(this.InsertSmtpCode);
            this.Controls.Add(this.SmtpTextBox);
            this.Controls.Add(this.SendSmtpCodeSettings);
            this.Controls.Add(this.AccessSettingsLabel);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.BookSummaryTextBox);
            this.Controls.Add(this.UploadBookButton);
            this.Controls.Add(this.UploadBookPhotoPictureBox);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.BookAuthorTextBox);
            this.Controls.Add(this.AccountSettingsPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Button UploadBookButton;
        private System.Windows.Forms.PictureBox UploadBookPhotoPictureBox;
        private System.Windows.Forms.RichTextBox BookSummaryTextBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.LinkLabel AccessSettingsLabel;
        private System.Windows.Forms.Button SendSmtpCodeSettings;
        private System.Windows.Forms.TextBox SmtpTextBox;
        private System.Windows.Forms.Label InsertSmtpCode;
    }
}
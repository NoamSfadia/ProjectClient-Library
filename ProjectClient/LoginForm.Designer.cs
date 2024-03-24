namespace ProjectClient
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.ForgotBtn = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CaptchaLabel = new System.Windows.Forms.Label();
            this.SmtpTextBox = new System.Windows.Forms.TextBox();
            this.SendMailButton = new System.Windows.Forms.Button();
            this.CaptchaTextBox = new System.Windows.Forms.TextBox();
            this.SendCaptchaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(5, 119);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(118, 20);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsernameTextBox_MouseClick);
            this.UsernameTextBox.MouseEnter += new System.EventHandler(this.UsernameTextBox_MouseEnter);
            this.UsernameTextBox.MouseLeave += new System.EventHandler(this.UsernameTextBox_MouseLeave);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(5, 142);
            this.PassBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '•';
            this.PassBox.Size = new System.Drawing.Size(118, 20);
            this.PassBox.TabIndex = 1;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInBtn.Location = new System.Drawing.Point(5, 256);
            this.SignInBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(56, 27);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.Location = new System.Drawing.Point(67, 256);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(56, 27);
            this.SignUpBtn.TabIndex = 3;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // ForgotBtn
            // 
            this.ForgotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForgotBtn.Location = new System.Drawing.Point(6, 287);
            this.ForgotBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ForgotBtn.Name = "ForgotBtn";
            this.ForgotBtn.Size = new System.Drawing.Size(117, 37);
            this.ForgotBtn.TabIndex = 5;
            this.ForgotBtn.Text = "Forgot Password?";
            this.ForgotBtn.UseVisualStyleBackColor = true;
            this.ForgotBtn.Click += new System.EventHandler(this.ForgotBtn_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoBox.InitialImage")));
            this.LogoBox.Location = new System.Drawing.Point(40, 36);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(64, 64);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoBox.TabIndex = 6;
            this.LogoBox.TabStop = false;
            this.LogoBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.White;
            this.NameLbl.Location = new System.Drawing.Point(2, 7);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(124, 17);
            this.NameLbl.TabIndex = 7;
            this.NameLbl.Text = "Welcome To VLibrary";
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolTip.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // CaptchaLabel
            // 
            this.CaptchaLabel.AutoSize = true;
            this.CaptchaLabel.BackColor = System.Drawing.Color.Ivory;
            this.CaptchaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CaptchaLabel.Location = new System.Drawing.Point(3, 200);
            this.CaptchaLabel.Name = "CaptchaLabel";
            this.CaptchaLabel.Size = new System.Drawing.Size(0, 15);
            this.CaptchaLabel.TabIndex = 11;
            this.ToolTip.SetToolTip(this.CaptchaLabel, resources.GetString("CaptchaLabel.ToolTip"));
            // 
            // SmtpTextBox
            // 
            this.SmtpTextBox.Location = new System.Drawing.Point(5, 177);
            this.SmtpTextBox.Name = "SmtpTextBox";
            this.SmtpTextBox.Size = new System.Drawing.Size(118, 20);
            this.SmtpTextBox.TabIndex = 8;
            this.SmtpTextBox.Visible = false;
            this.SmtpTextBox.MouseEnter += new System.EventHandler(this.SmtpTextBox_MouseEnter);
            this.SmtpTextBox.MouseLeave += new System.EventHandler(this.SmtpTextBox_MouseLeave);
            // 
            // SendMailButton
            // 
            this.SendMailButton.Location = new System.Drawing.Point(130, 176);
            this.SendMailButton.Name = "SendMailButton";
            this.SendMailButton.Size = new System.Drawing.Size(24, 20);
            this.SendMailButton.TabIndex = 9;
            this.SendMailButton.UseVisualStyleBackColor = true;
            this.SendMailButton.Visible = false;
            this.SendMailButton.Click += new System.EventHandler(this.SendMailButton_Click);
            // 
            // CaptchaTextBox
            // 
            this.CaptchaTextBox.Location = new System.Drawing.Point(5, 231);
            this.CaptchaTextBox.Name = "CaptchaTextBox";
            this.CaptchaTextBox.Size = new System.Drawing.Size(118, 20);
            this.CaptchaTextBox.TabIndex = 10;
            this.CaptchaTextBox.Visible = false;
            // 
            // SendCaptchaButton
            // 
            this.SendCaptchaButton.Location = new System.Drawing.Point(130, 230);
            this.SendCaptchaButton.Name = "SendCaptchaButton";
            this.SendCaptchaButton.Size = new System.Drawing.Size(24, 20);
            this.SendCaptchaButton.TabIndex = 12;
            this.SendCaptchaButton.UseVisualStyleBackColor = true;
            this.SendCaptchaButton.Visible = false;
            this.SendCaptchaButton.Click += new System.EventHandler(this.SendCaptchaButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(166, 335);
            this.Controls.Add(this.SendCaptchaButton);
            this.Controls.Add(this.CaptchaLabel);
            this.Controls.Add(this.CaptchaTextBox);
            this.Controls.Add(this.SendMailButton);
            this.Controls.Add(this.SmtpTextBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.ForgotBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button ForgotBtn;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TextBox SmtpTextBox;
        private System.Windows.Forms.Button SendMailButton;
        private System.Windows.Forms.TextBox CaptchaTextBox;
        private System.Windows.Forms.Label CaptchaLabel;
        private System.Windows.Forms.Button SendCaptchaButton;
    }
}


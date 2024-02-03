﻿namespace ProjectClient
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.MailTxtBox = new System.Windows.Forms.TextBox();
            this.CodeTxtBox = new System.Windows.Forms.TextBox();
            this.UserTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SendCodeBtn = new System.Windows.Forms.Button();
            this.CaptchaTxtBox = new System.Windows.Forms.TextBox();
            this.CaptchaLbl = new System.Windows.Forms.Label();
            this.SendCaptchaBtn = new System.Windows.Forms.Button();
            this.CapthcaQstLbl = new System.Windows.Forms.Label();
            this.CheckBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(61, 421);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(175, 40);
            this.SignUpBtn.TabIndex = 0;
            this.SignUpBtn.Text = "Sign Up!";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // MailTxtBox
            // 
            this.MailTxtBox.Location = new System.Drawing.Point(57, 209);
            this.MailTxtBox.Name = "MailTxtBox";
            this.MailTxtBox.Size = new System.Drawing.Size(174, 22);
            this.MailTxtBox.TabIndex = 1;
            // 
            // CodeTxtBox
            // 
            this.CodeTxtBox.Location = new System.Drawing.Point(57, 275);
            this.CodeTxtBox.Name = "CodeTxtBox";
            this.CodeTxtBox.Size = new System.Drawing.Size(174, 22);
            this.CodeTxtBox.TabIndex = 2;
            this.CodeTxtBox.Visible = false;
            // 
            // UserTxtBox
            // 
            this.UserTxtBox.Location = new System.Drawing.Point(57, 82);
            this.UserTxtBox.Name = "UserTxtBox";
            this.UserTxtBox.Size = new System.Drawing.Size(174, 22);
            this.UserTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(53, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mail:";
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.Location = new System.Drawing.Point(57, 143);
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.PasswordChar = '•';
            this.PassTxtBox.Size = new System.Drawing.Size(174, 22);
            this.PassTxtBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(57, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Code:";
            this.label4.Visible = false;
            // 
            // SendCodeBtn
            // 
            this.SendCodeBtn.BackColor = System.Drawing.Color.Transparent;
            this.SendCodeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendCodeBtn.BackgroundImage")));
            this.SendCodeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SendCodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendCodeBtn.FlatAppearance.BorderSize = 0;
            this.SendCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendCodeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SendCodeBtn.Location = new System.Drawing.Point(237, 271);
            this.SendCodeBtn.Name = "SendCodeBtn";
            this.SendCodeBtn.Size = new System.Drawing.Size(55, 30);
            this.SendCodeBtn.TabIndex = 9;
            this.SendCodeBtn.UseVisualStyleBackColor = false;
            this.SendCodeBtn.Visible = false;
            this.SendCodeBtn.Click += new System.EventHandler(this.SendCodeBtn_Click);
            // 
            // CaptchaTxtBox
            // 
            this.CaptchaTxtBox.Location = new System.Drawing.Point(61, 374);
            this.CaptchaTxtBox.Name = "CaptchaTxtBox";
            this.CaptchaTxtBox.Size = new System.Drawing.Size(174, 22);
            this.CaptchaTxtBox.TabIndex = 10;
            this.CaptchaTxtBox.Visible = false;
            // 
            // CaptchaLbl
            // 
            this.CaptchaLbl.AutoSize = true;
            this.CaptchaLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptchaLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CaptchaLbl.Location = new System.Drawing.Point(58, 319);
            this.CaptchaLbl.Name = "CaptchaLbl";
            this.CaptchaLbl.Size = new System.Drawing.Size(67, 19);
            this.CaptchaLbl.TabIndex = 11;
            this.CaptchaLbl.Text = "Captcha:";
            this.CaptchaLbl.Visible = false;
            // 
            // SendCaptchaBtn
            // 
            this.SendCaptchaBtn.BackColor = System.Drawing.Color.Transparent;
            this.SendCaptchaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendCaptchaBtn.BackgroundImage")));
            this.SendCaptchaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SendCaptchaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendCaptchaBtn.FlatAppearance.BorderSize = 0;
            this.SendCaptchaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendCaptchaBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SendCaptchaBtn.Location = new System.Drawing.Point(237, 370);
            this.SendCaptchaBtn.Name = "SendCaptchaBtn";
            this.SendCaptchaBtn.Size = new System.Drawing.Size(55, 30);
            this.SendCaptchaBtn.TabIndex = 12;
            this.SendCaptchaBtn.UseVisualStyleBackColor = false;
            this.SendCaptchaBtn.Visible = false;
            this.SendCaptchaBtn.Click += new System.EventHandler(this.SendCaptchaBtn_Click);
            // 
            // CapthcaQstLbl
            // 
            this.CapthcaQstLbl.AutoSize = true;
            this.CapthcaQstLbl.BackColor = System.Drawing.Color.Silver;
            this.CapthcaQstLbl.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapthcaQstLbl.Location = new System.Drawing.Point(59, 338);
            this.CapthcaQstLbl.Name = "CapthcaQstLbl";
            this.CapthcaQstLbl.Size = new System.Drawing.Size(0, 17);
            this.CapthcaQstLbl.TabIndex = 13;
            this.ToolTip.SetToolTip(this.CapthcaQstLbl, resources.GetString("CapthcaQstLbl.ToolTip"));
            this.CapthcaQstLbl.Visible = false;
            // 
            // CheckBoxShowPassword
            // 
            this.CheckBoxShowPassword.AutoSize = true;
            this.CheckBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxShowPassword.Location = new System.Drawing.Point(238, 144);
            this.CheckBoxShowPassword.Name = "CheckBoxShowPassword";
            this.CheckBoxShowPassword.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxShowPassword.TabIndex = 14;
            this.ToolTip.SetToolTip(this.CheckBoxShowPassword, "Show Password Button!");
            this.CheckBoxShowPassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPassword_CheckedChanged);
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolTip.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(319, 496);
            this.Controls.Add(this.CheckBoxShowPassword);
            this.Controls.Add(this.CapthcaQstLbl);
            this.Controls.Add(this.SendCaptchaBtn);
            this.Controls.Add(this.CaptchaLbl);
            this.Controls.Add(this.CaptchaTxtBox);
            this.Controls.Add(this.SendCodeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserTxtBox);
            this.Controls.Add(this.CodeTxtBox);
            this.Controls.Add(this.MailTxtBox);
            this.Controls.Add(this.SignUpBtn);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.TextBox MailTxtBox;
        private System.Windows.Forms.TextBox CodeTxtBox;
        private System.Windows.Forms.TextBox UserTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendCodeBtn;
        private System.Windows.Forms.TextBox CaptchaTxtBox;
        private System.Windows.Forms.Label CaptchaLbl;
        private System.Windows.Forms.Button SendCaptchaBtn;
        private System.Windows.Forms.Label CapthcaQstLbl;
        private System.Windows.Forms.CheckBox CheckBoxShowPassword;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
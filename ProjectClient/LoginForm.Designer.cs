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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.NickBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.ForgotBtn = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.NameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NickBox
            // 
            this.NickBox.Location = new System.Drawing.Point(7, 147);
            this.NickBox.Name = "NickBox";
            this.NickBox.Size = new System.Drawing.Size(156, 22);
            this.NickBox.TabIndex = 0;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(7, 175);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '•';
            this.PassBox.Size = new System.Drawing.Size(156, 22);
            this.PassBox.TabIndex = 1;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInBtn.Location = new System.Drawing.Point(7, 203);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 33);
            this.SignInBtn.TabIndex = 2;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.Location = new System.Drawing.Point(88, 203);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(75, 33);
            this.SignUpBtn.TabIndex = 3;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // ForgotBtn
            // 
            this.ForgotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForgotBtn.Location = new System.Drawing.Point(7, 242);
            this.ForgotBtn.Name = "ForgotBtn";
            this.ForgotBtn.Size = new System.Drawing.Size(156, 46);
            this.ForgotBtn.TabIndex = 5;
            this.ForgotBtn.Text = "Forgot Password?";
            this.ForgotBtn.UseVisualStyleBackColor = true;
            this.ForgotBtn.Click += new System.EventHandler(this.ForgotBtn_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoBox.InitialImage")));
            this.LogoBox.Location = new System.Drawing.Point(53, 44);
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
            this.NameLbl.Location = new System.Drawing.Point(3, 9);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(152, 20);
            this.NameLbl.TabIndex = 7;
            this.NameLbl.Text = "Welcome To VLibrary";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(170, 300);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.ForgotBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.NickBox);
            this.Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NickBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button ForgotBtn;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label NameLbl;
    }
}


namespace ProjectClient
{
    partial class ForgotPassForm
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
            this.MailTxtBox = new System.Windows.Forms.TextBox();
            this.NewPassTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendMailBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SendPassBtn = new System.Windows.Forms.Button();
            this.CodeTxtBox = new System.Windows.Forms.TextBox();
            this.SendCodeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MailTxtBox
            // 
            this.MailTxtBox.Location = new System.Drawing.Point(12, 39);
            this.MailTxtBox.Name = "MailTxtBox";
            this.MailTxtBox.Size = new System.Drawing.Size(171, 22);
            this.MailTxtBox.TabIndex = 0;
            // 
            // NewPassTxtBox
            // 
            this.NewPassTxtBox.Location = new System.Drawing.Point(12, 141);
            this.NewPassTxtBox.Name = "NewPassTxtBox";
            this.NewPassTxtBox.Size = new System.Drawing.Size(171, 22);
            this.NewPassTxtBox.TabIndex = 1;
            this.NewPassTxtBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Mail:";
            // 
            // SendMailBtn
            // 
            this.SendMailBtn.Location = new System.Drawing.Point(189, 39);
            this.SendMailBtn.Name = "SendMailBtn";
            this.SendMailBtn.Size = new System.Drawing.Size(113, 22);
            this.SendMailBtn.TabIndex = 3;
            this.SendMailBtn.Text = "Send";
            this.SendMailBtn.UseVisualStyleBackColor = true;
            this.SendMailBtn.Click += new System.EventHandler(this.SendMailBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter New Password:";
            this.label2.Visible = false;
            // 
            // SendPassBtn
            // 
            this.SendPassBtn.Location = new System.Drawing.Point(189, 141);
            this.SendPassBtn.Name = "SendPassBtn";
            this.SendPassBtn.Size = new System.Drawing.Size(113, 22);
            this.SendPassBtn.TabIndex = 5;
            this.SendPassBtn.Text = "Send";
            this.SendPassBtn.UseVisualStyleBackColor = true;
            this.SendPassBtn.Visible = false;
            this.SendPassBtn.Click += new System.EventHandler(this.SendPassBtn_Click);
            // 
            // CodeTxtBox
            // 
            this.CodeTxtBox.Location = new System.Drawing.Point(12, 72);
            this.CodeTxtBox.Name = "CodeTxtBox";
            this.CodeTxtBox.Size = new System.Drawing.Size(171, 22);
            this.CodeTxtBox.TabIndex = 6;
            this.CodeTxtBox.Visible = false;
            this.CodeTxtBox.TextChanged += new System.EventHandler(this.CodeTxtBox_TextChanged);
            // 
            // SendCodeBtn
            // 
            this.SendCodeBtn.BackColor = System.Drawing.Color.Gold;
            this.SendCodeBtn.Location = new System.Drawing.Point(189, 71);
            this.SendCodeBtn.Name = "SendCodeBtn";
            this.SendCodeBtn.Size = new System.Drawing.Size(29, 24);
            this.SendCodeBtn.TabIndex = 7;
            this.SendCodeBtn.UseVisualStyleBackColor = false;
            this.SendCodeBtn.Visible = false;
            this.SendCodeBtn.Click += new System.EventHandler(this.SendCodeBtn_Click);
            // 
            // ForgotPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(308, 179);
            this.Controls.Add(this.SendCodeBtn);
            this.Controls.Add(this.CodeTxtBox);
            this.Controls.Add(this.SendPassBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SendMailBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPassTxtBox);
            this.Controls.Add(this.MailTxtBox);
            this.Name = "ForgotPassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MailTxtBox;
        private System.Windows.Forms.TextBox NewPassTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendMailBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendPassBtn;
        private System.Windows.Forms.TextBox CodeTxtBox;
        private System.Windows.Forms.Button SendCodeBtn;
    }
}
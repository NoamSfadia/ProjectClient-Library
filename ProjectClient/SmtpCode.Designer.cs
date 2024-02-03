namespace ProjectClient
{
    partial class SmtpCode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.MailLabel = new System.Windows.Forms.Label();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.SendMailButton = new System.Windows.Forms.Button();
            this.SendCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(3, 29);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(144, 22);
            this.MailTextBox.TabIndex = 0;
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MailLabel.Location = new System.Drawing.Point(3, 10);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(69, 16);
            this.MailLabel.TabIndex = 1;
            this.MailLabel.Text = "Enter Mail:";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(3, 73);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(144, 22);
            this.CodeTextBox.TabIndex = 2;
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CodeLabel.Location = new System.Drawing.Point(3, 54);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(77, 16);
            this.CodeLabel.TabIndex = 3;
            this.CodeLabel.Text = "Enter Code:";
            // 
            // SendMailButton
            // 
            this.SendMailButton.Location = new System.Drawing.Point(153, 29);
            this.SendMailButton.Name = "SendMailButton";
            this.SendMailButton.Size = new System.Drawing.Size(30, 23);
            this.SendMailButton.TabIndex = 4;
            this.SendMailButton.UseVisualStyleBackColor = true;
            this.SendMailButton.Click += new System.EventHandler(this.SendMailButton_Click);
            // 
            // SendCodeButton
            // 
            this.SendCodeButton.Location = new System.Drawing.Point(153, 72);
            this.SendCodeButton.Name = "SendCodeButton";
            this.SendCodeButton.Size = new System.Drawing.Size(30, 23);
            this.SendCodeButton.TabIndex = 5;
            this.SendCodeButton.UseVisualStyleBackColor = true;
            this.SendCodeButton.Click += new System.EventHandler(this.SendCodeButton_Click);
            // 
            // SmtpCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SendCodeButton);
            this.Controls.Add(this.SendMailButton);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.MailTextBox);
            this.Name = "SmtpCode";
            this.Size = new System.Drawing.Size(188, 106);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Button SendMailButton;
        private System.Windows.Forms.Button SendCodeButton;
    }
}

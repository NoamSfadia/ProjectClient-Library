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
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.SendCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(0, 15);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(109, 20);
            this.CodeTextBox.TabIndex = 2;
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CodeLabel.Location = new System.Drawing.Point(-1, 0);
            this.CodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(63, 13);
            this.CodeLabel.TabIndex = 3;
            this.CodeLabel.Text = "Enter Code:";
            // 
            // SendCodeButton
            // 
            this.SendCodeButton.Location = new System.Drawing.Point(113, 15);
            this.SendCodeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendCodeButton.Name = "SendCodeButton";
            this.SendCodeButton.Size = new System.Drawing.Size(22, 19);
            this.SendCodeButton.TabIndex = 5;
            this.SendCodeButton.UseVisualStyleBackColor = true;
            this.SendCodeButton.Click += new System.EventHandler(this.SendCodeButton_Click);
            // 
            // SmtpCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SendCodeButton);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.CodeTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SmtpCode";
            this.Size = new System.Drawing.Size(141, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Button SendCodeButton;
    }
}

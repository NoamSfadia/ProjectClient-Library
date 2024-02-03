namespace ProjectClient
{
    partial class HomeScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreenForm));
            this.DateLbl = new System.Windows.Forms.Label();
            this.UsernameGreetLbl = new System.Windows.Forms.Label();
            this.LibrariesComboBox = new System.Windows.Forms.ComboBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookPreviewControl2 = new ProjectClient.BookPreviewControl();
            this.bookPreviewControl3 = new ProjectClient.BookPreviewControl();
            this.bookPreviewControl4 = new ProjectClient.BookPreviewControl();
            this.bookPreviewControl5 = new ProjectClient.BookPreviewControl();
            this.bookPreviewControl6 = new ProjectClient.BookPreviewControl();
            this.bookPreviewControl1 = new ProjectClient.BookPreviewControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateLbl.Location = new System.Drawing.Point(784, 13);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(0, 28);
            this.DateLbl.TabIndex = 0;
            // 
            // UsernameGreetLbl
            // 
            this.UsernameGreetLbl.AutoSize = true;
            this.UsernameGreetLbl.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameGreetLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameGreetLbl.Location = new System.Drawing.Point(22, 13);
            this.UsernameGreetLbl.MaximumSize = new System.Drawing.Size(200, 0);
            this.UsernameGreetLbl.Name = "UsernameGreetLbl";
            this.UsernameGreetLbl.Size = new System.Drawing.Size(51, 28);
            this.UsernameGreetLbl.TabIndex = 1;
            this.UsernameGreetLbl.Text = "Hey,";
            // 
            // LibrariesComboBox
            // 
            this.LibrariesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LibrariesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LibrariesComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LibrariesComboBox.FormattingEnabled = true;
            this.LibrariesComboBox.Location = new System.Drawing.Point(306, 17);
            this.LibrariesComboBox.Name = "LibrariesComboBox";
            this.LibrariesComboBox.Size = new System.Drawing.Size(312, 24);
            this.LibrariesComboBox.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(986, 463);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(80, 80);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookPreviewControl1);
            this.panel1.Controls.Add(this.bookPreviewControl6);
            this.panel1.Controls.Add(this.bookPreviewControl5);
            this.panel1.Controls.Add(this.bookPreviewControl4);
            this.panel1.Controls.Add(this.bookPreviewControl3);
            this.panel1.Controls.Add(this.bookPreviewControl2);
            this.panel1.Location = new System.Drawing.Point(27, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 350);
            this.panel1.TabIndex = 4;
            // 
            // bookPreviewControl2
            // 
            this.bookPreviewControl2.BackColor = System.Drawing.Color.White;
            this.bookPreviewControl2.Location = new System.Drawing.Point(163, 1);
            this.bookPreviewControl2.Name = "bookPreviewControl2";
            this.bookPreviewControl2.Size = new System.Drawing.Size(160, 349);
            this.bookPreviewControl2.TabIndex = 0;
            // 
            // bookPreviewControl3
            // 
            this.bookPreviewControl3.BackColor = System.Drawing.Color.White;
            this.bookPreviewControl3.Location = new System.Drawing.Point(329, 0);
            this.bookPreviewControl3.Name = "bookPreviewControl3";
            this.bookPreviewControl3.Size = new System.Drawing.Size(160, 349);
            this.bookPreviewControl3.TabIndex = 1;
            // 
            // bookPreviewControl4
            // 
            this.bookPreviewControl4.BackColor = System.Drawing.Color.White;
            this.bookPreviewControl4.Location = new System.Drawing.Point(495, 1);
            this.bookPreviewControl4.Name = "bookPreviewControl4";
            this.bookPreviewControl4.Size = new System.Drawing.Size(160, 349);
            this.bookPreviewControl4.TabIndex = 2;
            // 
            // bookPreviewControl5
            // 
            this.bookPreviewControl5.BackColor = System.Drawing.Color.White;
            this.bookPreviewControl5.Location = new System.Drawing.Point(661, 0);
            this.bookPreviewControl5.Name = "bookPreviewControl5";
            this.bookPreviewControl5.Size = new System.Drawing.Size(160, 349);
            this.bookPreviewControl5.TabIndex = 3;
            // 
            // bookPreviewControl6
            // 
            this.bookPreviewControl6.BackColor = System.Drawing.Color.White;
            this.bookPreviewControl6.Location = new System.Drawing.Point(827, 0);
            this.bookPreviewControl6.Name = "bookPreviewControl6";
            this.bookPreviewControl6.Size = new System.Drawing.Size(160, 349);
            this.bookPreviewControl6.TabIndex = 4;
            // 
            // bookPreviewControl1
            // 
            this.bookPreviewControl1.BackColor = System.Drawing.Color.White;
            this.bookPreviewControl1.Location = new System.Drawing.Point(-3, 1);
            this.bookPreviewControl1.Name = "bookPreviewControl1";
            this.bookPreviewControl1.Size = new System.Drawing.Size(160, 349);
            this.bookPreviewControl1.TabIndex = 5;
            // 
            // HomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1062, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.LibrariesComboBox);
            this.Controls.Add(this.UsernameGreetLbl);
            this.Controls.Add(this.DateLbl);
            this.Name = "HomeScreenForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeScreenForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label UsernameGreetLbl;
        private System.Windows.Forms.ComboBox LibrariesComboBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel panel1;
        private BookPreviewControl bookPreviewControl2;
        private BookPreviewControl bookPreviewControl1;
        private BookPreviewControl bookPreviewControl6;
        private BookPreviewControl bookPreviewControl5;
        private BookPreviewControl bookPreviewControl4;
        private BookPreviewControl bookPreviewControl3;
    }
}
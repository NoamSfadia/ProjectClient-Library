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
            this.FilterGenreComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByFilterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PageNumberLabel = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.ButtonForSeacrh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NextButtonPage = new System.Windows.Forms.PictureBox();
            this.PreviousButtonPage = new System.Windows.Forms.PictureBox();
            this.RefreshButton = new System.Windows.Forms.PictureBox();
            this.SettingsLaunchPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NextButtonPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousButtonPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsLaunchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateLbl.Location = new System.Drawing.Point(24, 34);
            this.DateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(0, 15);
            this.DateLbl.TabIndex = 0;
            // 
            // UsernameGreetLbl
            // 
            this.UsernameGreetLbl.AutoSize = true;
            this.UsernameGreetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameGreetLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameGreetLbl.Location = new System.Drawing.Point(16, 9);
            this.UsernameGreetLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameGreetLbl.MaximumSize = new System.Drawing.Size(150, 0);
            this.UsernameGreetLbl.Name = "UsernameGreetLbl";
            this.UsernameGreetLbl.Size = new System.Drawing.Size(49, 24);
            this.UsernameGreetLbl.TabIndex = 1;
            this.UsernameGreetLbl.Text = "Hey,";
            // 
            // FilterGenreComboBox
            // 
            this.FilterGenreComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FilterGenreComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FilterGenreComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterGenreComboBox.FormattingEnabled = true;
            this.FilterGenreComboBox.Location = new System.Drawing.Point(497, 19);
            this.FilterGenreComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilterGenreComboBox.Name = "FilterGenreComboBox";
            this.FilterGenreComboBox.Size = new System.Drawing.Size(130, 21);
            this.FilterGenreComboBox.TabIndex = 2;
            // 
            // SearchByFilterButton
            // 
            this.SearchByFilterButton.BackColor = System.Drawing.Color.Lime;
            this.SearchByFilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchByFilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchByFilterButton.FlatAppearance.BorderSize = 3;
            this.SearchByFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchByFilterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchByFilterButton.Location = new System.Drawing.Point(632, 12);
            this.SearchByFilterButton.Name = "SearchByFilterButton";
            this.SearchByFilterButton.Size = new System.Drawing.Size(32, 32);
            this.SearchByFilterButton.TabIndex = 4;
            this.SearchByFilterButton.UseVisualStyleBackColor = false;
            this.SearchByFilterButton.Click += new System.EventHandler(this.SearchByFilterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(494, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(20, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 268);
            this.panel1.TabIndex = 9;
            // 
            // PageNumberLabel
            // 
            this.PageNumberLabel.AutoSize = true;
            this.PageNumberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PageNumberLabel.Location = new System.Drawing.Point(372, 343);
            this.PageNumberLabel.Name = "PageNumberLabel";
            this.PageNumberLabel.Size = new System.Drawing.Size(0, 35);
            this.PageNumberLabel.TabIndex = 10;
            this.PageNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(204, 17);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(216, 20);
            this.SearchBar.TabIndex = 15;
            // 
            // ButtonForSeacrh
            // 
            this.ButtonForSeacrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonForSeacrh.Location = new System.Drawing.Point(426, 15);
            this.ButtonForSeacrh.Name = "ButtonForSeacrh";
            this.ButtonForSeacrh.Size = new System.Drawing.Size(62, 23);
            this.ButtonForSeacrh.TabIndex = 16;
            this.ButtonForSeacrh.Text = "SEARCH";
            this.ButtonForSeacrh.UseVisualStyleBackColor = true;
            this.ButtonForSeacrh.Click += new System.EventHandler(this.ButtonForSeacrh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(426, 17);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(23, 23);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "button1";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NextButtonPage
            // 
            this.NextButtonPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextButtonPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButtonPage.Image = ((System.Drawing.Image)(resources.GetObject("NextButtonPage.Image")));
            this.NextButtonPage.Location = new System.Drawing.Point(400, 343);
            this.NextButtonPage.Name = "NextButtonPage";
            this.NextButtonPage.Size = new System.Drawing.Size(32, 32);
            this.NextButtonPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextButtonPage.TabIndex = 14;
            this.NextButtonPage.TabStop = false;
            this.NextButtonPage.Click += new System.EventHandler(this.NextButtonPage_Click);
            // 
            // PreviousButtonPage
            // 
            this.PreviousButtonPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousButtonPage.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButtonPage.Image")));
            this.PreviousButtonPage.Location = new System.Drawing.Point(334, 343);
            this.PreviousButtonPage.Name = "PreviousButtonPage";
            this.PreviousButtonPage.Size = new System.Drawing.Size(32, 32);
            this.PreviousButtonPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviousButtonPage.TabIndex = 13;
            this.PreviousButtonPage.TabStop = false;
            this.PreviousButtonPage.Click += new System.EventHandler(this.PreviousButtonPage_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.Image = global::ProjectClient.Properties.Resources._204_2048084_reload_refresh_icon_ios1;
            this.RefreshButton.Location = new System.Drawing.Point(716, 11);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(32, 32);
            this.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SettingsLaunchPictureBox
            // 
            this.SettingsLaunchPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsLaunchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SettingsLaunchPictureBox.Image")));
            this.SettingsLaunchPictureBox.Location = new System.Drawing.Point(754, 11);
            this.SettingsLaunchPictureBox.Name = "SettingsLaunchPictureBox";
            this.SettingsLaunchPictureBox.Size = new System.Drawing.Size(32, 32);
            this.SettingsLaunchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsLaunchPictureBox.TabIndex = 7;
            this.SettingsLaunchPictureBox.TabStop = false;
            this.SettingsLaunchPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::ProjectClient.Properties.Resources.VlibraryLogo64;
            this.ClientSize = new System.Drawing.Size(796, 397);
            this.Controls.Add(this.ButtonForSeacrh);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.NextButtonPage);
            this.Controls.Add(this.PreviousButtonPage);
            this.Controls.Add(this.PageNumberLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SettingsLaunchPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchByFilterButton);
            this.Controls.Add(this.FilterGenreComboBox);
            this.Controls.Add(this.UsernameGreetLbl);
            this.Controls.Add(this.DateLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeScreenForm_Load);
            this.Leave += new System.EventHandler(this.HomeScreenForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.NextButtonPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousButtonPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsLaunchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label UsernameGreetLbl;
        private System.Windows.Forms.ComboBox FilterGenreComboBox;
        private System.Windows.Forms.Button SearchByFilterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SettingsLaunchPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PageNumberLabel;
        private System.Windows.Forms.PictureBox PreviousButtonPage;
        private System.Windows.Forms.PictureBox NextButtonPage;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button ButtonForSeacrh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.PictureBox RefreshButton;
    }
}
namespace ProjectClient
{
    partial class OrderscreenForm
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
            this.SummaryTextBox = new System.Windows.Forms.RichTextBox();
            this.RatingBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SendRateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WishlistButton = new System.Windows.Forms.PictureBox();
            this.AlreadyReadButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.LibrariesComboBox = new System.Windows.Forms.ComboBox();
            this.BookQuantityCounter = new System.Windows.Forms.NumericUpDown();
            this.ChooseLibraryLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendQuantity = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowLibrarianOptionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RatingBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WishlistButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlreadyReadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookQuantityCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.BackColor = System.Drawing.Color.White;
            this.SummaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SummaryTextBox.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTextBox.ForeColor = System.Drawing.Color.Red;
            this.SummaryTextBox.Location = new System.Drawing.Point(-4, 1);
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.ReadOnly = true;
            this.SummaryTextBox.Size = new System.Drawing.Size(240, 116);
            this.SummaryTextBox.TabIndex = 0;
            this.SummaryTextBox.Text = "";
            // 
            // RatingBar
            // 
            this.RatingBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RatingBar.Location = new System.Drawing.Point(54, 149);
            this.RatingBar.Maximum = 5;
            this.RatingBar.Name = "RatingBar";
            this.RatingBar.Size = new System.Drawing.Size(125, 45);
            this.RatingBar.TabIndex = 6;
            this.RatingBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RatingBar.Scroll += new System.EventHandler(this.RatingBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(155, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 7;
            // 
            // SendRateButton
            // 
            this.SendRateButton.BackColor = System.Drawing.Color.Gold;
            this.SendRateButton.ForeColor = System.Drawing.Color.Transparent;
            this.SendRateButton.Location = new System.Drawing.Point(182, 149);
            this.SendRateButton.Name = "SendRateButton";
            this.SendRateButton.Size = new System.Drawing.Size(33, 16);
            this.SendRateButton.TabIndex = 8;
            this.SendRateButton.UseVisualStyleBackColor = false;
            this.SendRateButton.Click += new System.EventHandler(this.SendRateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(19, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rate the Book!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(161, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "«";
            // 
            // WishlistButton
            // 
            this.WishlistButton.BackColor = System.Drawing.Color.Transparent;
            this.WishlistButton.Image = global::ProjectClient.Properties.Resources.Screenshot_2024_03_09_2049521;
            this.WishlistButton.Location = new System.Drawing.Point(315, 203);
            this.WishlistButton.Name = "WishlistButton";
            this.WishlistButton.Size = new System.Drawing.Size(32, 32);
            this.WishlistButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WishlistButton.TabIndex = 5;
            this.WishlistButton.TabStop = false;
            this.WishlistButton.Click += new System.EventHandler(this.WishlistButton_Click_1);
            // 
            // AlreadyReadButton
            // 
            this.AlreadyReadButton.Image = global::ProjectClient.Properties.Resources.Screenshot_2024_03_09_203024;
            this.AlreadyReadButton.Location = new System.Drawing.Point(277, 203);
            this.AlreadyReadButton.Name = "AlreadyReadButton";
            this.AlreadyReadButton.Size = new System.Drawing.Size(32, 32);
            this.AlreadyReadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlreadyReadButton.TabIndex = 4;
            this.AlreadyReadButton.TabStop = false;
            this.AlreadyReadButton.Click += new System.EventHandler(this.AlreadyReadButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(234, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(200, 207);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(71, 21);
            this.OrderButton.TabIndex = 11;
            this.OrderButton.Text = "ORDER!";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // LibrariesComboBox
            // 
            this.LibrariesComboBox.FormattingEnabled = true;
            this.LibrariesComboBox.Location = new System.Drawing.Point(26, 207);
            this.LibrariesComboBox.Name = "LibrariesComboBox";
            this.LibrariesComboBox.Size = new System.Drawing.Size(168, 21);
            this.LibrariesComboBox.TabIndex = 12;
            this.LibrariesComboBox.SelectedIndexChanged += new System.EventHandler(this.LibrariesComboBox_SelectedIndexChanged);
            // 
            // BookQuantityCounter
            // 
            this.BookQuantityCounter.Location = new System.Drawing.Point(356, 85);
            this.BookQuantityCounter.Name = "BookQuantityCounter";
            this.BookQuantityCounter.Size = new System.Drawing.Size(87, 20);
            this.BookQuantityCounter.TabIndex = 13;
            this.BookQuantityCounter.Visible = false;
            // 
            // ChooseLibraryLabel
            // 
            this.ChooseLibraryLabel.AutoSize = true;
            this.ChooseLibraryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChooseLibraryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChooseLibraryLabel.Location = new System.Drawing.Point(23, 188);
            this.ChooseLibraryLabel.Name = "ChooseLibraryLabel";
            this.ChooseLibraryLabel.Size = new System.Drawing.Size(116, 16);
            this.ChooseLibraryLabel.TabIndex = 14;
            this.ChooseLibraryLabel.Text = "Choose Library:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(353, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Set Book Quantity:";
            this.label4.Visible = false;
            // 
            // SendQuantity
            // 
            this.SendQuantity.Location = new System.Drawing.Point(449, 85);
            this.SendQuantity.Name = "SendQuantity";
            this.SendQuantity.Size = new System.Drawing.Size(29, 20);
            this.SendQuantity.TabIndex = 16;
            this.SendQuantity.UseVisualStyleBackColor = true;
            this.SendQuantity.Visible = false;
            this.SendQuantity.Click += new System.EventHandler(this.SendQuantity_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(353, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Current Quantity:";
            this.label5.Visible = false;
            // 
            // ShowLibrarianOptionButton
            // 
            this.ShowLibrarianOptionButton.Location = new System.Drawing.Point(356, 13);
            this.ShowLibrarianOptionButton.Name = "ShowLibrarianOptionButton";
            this.ShowLibrarianOptionButton.Size = new System.Drawing.Size(122, 23);
            this.ShowLibrarianOptionButton.TabIndex = 18;
            this.ShowLibrarianOptionButton.Text = "Show Options";
            this.ShowLibrarianOptionButton.UseVisualStyleBackColor = true;
            this.ShowLibrarianOptionButton.Visible = false;
            this.ShowLibrarianOptionButton.Click += new System.EventHandler(this.ShowLibrarianOptionButton_Click);
            // 
            // OrderscreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(490, 242);
            this.Controls.Add(this.ShowLibrarianOptionButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SendQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChooseLibraryLabel);
            this.Controls.Add(this.BookQuantityCounter);
            this.Controls.Add(this.LibrariesComboBox);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SendRateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RatingBar);
            this.Controls.Add(this.WishlistButton);
            this.Controls.Add(this.AlreadyReadButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SummaryTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderscreenForm";
            this.Load += new System.EventHandler(this.OrderscreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RatingBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WishlistButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlreadyReadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookQuantityCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SummaryTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox AlreadyReadButton;
        private System.Windows.Forms.PictureBox WishlistButton;
        private System.Windows.Forms.TrackBar RatingBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendRateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.NumericUpDown BookQuantityCounter;
        private System.Windows.Forms.Label ChooseLibraryLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendQuantity;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox LibrariesComboBox;
        private System.Windows.Forms.Button ShowLibrarianOptionButton;
    }
}
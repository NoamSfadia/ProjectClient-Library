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
            this.WishlistButton = new System.Windows.Forms.PictureBox();
            this.AlreadyReadButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RatingBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SendRateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WishlistButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlreadyReadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.BackColor = System.Drawing.Color.White;
            this.SummaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SummaryTextBox.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTextBox.ForeColor = System.Drawing.Color.Red;
            this.SummaryTextBox.Location = new System.Drawing.Point(106, 1);
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.ReadOnly = true;
            this.SummaryTextBox.Size = new System.Drawing.Size(127, 190);
            this.SummaryTextBox.TabIndex = 0;
            this.SummaryTextBox.Text = "";
            // 
            // WishlistButton
            // 
            this.WishlistButton.BackColor = System.Drawing.Color.Transparent;
            this.WishlistButton.Image = global::ProjectClient.Properties.Resources.Screenshot_2024_03_09_2049521;
            this.WishlistButton.Location = new System.Drawing.Point(186, 197);
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
            this.AlreadyReadButton.Location = new System.Drawing.Point(148, 197);
            this.AlreadyReadButton.Name = "AlreadyReadButton";
            this.AlreadyReadButton.Size = new System.Drawing.Size(32, 32);
            this.AlreadyReadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlreadyReadButton.TabIndex = 4;
            this.AlreadyReadButton.TabStop = false;
            this.AlreadyReadButton.Click += new System.EventHandler(this.AlreadyReadButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // RatingBar
            // 
            this.RatingBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RatingBar.Location = new System.Drawing.Point(-4, 243);
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
            this.label1.Location = new System.Drawing.Point(53, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 7;
            // 
            // SendRateButton
            // 
            this.SendRateButton.BackColor = System.Drawing.Color.Gold;
            this.SendRateButton.ForeColor = System.Drawing.Color.Transparent;
            this.SendRateButton.Location = new System.Drawing.Point(127, 243);
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
            this.label2.Location = new System.Drawing.Point(1, 197);
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
            this.label3.Location = new System.Drawing.Point(67, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "«";
            // 
            // OrderscreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(230, 284);
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
            ((System.ComponentModel.ISupportInitialize)(this.WishlistButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlreadyReadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingBar)).EndInit();
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
    }
}
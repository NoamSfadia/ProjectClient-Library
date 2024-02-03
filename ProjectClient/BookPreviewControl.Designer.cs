namespace ProjectClient
{
    partial class BookPreviewControl
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
            this.BookImageBox = new System.Windows.Forms.PictureBox();
            this.OrderBookButton = new System.Windows.Forms.Button();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookGenreLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.BookRatingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BookImageBox
            // 
            this.BookImageBox.Location = new System.Drawing.Point(0, 0);
            this.BookImageBox.Name = "BookImageBox";
            this.BookImageBox.Size = new System.Drawing.Size(160, 240);
            this.BookImageBox.TabIndex = 0;
            this.BookImageBox.TabStop = false;
            this.BookImageBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OrderBookButton
            // 
            this.OrderBookButton.Location = new System.Drawing.Point(0, 308);
            this.OrderBookButton.Name = "OrderBookButton";
            this.OrderBookButton.Size = new System.Drawing.Size(160, 23);
            this.OrderBookButton.TabIndex = 1;
            this.OrderBookButton.Text = "ORDER NOW";
            this.OrderBookButton.UseVisualStyleBackColor = true;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(0, 241);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(44, 16);
            this.BookNameLabel.TabIndex = 2;
            this.BookNameLabel.Text = "Name";
            // 
            // BookGenreLabel
            // 
            this.BookGenreLabel.AutoSize = true;
            this.BookGenreLabel.Location = new System.Drawing.Point(0, 273);
            this.BookGenreLabel.Name = "BookGenreLabel";
            this.BookGenreLabel.Size = new System.Drawing.Size(44, 16);
            this.BookGenreLabel.TabIndex = 3;
            this.BookGenreLabel.Text = "Genre";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(0, 257);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(45, 16);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author";
            // 
            // BookRatingLabel
            // 
            this.BookRatingLabel.AutoSize = true;
            this.BookRatingLabel.Location = new System.Drawing.Point(0, 289);
            this.BookRatingLabel.Name = "BookRatingLabel";
            this.BookRatingLabel.Size = new System.Drawing.Size(36, 16);
            this.BookRatingLabel.TabIndex = 5;
            this.BookRatingLabel.Text = "Rate";
            // 
            // BookPreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BookRatingLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.BookGenreLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.OrderBookButton);
            this.Controls.Add(this.BookImageBox);
            this.Name = "BookPreviewControl";
            this.Size = new System.Drawing.Size(160, 330);
            ((System.ComponentModel.ISupportInitialize)(this.BookImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BookImageBox;
        private System.Windows.Forms.Button OrderBookButton;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label BookGenreLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label BookRatingLabel;
    }
}

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
            this.OrderBookButton = new System.Windows.Forms.Button();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookGenreLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.BookRatingLabel = new System.Windows.Forms.Label();
            this.StarLabel = new System.Windows.Forms.Label();
            this.BookImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BookImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderBookButton
            // 
            this.OrderBookButton.Location = new System.Drawing.Point(0, 250);
            this.OrderBookButton.Margin = new System.Windows.Forms.Padding(2);
            this.OrderBookButton.Name = "OrderBookButton";
            this.OrderBookButton.Size = new System.Drawing.Size(120, 19);
            this.OrderBookButton.TabIndex = 1;
            this.OrderBookButton.Text = "ORDER NOW";
            this.OrderBookButton.UseVisualStyleBackColor = true;
            this.OrderBookButton.Click += new System.EventHandler(this.OrderBookButton_Click);
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(0, 196);
            this.BookNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(35, 13);
            this.BookNameLabel.TabIndex = 2;
            this.BookNameLabel.Text = "Name";
            this.BookNameLabel.Click += new System.EventHandler(this.BookNameLabel_Click);
            // 
            // BookGenreLabel
            // 
            this.BookGenreLabel.AutoSize = true;
            this.BookGenreLabel.Location = new System.Drawing.Point(0, 222);
            this.BookGenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookGenreLabel.Name = "BookGenreLabel";
            this.BookGenreLabel.Size = new System.Drawing.Size(36, 13);
            this.BookGenreLabel.TabIndex = 3;
            this.BookGenreLabel.Text = "Genre";
            this.BookGenreLabel.Click += new System.EventHandler(this.BookGenreLabel_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(0, 209);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author";
            this.AuthorLabel.Click += new System.EventHandler(this.AuthorLabel_Click);
            // 
            // BookRatingLabel
            // 
            this.BookRatingLabel.AutoSize = true;
            this.BookRatingLabel.Location = new System.Drawing.Point(0, 235);
            this.BookRatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookRatingLabel.Name = "BookRatingLabel";
            this.BookRatingLabel.Size = new System.Drawing.Size(30, 13);
            this.BookRatingLabel.TabIndex = 5;
            this.BookRatingLabel.Text = "Rate";
            this.BookRatingLabel.Click += new System.EventHandler(this.BookRatingLabel_Click);
            // 
            // StarLabel
            // 
            this.StarLabel.AutoSize = true;
            this.StarLabel.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.StarLabel.Location = new System.Drawing.Point(35, 236);
            this.StarLabel.Name = "StarLabel";
            this.StarLabel.Size = new System.Drawing.Size(19, 15);
            this.StarLabel.TabIndex = 6;
            this.StarLabel.Text = "«";
            this.StarLabel.Click += new System.EventHandler(this.StarLabel_Click);
            // 
            // BookImageBox
            // 
            this.BookImageBox.Image = global::ProjectClient.Properties.Resources.camera_not_allowed_no_photography_image_not_available_concept_icon_in_line_style_design_isolated_on_white_background_editable_stroke_vector;
            this.BookImageBox.Location = new System.Drawing.Point(0, 0);
            this.BookImageBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookImageBox.Name = "BookImageBox";
            this.BookImageBox.Size = new System.Drawing.Size(120, 195);
            this.BookImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookImageBox.TabIndex = 0;
            this.BookImageBox.TabStop = false;
            this.BookImageBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BookPreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.StarLabel);
            this.Controls.Add(this.BookRatingLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.BookGenreLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.OrderBookButton);
            this.Controls.Add(this.BookImageBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookPreviewControl";
            this.Size = new System.Drawing.Size(120, 268);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BookPreviewControl_MouseDoubleClick);
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
        private System.Windows.Forms.Label StarLabel;
    }
}

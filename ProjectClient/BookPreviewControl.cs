using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClient
{
    public partial class BookPreviewControl : UserControl
    {
        public event EventHandler<string> OnOrderButtonClick;
        public bool isUsed = false;
        public string Summary = "";
        private string DefaultBookImage = @"C:\Users\User\source\repos\ProjectClient-Library\ProjectClient\Resources\camera-not-allowed-no-photography-image-not-available-concept-icon-in-line-style-design-isolated-on-white-background-editable-stroke-vector.jpg";
        private string BookImage = "";
        private static string username;
        private string bookName;
        public BookPreviewControl(string user)
        {
            InitializeComponent();
            username = user;

        }
        public void setBookLabels(string name, string author, string genre, string rate, string summary, string image)
        {
            BookNameLabel.Text = bookName = name;
            AuthorLabel.Text = author;
            BookGenreLabel.Text = genre;
            BookRatingLabel.Text = rate;
            Summary = summary;
            BookImage = image;

            if(image != null) 
            {
                byte[] bytes = Convert.FromBase64String(image);
                using (MemoryStream memoryStream = new MemoryStream(bytes))
                {
                        BookImageBox.Image = Image.FromStream(memoryStream);
                }
            }
            else 
            {
                BookImageBox.Image = System.Drawing.Bitmap.FromFile(DefaultBookImage);
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OrderBookButton_Click(object sender, EventArgs e)
        {
            if(Summary != "")
            {
                OrderscreenForm orderscreenForm = new OrderscreenForm(BookImage, Summary,username, bookName);
                orderscreenForm.ShowDialog();
            }   
        }

        private void StarLabel_Click(object sender, EventArgs e)
        {

        }

        private void BookNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void BookGenreLabel_Click(object sender, EventArgs e)
        {

        }

        private void AuthorLabel_Click(object sender, EventArgs e)
        {

        }

        private void BookRatingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

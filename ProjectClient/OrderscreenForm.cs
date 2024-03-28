using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectClient
{
    public partial class OrderscreenForm : Form
    {
        private static string Username;
        private static string BookName;
        
        public OrderscreenForm(string image, string Summary,string username,string book)
        {
            InitializeComponent();
            byte[] bytes = Convert.FromBase64String(image);
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                pictureBox1.Image = System.Drawing.Image.FromStream(memoryStream);
            }
            Task.Run(() => { SummaryTextBox.Text = Summary; });
            Username = username;
            BookName = book;

        }
        private void WishlistButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AlreadyReadButton_Click_1(object sender, EventArgs e)
        {
            NetHandler.SendMessage("AddReadBook:" + BookName);
            string greenCheckmarkPhoto = @"C:\Users\User\source\repos\ProjectClient-Library\ProjectClient\Resources\Screenshot 2024-03-09 203148.png";
            AlreadyReadButton.Image = System.Drawing.Bitmap.FromFile(greenCheckmarkPhoto);
        }

        private void WishlistButton_Click_1(object sender, EventArgs e)
        {
            NetHandler.SendMessage("AddWishBook:" + BookName);
            string RedHeartPhoto = @"C:\Users\User\source\repos\ProjectClient-Library\ProjectClient\Resources\Screenshot 2024-03-09 204952Red.png";
            WishlistButton.Image = System.Drawing.Bitmap.FromFile(RedHeartPhoto);
        }

        private void RatingBar_Scroll(object sender, EventArgs e)
        {
            label1.Text = RatingBar.Value.ToString();
        }

        private void SendRateButton_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("RateForBook:" + BookName + ',' + RatingBar.Value.ToString());
        }

        private void OrderscreenForm_Load(object sender, EventArgs e)
        {

        }
    }
}

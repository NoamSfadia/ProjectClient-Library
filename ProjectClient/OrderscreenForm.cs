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
        public  string Library;
        public List<string> Libraries;
        
        
        public OrderscreenForm(string image, string Summary,string username,string book)
        {
            InitializeComponent();
            NetHandler.InitializeOrderFormInstance(this);

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
            NetHandler.SendMessage("WhatTypeOrder");
            
            NetHandler.SendMessage("DemandOrder" + BookName);
        }
        /// <summary>
        /// Opens The Librarian options.
        /// </summary>
        private void showLibrarianOptions()
        {
            BookQuantityCounter.Visible = true;
            SendQuantity.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }

        private void SendQuantity_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("Quantity:" + BookName + '/' + BookQuantityCounter.Value + ',' + Library);
            
        }

        private void LibrariesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newLibrary = LibrariesComboBox.Text;
            foreach (string library in Libraries)
            {
                string[] libraryAfterSplit = library.Split('/');
                if (libraryAfterSplit[0].StartsWith(newLibrary))
                {
                    if (libraryAfterSplit[1].Equals("Blue"))
                    {
                        LibrariesComboBox.ForeColor = Color.Blue;
                    }
                    if (libraryAfterSplit[1].Equals("Yellow"))
                    {
                        LibrariesComboBox.ForeColor = Color.Gold;
                    }
                    if (libraryAfterSplit[1].Equals("Red"))
                    {
                        LibrariesComboBox.ForeColor = Color.Red;
                    }
                    if (libraryAfterSplit[1].Equals("Green"))
                    {
                        LibrariesComboBox.ForeColor= Color.DarkGreen;
                    }


                }
            }
        }

        private void ShowLibrarianOptionButton_Click(object sender, EventArgs e)
        {
            showLibrarianOptions();
            NetHandler.SendMessage("WhatLibraryOrderCurrentQuantity" + BookName);
        }
        public void ShowLibrarianOptionsButton() 
        {
            ShowLibrarianOptionButton.Visible = true;
        }
        public void UpdateCurrentLabel(string label)
        {
            label5.Text += label;
        }
    }
}

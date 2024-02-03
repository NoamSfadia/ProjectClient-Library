using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClient
{
    public partial class BookPreviewControl : UserControl
    {
        public BookPreviewControl()
        {
            InitializeComponent();
        }
        public void setBookLabels(string name, string author, string genre, string rate)
        {
            BookNameLabel.Text = name;
            AuthorLabel.Text = author;
            BookGenreLabel.Text = genre;
            BookRatingLabel.Text = rate;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

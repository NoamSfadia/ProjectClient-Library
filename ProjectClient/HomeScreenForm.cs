using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectClient
{
    public partial class HomeScreenForm : Form
    {
        public static string username;
        private List<string> Libraries;
        public HomeScreenForm()
        {
            InitializeComponent();
            NetHandler.InitializeHomeScreenFormInstance(this);
        }

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongDateString();
            NetHandler.SendMessage("GetUserName");
            BookPreviewControl[] bookPreviewControls = new BookPreviewControl[6];
            NetHandler.SendMessage("GetBooks:" + "Harry Poter 1");
        }
        public void setUsername(string name)
        {
            username = name;
            if (username != null)
            {
                UsernameGreetLbl.Text += username + "!";
            }
        }
        public void InsertLibraries(string listOfLibraries)
        {
            string[] strings = listOfLibraries.Split(',');
            Libraries = new List<string>(strings);
            foreach (string str in Libraries)
            {
                LibrariesComboBox.Items.Add(str);
            }
        }

        private void UsernameGreetLbl_Click(object sender, EventArgs e)
        {

        }
        public void setBook(string Name, string Author, string Genre, string Rate)
        {
            bookPreviewControl1.setBookLabels(Name, Author, Genre, Rate);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(username);
            settings.Show();
        }
    }

}

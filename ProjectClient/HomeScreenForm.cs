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
        private bool GenresIn = false;
        BookPreviewControl[] bookPreviewControls;
        List<BookDetails> AllBooks = new List<BookDetails>();

        public int pageNumber = 0;
        public int pageMax;

        public HomeScreenForm()
        {
            InitializeComponent();
            NetHandler.InitializeHomeScreenFormInstance(this);
        }

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            DateLbl.Text = DateTime.Now.ToLongDateString();
            NetHandler.SendMessage("GetUserName");
            bookPreviewControls = new BookPreviewControl[6];
            for(int i = 0; i < bookPreviewControls.Length; i++)
            {
                bookPreviewControls[i] = new BookPreviewControl(username);
                bookPreviewControls[i].Location = new Point(20 + 124 * i, 63);
                Controls.Add(bookPreviewControls[i]);
                bookPreviewControls[i].Visible = true;
                bookPreviewControls[i].OnOrderButtonClick += new System.EventHandler<string>(OrderButtonClick);
            } 
            PageNumberLabel.Text = pageNumber.ToString();
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
        }
        public void InsertGenres(string listOfGenres)
        {
            string[] strings = listOfGenres.Split(',');
            if(!GenresIn)
            {
                foreach (string s in strings)
                {
                    FilterGenreComboBox.Items.Add(s);
                }
                GenresIn = true;
            }
        }
        private void OrderButtonClick(object sender ,string Summary)
        {
            if(sender != null)
            {
                MessageBox.Show(Summary);
            }
        }
        public void setBook(string Name, string Author, string Genre, string Rate , string Summary, string Image)
        {
            int i = 0;
            bool flag = false;
            while (i<bookPreviewControls.Length && !flag)
            {
                if (!bookPreviewControls[i].isUsed)
                {
                    bookPreviewControls[i].setBookLabels(Name, Author, Genre, Rate, Summary, Image);
                    bookPreviewControls[i].isUsed = true;
                    flag = true;
                }
                i++;
            }
           if(!CheckBookInList(Name))
           {
                BookDetails details = new BookDetails(Name, Author, Genre, Rate, Summary,Image);
                AllBooks.Add(details);
           }
        }
        public void ResetBooks()
        {
            for (int i = bookPreviewControls.Length -1 ; i >= 0; i--)
            {
                
                bookPreviewControls[i].setBookLabels("Name", "Author", "Genre", "0.0", "No summary available", null);
                //set defualt values
                bookPreviewControls[i].isUsed=false;
            }
            
        }

        private void SearchByFilterButton_Click(object sender, EventArgs e)
        {
            if(FilterGenreComboBox.Text != "")
            {
                ResetBooks();
                NetHandler.SendMessage("Filter:" + FilterGenreComboBox.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(username, Libraries);
            settings.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            NetHandler.SendMessage("GetBooks:");
        }
        private bool CheckBookInList(string bookName)
        {
            for(int i = 0; i < AllBooks.Count; i++)
            {
                if (AllBooks[i].BookName == bookName)
                {
                    return true;
                }
            }
            return false;
        }


        private void NextButtonPage_Click(object sender, EventArgs e)
        {
            ResetBooks();
            if (pageNumber <= pageMax - 1)
            {
                pageNumber++;
                PageNumberLabel.Text = pageNumber.ToString();

                for (int i = pageNumber * 6; i < pageNumber * 6 + 6; i++)
                {
                    if (i < AllBooks.Count)
                    {
                        BookDetails book = AllBooks[i];
                        setBook(book.BookName, book.Author, book.Genre, book.Rate, book.Summary, book.Image);
                    }
                    
                }
            }
        }

        private void PreviousButtonPage_Click(object sender, EventArgs e)
        {
            ResetBooks();
            if (pageNumber > 0)
            {
                pageNumber--;
                PageNumberLabel.Text = pageNumber.ToString();

                for (int i = pageNumber * 6; i < pageNumber * 6 + 6; i++)
                {
                    BookDetails book = AllBooks[i];
                    setBook(book.BookName, book.Author, book.Genre, book.Rate, book.Summary, book.Image);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonForSeacrh_Click(object sender, EventArgs e)
        {
            string SearchQuery = SearchBar.Text;
            NetHandler.SendMessage("SearchQuery:" + SearchQuery);
        }

        private void HomeScreenForm_Leave(object sender, EventArgs e)
        {
            NetHandler.Disconnect();
        }
    }

}

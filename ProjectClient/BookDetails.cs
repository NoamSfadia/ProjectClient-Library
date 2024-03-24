using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClient
{
    internal class BookDetails
    {
        public string BookName;
        public string Author;
        public string Genre;
        public string Rate;
        public string Summary;
        public string Image;
        public BookDetails(string bookName, string author, string genre, string rate, string summary, string image)
        {
            BookName = bookName;
            Author = author;
            Genre = genre;
            Rate = rate;
            Summary = summary;
            Image = image;
        }
    }
}

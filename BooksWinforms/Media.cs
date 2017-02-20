using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksWinforms
{
    public enum MediaType { Book, Journal, Newspaper }

    [Serializable]
    public abstract class Media
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Publisher { get; set; }

        public MediaType mediaType { get; set; }
    }

    [Serializable]
    public class Book : Media
    {
        [XmlArrayItem("Author")]
        public List<string> Authors { get; }

        public Book()
        {
            Authors = new List<string>();
            mediaType = MediaType.Book;
        }
    }

    public abstract class Periodical : Media
    {
        public List<Article> Articles { get; protected set; } = new List<Article>();
    }

    public class Journal : Periodical
    {
        public Journal()
        {
            mediaType = MediaType.Journal;
        }
    }

    public class Newspaper : Periodical
    {
        public Newspaper()
        {
            mediaType = MediaType.Newspaper;
        }
    }
}

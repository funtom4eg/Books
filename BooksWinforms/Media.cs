using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWinforms
{
    public enum MediaType { Book, Journal }

    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public MediaType mediaType { get; set; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class BooksCollection
    {
        public List<Book> booksCollection;
        public static UI ui;

        public BooksCollection()
        {
            booksCollection = new List<Book>();
            ui = new UI();
        }

        public void Add(Book item)
        {
            (this.booksCollection).Add(item);
        }

        public void ShowCollection()
        {
            ui.ShowCollection(this.booksCollection);
        }
    }
}

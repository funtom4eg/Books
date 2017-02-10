using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book { Author = "Author1", Title = "Title1" };
            Book book2 = new Book { Author = "Author2", Title = "Title2" };

            BooksCollection collection = new BooksCollection();

            collection.Add(book1);
            collection.Add(book2);

            collection.ShowCollection();
        }
    }
}

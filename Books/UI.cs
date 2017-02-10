using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class UI
    {
        public void ShowCollection(List<Book> booksCollection)
        {
            int index = 1;

            foreach(Book book in booksCollection)
            {
                Console.WriteLine((index++) + ". " + book.Author + " - " + book.Title);
            }

            Console.ReadKey(true);
        }
    }
}

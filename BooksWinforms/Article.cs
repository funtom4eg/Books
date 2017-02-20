using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWinforms
{
    [Serializable]
    public class Article
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public List<string> Authors { get; set; }
    }
}

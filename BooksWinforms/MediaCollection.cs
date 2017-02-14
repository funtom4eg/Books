using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWinforms
{

    public class MediaCollection
    {
        public List<Media> collection;

        public MediaCollection()
        {
            collection = new List<Media>();

        }

        public void Add(Media item)
        {
            (this.collection).Add(item);
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWinforms
{
    public class MediaCollection : IEnumerable
    {
        private static int _uniqueId = 0;

        public List<Media> collection { get; } = new List<Media>();

        public Media this[int index]
        {
            get
            {
                return collection[index];
            }
        }

        public void Add(Media item)
        {
            if (!collection.Contains(item))
            {
                collection.Add(item);
                item.Id = _uniqueId++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return collection.GetEnumerator();
        }
    }
}

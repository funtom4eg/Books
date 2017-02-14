using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksWinforms
{
    public partial class MainForm : Form
    {
        private List<Media> _collection = new List<Media>();
        private PropertyInfo[] _properties = typeof(Media).GetProperties();
        public MainForm()
        {
            InitializeComponent();

            FillCollection();

            FillCheckedListBox();

            CreateListView();

            FillListView();
        }

        private void FillCollection()
        {
            Media m1 = new Media { Id = 0, Author = "Author 1", mediaType = MediaType.Book, Title = "Title 1" };
            Media m2 = new Media { Id = 1, Author = "Author 2", mediaType = MediaType.Book, Title = "Title 2" };
            Media m3 = new Media { Id = 2, Author = "Author 3", mediaType = MediaType.Journal, Title = "Title 3" };
            Media m4 = new Media { Id = 3, mediaType = MediaType.Book, Title = "Title 4" };
            Media m5 = new Media { Id = 4, Author = "Author 5", mediaType = MediaType.Book, Title = "Title 5" };
            Media m6 = new Media { Id = 5, Author = "Author 6", mediaType = MediaType.Journal, Title = "Title 6" };
            Media m7 = new Media { Id = 6, Author = "Author 7", mediaType = MediaType.Book, Title = "Title 7" };

            _collection.Add(m1);
            _collection.Add(m2);
            _collection.Add(m3);
            _collection.Add(m4);
            _collection.Add(m5);
            _collection.Add(m6);
            _collection.Add(m7);
            _collection.Add(m1);
        }

        private void FillCheckedListBox()
        {
            this.mediaCheckdListBox.Items.AddRange(Enum.GetNames(typeof(MediaType)));
            for (int i = 0; i < mediaCheckdListBox.Items.Count; i++)
            {
                mediaCheckdListBox.SetItemChecked(i, true);
            }
        }

        private void CreateListView()
        {
            foreach (var property in _properties)
            {
                mediaListView.Columns.Add(property.Name);
            }
        }

        private void FillListView()
        {
            mediaListView.Items.Clear();
            foreach (var item in _collection)
            {
                if (mediaCheckdListBox.CheckedIndices.Contains((int)item.mediaType))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Id.ToString();
                    mediaListView.Items.Add(listViewItem);

                    for (int i = 1; i < _properties.Length; i++)
                    {
                        ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem();
                        listViewSubItem.Text = _properties[i].GetValue(item)?.ToString();
                        listViewItem.SubItems.Add(listViewSubItem);
                    }
                }
            }
        }

        private void mediaCheckdListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListView();
        }

        //??
        private void mediaCheckdListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FillListView();
        }
    }
}

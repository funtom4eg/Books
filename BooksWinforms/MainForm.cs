using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BooksWinforms
{
    [Serializable]
    public partial class MainForm : Form
    {
        public MediaCollection _collection = new MediaCollection();

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
            Media m1 = new Book { Authors = { "Author 1" }, Title = "Title 1" };
            Media m2 = new Book { Authors = { "Author 2", "One more Author" }, Title = "Title 2" };
            Media m3 = new Journal { Title = "Title 3" };
            Media m4 = new Book { Title = "Title 4" };
            Media m5 = new Book { Authors = { "Author 5" }, Title = "Title 5" };
            Media m6 = new Newspaper { Title = "Title 6" };
            Media m7 = new Newspaper { Title = "Title 7", Publisher = "Publisher 6" };

            Article art = new Article();
            art.Authors = new List<string> { "autor 12", "author 54" };
            art.Title = "New Title";
            art.Body = "Article body";

            (m7 as Newspaper).Articles.Add(art);

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
            foreach (Media item in _collection)
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
            mediaListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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

        private void SerializeBooksXML_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));

            FileStream fs = new FileStream("books.xml", FileMode.Create);

            var listOfBooks = _collection.collection.Where(x => x is Book).Select(x => x as Book).ToList();

            xmlSerializer.Serialize(fs, listOfBooks);

            fs.Close();
        }

        private void SavePeriodicalsTxt_Click(object sender, EventArgs e)
        {
            TextWriter writer = File.CreateText("periodicals.txt");

            foreach (Media media in _collection)
            {
                if (media is Periodical)
                {
                    writer.WriteLine($"Id: {media.Id}");
                    writer.WriteLine($"Title: {media.Title}");
                    writer.WriteLine($"Publisher: {media.Publisher}");
                    writer.WriteLine($"Media Type: {media.mediaType}");

                    foreach (var article in (media as Periodical).Articles)
                    {
                        writer.WriteLine($"Title: {article.Title}");
                        writer.WriteLine($"Authors: {string.Join(", ", article.Authors)}");
                        writer.WriteLine("Body:");
                        writer.WriteLine(article.Body);
                    }

                    writer.WriteLine(new string('-', 79));
                }
            }
            writer.Close();
        }

        private void AddNewItemButton_Click(object sender, EventArgs e)
        {
            AddNewItemForm addNewItemForm = new AddNewItemForm();
            addNewItemForm.Owner = this;
            addNewItemForm.ShowDialog();
            FillListView();
        }
    }
}

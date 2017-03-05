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
    public partial class AddNewItemForm : Form
    {
        public AddNewItemForm()
        {
            InitializeComponent();

            comboBoxSelectMedia.Items.AddRange(Enum.GetNames(typeof(MediaType)));

        }

        private void comboBoxSelectMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectMedia.SelectedIndex == (int)MediaType.Book)
            {
                dataGridView1.Rows.Clear();
                var properties = typeof(Book).GetProperties();

                foreach (var property in properties)
                {
                    dataGridView1.Rows.Add(property.Name);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectMedia.SelectedIndex == (int)MediaType.Book)
            {
                Book newBook = new Book();
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var pInfo = typeof(Book).GetProperty(dataGridView1.Rows[i].Cells[0].Value.ToString());

                    try
                    {
                        pInfo.SetValue(newBook, dataGridView1.Rows[i].Cells[1].Value);
                    }
                    catch
                    {

                    }
                }
                (this.Owner as MainForm)._collection.Add(newBook);
                this.Close();
            }

        }
    }
}

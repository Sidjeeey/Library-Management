using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class BorrowedRecords : Form
    {
        public BorrowedRecords()
        {
            InitializeComponent();
        }

        private void BorrowedRecords_Load(object sender, EventArgs e)
        {
            try
            {
                //using (var dbContext = new LibraryEntities())
                //{
                //    List<BorrowBook> borrowBooks = dbContext.BorrowBooks.ToList();
                //    dataGridView1.DataSource = borrowBooks;
                //}
                using (var dbContext = new LibraryEntities())
                {
                    List<BorrowBook> borrowBooks = dbContext.BorrowBooks
                        .Where(b => b.DateReturned.Length == 0)
                        .ToList();

                    dataGridView1.DataSource = borrowBooks;
                }

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns[0].Visible = false; 
                }

                var columnSettings = new Dictionary<string, Tuple<int, DataGridViewAutoSizeColumnMode>>
                {
                    { "StudentNumber", Tuple.Create(150, DataGridViewAutoSizeColumnMode.None) },
                    { "FirstName", Tuple.Create(150, DataGridViewAutoSizeColumnMode.None) },
                    { "LastName", Tuple.Create(120, DataGridViewAutoSizeColumnMode.None) },
                    { "Course", Tuple.Create(60, DataGridViewAutoSizeColumnMode.None) },
                    { "BookName", Tuple.Create(130, DataGridViewAutoSizeColumnMode.None) },
                    { "DateIssue", Tuple.Create(145, DataGridViewAutoSizeColumnMode.None) },
                    { "DateReturned", Tuple.Create(136, DataGridViewAutoSizeColumnMode.None) }
                };

                foreach (var setting in columnSettings)
                {
                    if (dataGridView1.Columns.Contains(setting.Key))
                    {
                        var column = dataGridView1.Columns[setting.Key];
                        column.Width = setting.Value.Item1;
                        column.AutoSizeMode = setting.Value.Item2;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}"); 
            }

        }
    }
}

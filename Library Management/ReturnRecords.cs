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
    public partial class ReturnRecords : Form
    {
        public ReturnRecords()
        {
            InitializeComponent();
        }

        private void ReturnRecords_Load(object sender, EventArgs e)
        {
            //using (var dbContext = new LibraryEntities())
            //{
            //    List<BorrowBook> returnRecords = dbContext.BorrowBooks
            //        .Where(book => book.DateReturned != null)
            //        .ToList();

            //    dataGridView1.DataSource = returnRecords;
            //}
            using (var dbContext = new LibraryEntities())
            {
                var allRecords = dbContext.BorrowBooks.ToList();  // Fetch all records

                var returnRecords = allRecords
                    .Where(book => book.DateReturned != null &&
                        DateTime.TryParse(book.DateReturned, out _))
                    .ToList();

                dataGridView1.DataSource = returnRecords;
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
    }
}

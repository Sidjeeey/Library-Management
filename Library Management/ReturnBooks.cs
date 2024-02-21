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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {

        }

        private void Searchstudent_Click(object sender, EventArgs e)
        {
            string searchQuery = SearchStudentTextBox.Text.Trim();

            if (searchQuery.Length < 4)
            {
                MessageBox.Show("Invalid Student Number");
                return;
            }

            using (var dbContext = new LibraryEntities())
            {
                
                List<BorrowBook> searchResults = dbContext.BorrowBooks
                    .Where(book => book.StudentNumber.Contains(searchQuery)) //&& book.DateReturned == null)
                    .ToList();

                if (searchResults.Count > 0)
                {
                    dataGridView1.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("No records found for the specified student number or all books have been returned.");
                }
            }

        }

        private void Returnbbt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int borrowBookId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Borrow_Id"].Value);

                using (var dbContext = new LibraryEntities())
                {
                    BorrowBook selectedBorrowBook = dbContext.BorrowBooks.Find(borrowBookId);

                    if (selectedBorrowBook != null)
                    {
                        selectedBorrowBook.DateReturned = DateTime.Now.ToString();
                        dbContext.SaveChanges();
                        dataGridView1.ClearSelection();
                        SearchStudentTextBox.Clear();

                        MessageBox.Show("Book returned successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record from the DataGridView.");
            }
        }
    }
}

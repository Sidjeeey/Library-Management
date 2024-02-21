using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class BorrowBooks : Form
    {
        public BorrowBooks()
        {
            InitializeComponent();
        }

        /*
         * Begin
         *      Get quantity of selected books
         *          If quantity is equal to zero
         *          Else
         *              Book is out of stock
         *              return
         * End
         * */

        private void BorrowBooks_Load(object sender, EventArgs e)
        {
            using (var dbContext = new LibraryEntities())
            {
                List<string> Bookname = dbContext.Books.Select(book => book.BookName).Distinct().ToList();
                BookNameComboBox.DataSource = Bookname;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var dbContext = new LibraryEntities())
            {
                if (BookNameComboBox.SelectedItem != null)
                {
                    string BookLabel = BookNameComboBox.SelectedItem.ToString().Trim(); 
                    int bookLabelValue;

                    if (int.TryParse(BookLabel, out bookLabelValue))
                    {
                        List<Book> books = dbContext.Books.Where(book => book.BookQuantity == bookLabelValue).ToList();

                        BookNameComboBox.Items.Clear(); 

                        foreach (var book in books)
                        {
                            BookNameComboBox.Items.Add(book.BookName);
                        }
                    }
                    //else 
                    //{
                    //    MessageBox.Show($"Invalid BookLabel: '{BookLabel}'. Please provide a valid integer value.");
                    //}
                }

                //BookNameComboBox.Visible = true;
            }
        }

        private void SearchStudentbutton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string searchQuery = SearchStudentTextBox.Text.Trim();

            if (searchQuery.Length < 4)
            {
                MessageBox.Show("Invalid Student Number");
                return;
            }

            using (var dbContext = new LibraryEntities())
            {
                List<Student> searchResults = dbContext.Students
                    .Where(student => student.StudentNumber.Contains(searchQuery))
                    .ToList();

                if (searchResults.Count > 0)
                {
                    textBox1.Text = searchResults[0].StudentNumber;
                    textBox2.Text = searchResults[0].FirstName;
                    textBox3.Text = searchResults[0].LastName;
                    textBox5.Text = searchResults[0].CourseId;
                }
                else
                {
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    textBox5.Text = string.Empty;
                    MessageBox.Show("No student found.");
                }
            }
        }

        private void Issuebutton_Click(object sender, EventArgs e)
        {
            IssuedBook();
            
        }
        private void IssuedBook()
        {
            try
            {
                if (BookNameComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a book before issuing.");
                    return;
                }

                string selectedBookName = BookNameComboBox.SelectedItem.ToString();

                // Check if the book is out of stock
                using (var dbContext = new LibraryEntities())
                {
                    Book selectedBook = dbContext.Books.FirstOrDefault(book => book.BookName == selectedBookName);

                    if (selectedBook != null && selectedBook.BookQuantity <= 0)
                    {
                        MessageBox.Show("This book is out of stock.");
                        return;
                    }
                }

                // Update book quantity
                UpdateBookQuantity(selectedBookName, -1);

                // Issue the book
                using (var dbContext = new LibraryEntities())
                {
                    BorrowBook issuedBook = new BorrowBook
                    {
                        StudentNumber = textBox1.Text,
                        FirstName = textBox2.Text,
                        LastName = textBox3.Text,
                        Course = textBox5.Text,
                        BookName = BookNameComboBox.Text,
                        DateIssue = dateTimePicker1.Value.ToString(),
                        DateReturned = ""
                    };

                    dbContext.BorrowBooks.Add(issuedBook);
                    dbContext.SaveChanges();

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox5.Clear();
                    SearchStudentTextBox.Clear();
                    MessageBox.Show("Book issued successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void UpdateBookQuantity(string bookName, int quantityChange)
        {
            try
            {
                using (var dbContext = new LibraryEntities())
                {
                    Book selectedBook = dbContext.Books.FirstOrDefault(book => book.BookName == bookName);

                    if (selectedBook != null)
                    {
                        selectedBook.BookQuantity += quantityChange;

                        if (selectedBook.BookQuantity < 0)
                        {
                            MessageBox.Show("Invalid operation. Book quantity cannot be negative.");
                            return;
                        }
                        else if (selectedBook.BookQuantity == 0)
                        {
                            MessageBox.Show("This book is now out of stock.");
                        }

                        dbContext.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
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
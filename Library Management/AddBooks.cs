using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;

namespace Library_Management
{
    public partial class AddBooks : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Library;Integrated Security=True");
        public AddBooks()
        {
            InitializeComponent();
        }

        private void InsertBooks()
        {
            try
            {
                using (var context = new LibraryEntities())
                {
                    // Check if the book already exists in the database
                    var existingBook = context.Books.FirstOrDefault(book => book.BookName == textBox1.Text);

                    if (existingBook != null)
                    {
                        // If the book exists, update its quantity
                        existingBook.BookQuantity += int.Parse(textBox5.Text);
                    }
                    else
                    {
                        // If the book doesn't exist, create a new entry
                        var newBook = new Book
                        {
                            BookName = textBox1.Text,
                            Author = textBox2.Text,
                            Genre = textBox3.Text,
                            DateAdded = dateTimePicker1.Text,
                            BookQuantity = int.Parse(textBox5.Text)
                        };

                        context.Books.Add(newBook);
                    }

                    context.SaveChanges();
                }

                MessageBox.Show("Book(s) Added Successfully");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsertBooks();
        }
    }
} 

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InsertBooks()
        {
            try
            {
                var books = new Book
                {
                    BookName = textBox1.Text,
                    Author = textBox2.Text,
                    Genre = textBox3.Text,
                    DateAdded = dateTimePicker1.Text,
                    BookQuantity = int.Parse(textBox5.Text)
                };
                using (var context = new LibraryEntities())
                {
                    context.Books.Add(books);
                    context.SaveChanges();
                            
                }
                MessageBox.Show("Book Added Succesfully");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            InsertBooks();
        }
    }
} 

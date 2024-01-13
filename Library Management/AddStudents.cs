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
    public partial class AddStudents : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Library;Integrated Security=True");
        public AddStudents()
        {
            InitializeComponent();
            
        }

        private void AddNewStudent()
        {
            try
            {
                var students = new Student
                {
                    StudentNumber = textBox1.Text,
                    FirstName = textBox2.Text,
                    LastName = textBox3.Text,
                    Date_Added = dateTimePicker1.Text,
                    CourseId = textBox5.Text,
                    Email = textBox6.Text
                };
                using (var context = new LibraryEntities())
                {
                    context.Students.Add(students);
                    context.SaveChanges();
                }
                MessageBox.Show("Saved successfully.");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("SP_addStudents", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@StudentNumber", SqlDbType.NVarChar).Value = textBox1.Text;
            //cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = textBox2.Text;
            //cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = textBox3.Text;
            //cmd.Parameters.Add("@DateAdded", SqlDbType.NVarChar).Value = dateTimePicker1.Value;
            //cmd.Parameters.Add("@CourseID", SqlDbType.NVarChar).Value = textBox5.Text;
            //cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = textBox6.Text;
            //cmd.ExecuteNonQuery();
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            //textBox5.Clear();
            //textBox6.Clear();
            AddNewStudent();
            
        }
    }

}

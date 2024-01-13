using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Library_Management
{
    public partial class ViewStudents : Form
    {
        
        
        public ViewStudents()
        {
            InitializeComponent();
        }



        private void ViewStudents_Load(object sender, EventArgs e)
        {
            using (var dbContext = new LibraryEntities())
            {
                    
                List<Student> students = dbContext.Students.ToList();
                dataGridView1.DataSource = students;  
            }
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false; // Hide the first column
            }
            var columnSettings = new Dictionary<string, Tuple<int, DataGridViewAutoSizeColumnMode>>
            {
                { "StudentNumber", Tuple.Create(150, DataGridViewAutoSizeColumnMode.None) },
                { "FirstName", Tuple.Create(150, DataGridViewAutoSizeColumnMode.None) },
                { "LastName", Tuple.Create(120, DataGridViewAutoSizeColumnMode.None) },
                { "Date_Added", Tuple.Create(153, DataGridViewAutoSizeColumnMode.None) },
                { "CourseId", Tuple.Create(60, DataGridViewAutoSizeColumnMode.None) },
                { "Email", Tuple.Create(185, DataGridViewAutoSizeColumnMode.None) }
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

        private void SearchStudent_Click(object sender, EventArgs e)
        {

            var filter = textBox1.Text;
            SearchStudentByStudentNumber(filter);
        }

        private void SearchStudentByStudentNumber(string studentNumber)
        {
            var students = new LibraryEntities().Students
                .Where(s => s.StudentNumber.Contains(studentNumber)).ToList();
            dataGridView1.DataSource = students;
        }
    }
}
        

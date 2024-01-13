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
    public partial class ViewBooks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Library;Integrated Security=True");
        public ViewBooks()
        {

            InitializeComponent();
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ViewBooks", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = "";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            con.Close();

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false; // Hide the first column
            }
            var columnSettings = new Dictionary<string, Tuple<int, DataGridViewAutoSizeColumnMode>>
            {
                { "BookName", Tuple.Create(200, DataGridViewAutoSizeColumnMode.None) },
                { "Author", Tuple.Create(169, DataGridViewAutoSizeColumnMode.None) },
                { "Genre", Tuple.Create(200, DataGridViewAutoSizeColumnMode.None) },
                { "DateAdded", Tuple.Create(160, DataGridViewAutoSizeColumnMode.None) },
                { "BookQuantity", Tuple.Create(90, DataGridViewAutoSizeColumnMode.None) }
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
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("ViewBooks", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = Searchbutton.Text;
            //    SqlDataAdapter Da = new SqlDataAdapter(cmd);
            //    DataTable Dt = new DataTable();
            //    Da.Fill(Dt);
            //    dataGridView1.DataSource = Dt;
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"{ex.Message}");
            //}
            var filter = textBox1.Text;
            SearchBookByName(filter);
        }

        private void SearchBookByName(string bookName)
        {
            var books = new LibraryEntities().Books
                .Where(b => b.BookName.Contains(bookName)).ToList();
            dataGridView1.DataSource = books;

        }

    }
}

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

namespace Library_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new  SqlConnection (@"Data Source=.\sqlexpress;Initial Catalog=Library;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button_login;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username, password;

            username = text_username.Text;
            password = text_password.Text;

            

            try
            {
                String query = "SELECT * FROM Login_new WHERE username = @username AND password = @password";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@username", text_username.Text);
                sda.SelectCommand.Parameters.AddWithValue("@password", text_password.Text);

                //String querry = "Select * From Login_new Where username = '"+text_username.Text+"' AND password '"+text_password.Text+"'";
                //SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = text_username.Text;
                    password = text_password.Text;

                    // page that load next
                    Menuform form2 = new Menuform();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_username.Clear();
                    text_password.Clear();

                    //to focus username
                    text_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Failed to Log in");
            }
            finally
            {
                con.Close();
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_username.Clear();
            text_password.Clear();

            text_username.Focus();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {
            text_password.PasswordChar = '*';

        }
    }
}

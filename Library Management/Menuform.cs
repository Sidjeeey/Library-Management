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
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBooks Ab = new AddBooks();
            Ab.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewBooks Vb = new ViewBooks();
            Vb.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStudents As = new AddStudents();
            As.ShowDialog();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewStudents Vs = new ViewStudents();
            Vs.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BorrowBooks Bb = new BorrowBooks();
            Bb.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReturnBooks Rb = new ReturnBooks();
            Rb.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BorrowedRecords Br = new BorrowedRecords();
            Br.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReturnRecords Rr = new ReturnRecords();
            Rr.ShowDialog();
        }
    }
}

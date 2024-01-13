using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //StudentSeeder.AddStudents();
            //BookGenreSeeder.AddGenres();
            //Application.enablevisualstyles();
            //Application.setcompatibletextrenderingdefault(false);
            Application.Run(new Form1());
            //Application.Run(new Menuform());
        }
    }
}

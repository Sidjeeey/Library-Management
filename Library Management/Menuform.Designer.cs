namespace Library_Management
{
    partial class Menuform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddBooks = new System.Windows.Forms.Button();
            this.ViewBooks = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.ViewStudents = new System.Windows.Forms.Button();
            this.BorrowBooks = new System.Windows.Forms.Button();
            this.ReturnBooks = new System.Windows.Forms.Button();
            this.BorrowedRecords = new System.Windows.Forms.Button();
            this.ReturnRecords = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBooks
            // 
            this.AddBooks.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBooks.Location = new System.Drawing.Point(588, 196);
            this.AddBooks.Name = "AddBooks";
            this.AddBooks.Size = new System.Drawing.Size(129, 43);
            this.AddBooks.TabIndex = 1;
            this.AddBooks.Text = "Add Books";
            this.AddBooks.UseVisualStyleBackColor = true;
            this.AddBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewBooks
            // 
            this.ViewBooks.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBooks.Location = new System.Drawing.Point(588, 256);
            this.ViewBooks.Name = "ViewBooks";
            this.ViewBooks.Size = new System.Drawing.Size(129, 43);
            this.ViewBooks.TabIndex = 2;
            this.ViewBooks.Text = "View Books";
            this.ViewBooks.UseVisualStyleBackColor = true;
            this.ViewBooks.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent.Location = new System.Drawing.Point(588, 319);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(129, 43);
            this.AddStudent.TabIndex = 3;
            this.AddStudent.Text = "Add Students";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewStudents
            // 
            this.ViewStudents.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudents.Location = new System.Drawing.Point(588, 382);
            this.ViewStudents.Name = "ViewStudents";
            this.ViewStudents.Size = new System.Drawing.Size(129, 43);
            this.ViewStudents.TabIndex = 4;
            this.ViewStudents.Text = "View Students";
            this.ViewStudents.UseVisualStyleBackColor = true;
            this.ViewStudents.Click += new System.EventHandler(this.button4_Click);
            // 
            // BorrowBooks
            // 
            this.BorrowBooks.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBooks.Location = new System.Drawing.Point(588, 445);
            this.BorrowBooks.Name = "BorrowBooks";
            this.BorrowBooks.Size = new System.Drawing.Size(129, 43);
            this.BorrowBooks.TabIndex = 5;
            this.BorrowBooks.Text = "Borrow Books";
            this.BorrowBooks.UseVisualStyleBackColor = true;
            this.BorrowBooks.Click += new System.EventHandler(this.button5_Click);
            // 
            // ReturnBooks
            // 
            this.ReturnBooks.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBooks.Location = new System.Drawing.Point(588, 504);
            this.ReturnBooks.Name = "ReturnBooks";
            this.ReturnBooks.Size = new System.Drawing.Size(129, 43);
            this.ReturnBooks.TabIndex = 6;
            this.ReturnBooks.Text = "Return Books";
            this.ReturnBooks.UseVisualStyleBackColor = true;
            this.ReturnBooks.Click += new System.EventHandler(this.button6_Click);
            // 
            // BorrowedRecords
            // 
            this.BorrowedRecords.Font = new System.Drawing.Font("Myriad Pro Cond", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowedRecords.Location = new System.Drawing.Point(588, 564);
            this.BorrowedRecords.Name = "BorrowedRecords";
            this.BorrowedRecords.Size = new System.Drawing.Size(129, 43);
            this.BorrowedRecords.TabIndex = 7;
            this.BorrowedRecords.Text = "Borrowed Records";
            this.BorrowedRecords.UseVisualStyleBackColor = true;
            this.BorrowedRecords.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ReturnRecords
            // 
            this.ReturnRecords.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnRecords.Location = new System.Drawing.Point(588, 625);
            this.ReturnRecords.Name = "ReturnRecords";
            this.ReturnRecords.Size = new System.Drawing.Size(129, 43);
            this.ReturnRecords.TabIndex = 8;
            this.ReturnRecords.Text = "Return Records";
            this.ReturnRecords.UseVisualStyleBackColor = true;
            this.ReturnRecords.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 138);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1006, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // Menuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management.Properties.Resources.HD_wallpaper_books_on_bookshelf;
            this.ClientSize = new System.Drawing.Size(1330, 807);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReturnRecords);
            this.Controls.Add(this.BorrowedRecords);
            this.Controls.Add(this.ReturnBooks);
            this.Controls.Add(this.BorrowBooks);
            this.Controls.Add(this.ViewStudents);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.ViewBooks);
            this.Controls.Add(this.AddBooks);
            this.Name = "Menuform";
            this.Text = "Menuform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddBooks;
        private System.Windows.Forms.Button ViewBooks;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button ViewStudents;
        private System.Windows.Forms.Button BorrowBooks;
        private System.Windows.Forms.Button ReturnBooks;
        private System.Windows.Forms.Button BorrowedRecords;
        private System.Windows.Forms.Button ReturnRecords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
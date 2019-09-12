using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SA47Team07AProject
{
    public partial class BookIDForm : SA47Team07AProject.SubMainForm
    {
        LibraryEntities context = new LibraryEntities();

        public BookIDForm()
        {
            InitializeComponent();

            var q = from x in context.Books select new { x.BookID, x.BookName };

            dataGridView1.DataSource = q.ToList();
        }

        private void SubmitBorrow_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentRow.Index;

            AddBorrowBooks.BookID = dataGridView1.Rows[index].Cells[0].Value.ToString();

            AddBorrowBooks.BookName = dataGridView1.Rows[index].Cells[1].Value.ToString();

            this.Close();
        }

        private void CancelBorrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

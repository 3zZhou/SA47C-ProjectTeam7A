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
    public partial class QuerySearch : SA47Team07AProject.SubMainForm
    {
        public QuerySearch()
        {
            InitializeComponent();
            BookSearchTextBox.Visible = false;
            BookTypeBox.Visible = false;
        }

        public static string BkName = "";
        public static string BkAuthor = "";
        public static string BkType = "";
        public static string BkGenre = "";
        public static int BkTtlStock;
        public static int BkBorrowed;
        public static string BkLocation;
        public static int BkID;

        private void OKButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {

                BkName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            BkAuthor = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            BkType = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            BkGenre = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            BkLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            BkTtlStock = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            BkBorrowed = Convert.ToInt32(dataGridView1.CurrentRow.Cells[10].Value.ToString());
            BkID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            this.DialogResult = DialogResult.OK;
        }
            else
            {
                ErrorMsgForm.ErrorMsg = "Please Select Record First!!!";
                ErrorMsgForm f = new ErrorMsgForm();

                f.ShowDialog();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            try
            {
                if (SelectionBox.Text == "Book Name") //Book Name Search
                {
                    string A = BookSearchTextBox.Text;
                    dataGridView1.DataSource = context.Books.Where(x => x.BookName.Contains(A)).ToList();
                }
                else if (SelectionBox.Text == "Book ID") //Book ID Search
                {
                    int A = Int32.Parse(BookSearchTextBox.Text);
                    dataGridView1.DataSource = context.Books.Where(x => x.BookID == A).ToList();
                }
                else if (SelectionBox.Text == "Publisher") //Publisher Search
                {
                    string A = BookSearchTextBox.Text;
                    dataGridView1.DataSource = context.Books.Where(x => x.Publisher.Contains(A)).ToList();
                }
                else if (SelectionBox.Text == "Year") //Year Search
                {
                    int A = Int32.Parse(BookSearchTextBox.Text);
                    dataGridView1.DataSource = context.Books.Where(x => x.YearOfPublication.Year == A).ToList();
                }
                else if (SelectionBox.Text == "Language") //Language Search
                {
                    string A = BookSearchTextBox.Text;
                    dataGridView1.DataSource = context.Books.Where(x => x.Language == A).ToList();
                }
                else if (SelectionBox.Text == "Author") //Author Search
                {
                    string A = BookSearchTextBox.Text;
                    dataGridView1.DataSource = context.Books.Where(x => x.Author.Contains(A)).ToList();
                }
                else if (SelectionBox.Text == "Book Type") //Book Type Search
                {
                    string A = BookTypeBox.Text;
                    dataGridView1.DataSource = context.Books.Where(x => x.BookType == A).ToList();
                }
                else if (SelectionBox.Text == "Genre") //Genre Search
                {
                    string A = BookSearchTextBox.Text;
                    dataGridView1.DataSource = context.Books.Where(x => x.Genre == A).ToList();
                }
                else if (SelectionBox.Text == "Location Number") //Book ID Search
                {
                    string A = BookSearchTextBox.Text;
                    dataGridView1.DataSource = context.Books.Where(x => x.LocationNo.Contains(A)).ToList();
                }
            }
            catch
            {

            }
        }

        private void SelectionBox_TextChanged(object sender, EventArgs e)
        {
            BookSearchTextBox.Visible = true;
            BookSearchTextBox.Text = "";
            if (SelectionBox.Text == "Book Type")
            {
                BookSearchTextBox.Visible = false;
                BookTypeBox.Visible = true;
            }
        }
    }
}

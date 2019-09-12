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
    public partial class SearchInBookMaintainance : SA47Team07AProject.SubMainForm
    {
        public SearchInBookMaintainance()
        {
            InitializeComponent();
            BookSearchTextBox.Visible = false;
            BookTypeBox.Visible = false;
        }


        //public static int bookID;
        //public static string bookName;
        //public static string publisher;
        //public static DateTime yearOfPublication;
        //public static string author;
        //public static string language;
        //public static string bookType;
        //public static string genre;
        //public static string locationNumber;
        //public static int totalStock;
        //public static int numberOfBooksBorrowed;

        private void removeBtn_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            if (bookSearchDGV.Rows.Count > 0)
            {
                int index = Convert.ToInt32(bookSearchDGV.CurrentRow.Cells["BookID"].Value);
                Book b = context.Books.Where(x => x.BookID == index).First();
                context.Books.Remove(b);
                context.SaveChanges();
                bookSearchDGV.DataSource = context.Books.
                Select(x => new
                {
                    x.BookID,
                    x.BookName,
                    x.Publisher,
                    x.YearOfPublication,
                    x.Author,
                    x.Language,
                    x.BookType,
                    x.Genre,
                    x.LocationNo,
                    x.TotalStock,
                    x.NoOfBorrowBooks
                }).ToList();
            }
            else
            {
                ErrorMsgForm.ErrorMsg = "Please Select Record First!!!";
                ErrorMsgForm f = new ErrorMsgForm();

                f.ShowDialog();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            if (bookSearchDGV.Rows.Count > 0)
            {
                MainPage.bookID = Convert.ToInt32(bookSearchDGV.CurrentRow.Cells["BookID"].Value.ToString());
                MainPage.bookName = bookSearchDGV.CurrentRow.Cells["BookName"].Value.ToString();
                MainPage.publisher = bookSearchDGV.CurrentRow.Cells["Publisher"].Value.ToString();
                MainPage.yearOfPublication = Convert.ToDateTime(bookSearchDGV.CurrentRow.Cells["YearOfPublication"].Value.ToString());
                MainPage.author = bookSearchDGV.CurrentRow.Cells["Author"].Value.ToString();
                MainPage.language = bookSearchDGV.CurrentRow.Cells["Language"].Value.ToString();
                MainPage.bookType = bookSearchDGV.CurrentRow.Cells["BookType"].Value.ToString();
                MainPage.genre = bookSearchDGV.CurrentRow.Cells["Genre"].Value.ToString();
                MainPage.locationNumber = bookSearchDGV.CurrentRow.Cells["LocationNo"].Value.ToString();
                MainPage.totalStock = Convert.ToInt16(bookSearchDGV.CurrentRow.Cells["TotalStock"].Value.ToString());
                MainPage.numberOfBooksBorrowed = Convert.ToInt16(bookSearchDGV.CurrentRow.Cells["NoOfBorrowBooks"].Value.ToString());
                Edit ef = new Edit();
                ef.ShowDialog();
            }else
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
                    bookSearchDGV.DataSource = context.Books.Where(x => x.BookName.Contains(A)).ToList();
                }
                else if (SelectionBox.Text == "Book ID") //Book ID Search
                {
                    int A = Int32.Parse(BookSearchTextBox.Text);
                    bookSearchDGV.DataSource = context.Books.Where(x => x.BookID == A).ToList();
                }
                else if (SelectionBox.Text == "Publisher") //Publisher Search
                {
                    string A = BookSearchTextBox.Text;
                    bookSearchDGV.DataSource = context.Books.Where(x => x.Publisher.Contains(A)).ToList();
                }
                else if (SelectionBox.Text == "Year") //Year Search
                {
                    int A = Int32.Parse(BookSearchTextBox.Text);
                    bookSearchDGV.DataSource = context.Books.Where(x => x.YearOfPublication.Year == A).ToList();
                }
                else if (SelectionBox.Text == "Language") //Language Search
                {
                    string A = BookSearchTextBox.Text;
                    bookSearchDGV.DataSource = context.Books.Where(x => x.Language == A).ToList();
                }
                else if (SelectionBox.Text == "Author") //Author Search
                {
                    string A = BookSearchTextBox.Text;
                    bookSearchDGV.DataSource = context.Books.Where(x => x.Author.Contains(A)).ToList();
                }
                else if (SelectionBox.Text == "Book Type") //Book Type Search
                {
                    string A = BookTypeBox.Text;
                    bookSearchDGV.DataSource = context.Books.Where(x => x.BookType == A).ToList();
                }
                else if (SelectionBox.Text == "Genre") //Genre Search
                {
                    string A = BookSearchTextBox.Text;
                    bookSearchDGV.DataSource = context.Books.Where(x => x.Genre == A).ToList();
                }
                else if (SelectionBox.Text == "Location Number") //Book ID Search
                {
                    string A = BookSearchTextBox.Text;
                    bookSearchDGV.DataSource = context.Books.Where(x => x.LocationNo.Contains(A)).ToList();
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

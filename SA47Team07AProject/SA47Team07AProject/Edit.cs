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
    public partial class Edit : SA47Team07AProject.SubMainForm
    {
        public Edit()
        {
            InitializeComponent();
            LibraryEntities context = new LibraryEntities();
            bookIDTB.Text = MainPage.bookID.ToString();
            bookNameTB.Text = MainPage.bookName;
            publisherTB.Text = MainPage.publisher;
            yearOfPublicationDTP.Value = MainPage.yearOfPublication;
            authorTB.Text = MainPage.author;
            languageTB.Text = MainPage.language;
            bookTypeTB.Text = MainPage.bookType;
            genreTB.Text = MainPage.genre;
            levelTB.Text = MainPage.locationNumber.Substring(0, 1);
            caseTB.Text = MainPage.locationNumber.Substring(2, 1);
            shelfTB.Text = MainPage.locationNumber.Substring(3, 1);
            totalStockTB.Text = MainPage.totalStock.ToString();
            numberOfBooksBorrowedTB.Text = MainPage.numberOfBooksBorrowed.ToString();
        }

        public void Assigning(Book b)
        {
            b.BookName = bookNameTB.Text;
            b.Publisher = publisherTB.Text;
            b.YearOfPublication = yearOfPublicationDTP.Value;
            b.Author = authorTB.Text;
            b.Language = languageTB.Text;
            b.BookType = bookTypeTB.Text;
            b.Genre = genreTB.Text;
            b.LocationNo = levelTB.Text + "0" + caseTB.Text + shelfTB.Text;
            b.TotalStock = Convert.ToInt16(totalStockTB.Text);
            b.NoOfBorrowBooks = Convert.ToInt16(numberOfBooksBorrowedTB.Text);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryEntities context = new LibraryEntities();
                Book b = context.Books.Where(x => x.BookID == MainPage.bookID).First();
                Assigning(b);
                context.SaveChanges();

                SuccessMsgForm.SuccessMsg = "Edit successfully!";
                SuccessMsgForm f = new SuccessMsgForm();

                f.ShowDialog();
                //MessageBox.Show("Edit successfully!");
                this.DialogResult = DialogResult.OK;

            }
            catch
            {
                ErrorMsgForm.ErrorMsg = "Some input errors, please try again.";
                ErrorMsgForm f = new ErrorMsgForm();

                f.ShowDialog();
                //MessageBox.Show("Some input errors, please try again.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

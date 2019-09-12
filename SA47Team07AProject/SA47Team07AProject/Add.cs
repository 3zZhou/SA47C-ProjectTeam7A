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
    public partial class Add : SA47Team07AProject.SubMainForm
    {
        public Add()
        {
            InitializeComponent();
            bookIDTB.Text = (MainPage.lastRowBookID + 1).ToString();
        }

        public void Assigning(Book b)
        {
            b.BookID = Convert.ToInt16(bookIDTB.Text);
            b.BookName = bookNameTB.Text;
            b.Publisher = publisherTB.Text;
            b.YearOfPublication = yearOfPublicationDTP.Value;
            b.Author = authorTB.Text;
            b.Language = languageTB.Text;
            b.BookType = bookTypeTB.Text;
            b.Genre = genreTB.Text;
            b.LocationNo = levelCB.Text + "0" + caseCB.Text + shelfCB.Text;
            b.TotalStock = Convert.ToInt16(totalStockTB.Text);
            b.NoOfBorrowBooks = Convert.ToInt16(numberOfBooksBorrowedTB.Text);
        }


        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryEntities context = new LibraryEntities();
                Book b = new Book();
                Assigning(b);
                context.Books.Add(b);
                context.SaveChanges();
                SuccessMsgForm.SuccessMsg = "Book is added successfully!";
                SuccessMsgForm f = new SuccessMsgForm();

                f.ShowDialog();
                //MessageBox.Show("Book is added successfully!");
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

        private void bookNameTB_MouseClick(object sender, MouseEventArgs e)
        {
            bookNameTB.Text = "";
        }

        private void publisherTB_MouseClick(object sender, MouseEventArgs e)
        {
            publisherTB.Text = "";
        }

        private void authorTB_MouseClick(object sender, MouseEventArgs e)
        {
            authorTB.Text = "";
        }

        private void languageTB_MouseClick(object sender, MouseEventArgs e)
        {
            languageTB.Text = "";
        }

        private void bookTypeTB_MouseClick(object sender, MouseEventArgs e)
        {
            bookTypeTB.Text = "";
        }

        private void genreTB_MouseClick(object sender, MouseEventArgs e)
        {
            genreTB.Text = "";
        }

        private void totalStockTB_MouseClick(object sender, MouseEventArgs e)
        {
            totalStockTB.Text = "";
        }
    }
}

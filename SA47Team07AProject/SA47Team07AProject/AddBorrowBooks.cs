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
    public partial class AddBorrowBooks : SA47Team07AProject.SubMainForm
    {
        LibraryEntities context = new LibraryEntities();
        public static String BookID = "";
        public static String BookName = "";
        
        public AddBorrowBooks()
        {
            InitializeComponent();
            BorrowDateD.Value = DateTime.Now.Date;
            DueDateD.Value = DateTime.Now.Date.AddDays(14);
            

        }

        private void BrowseBookID_Click(object sender, EventArgs e)
        {
            Form f = new BookIDForm();
            f.ShowDialog();

            bookIDT.Text = BookID;
            BookNameT.Text = BookName;


        }

        private void DueDateD_ValueChanged(object sender, EventArgs e)
        {
            WrongDueDate.Text = " ";

            if(DateTime.Compare(DueDateD.Value.Date, DateTime.Today.Date)<=0)
            {

                DueDateD.Value = DateTime.Now.Date.AddDays(14);
                WrongDueDate.Text = "Your due date is wrong!!!";
            }
        }

        private void bookIDT_Leave(object sender, EventArgs e)
        {
            wrongBookID.Text = " ";
            BookNameT.Text = " ";
            int BookID = Convert.ToInt32(bookIDT.Text);
            var q = from x in context.Books where x.BookID == BookID select x;
            
            if (!q.Any())
            {
                wrongBookID.Text = "There is no such Book in the library";
            }
            else
            {
                Book b = q.First();
                BookNameT.Text = b.BookName;

            }
        }

        private void bookIDT_TextChanged(object sender, EventArgs e)
        {
            wrongBookID.Text = " ";
            BookNameT.Text = " ";
            if(bookIDT.Text != "") {
                try
                {
                    int BookID = Convert.ToInt32(bookIDT.Text);
                    var q = from x in context.Books where x.BookID == BookID select x;

                    if (!q.Any())
                    {
                        wrongBookID.Text = "There is no such Book in the library";
                    }
                    else
                    {
                        Book b = q.First();
                        BookNameT.Text = b.BookName;

                    }
                }
                catch
                {
                    wrongBookID.Text = "There is no such Book in the library";
                }
            }
        }

        private void SubmitBorrow_Click(object sender, EventArgs e)
        {
            if(bookIDT.Text != "" || DateTime.Compare(DueDateD.Value.Date, DateTime.Today.Date) > 0) {


                int bId = Convert.ToInt32(bookIDT.Text);
                Book book = context.Books.Where(x => x.BookID == bId).First();
                int totalstock = book.TotalStock;
                int noOfBorrowBook = book.NoOfBorrowBooks;

                if(totalstock > noOfBorrowBook)
                {
                    int BookId = Convert.ToInt32(bookIDT.Text);
                    int MemId = Convert.ToInt32(MainPage.MemberID);
                    

                    // Retrieve Member Category to test borrow limit


                    var q = from x in context.Members
                            where x.MemberID == MemId
                            select x;
                    Member M = q.First();

                    string memCat= M.MemberCategory;
                    var r = from x in context.MemberCategories
                            where x.MemberCategory1 == memCat
                            select x;
                    MemberCategory MC = r.First();
                    int borrowLimit = MC.BorrowLimit;
                    int borrowedbooks = MC.BorrowedBooks;


                    int OutCount = context.Transactions.Where(x => x.MemberID == MemId && x.Status == "OUT").Count();

                    if (borrowLimit > OutCount)
                    {

                        try { 
                            Transaction t = new Transaction();
                            //var v = context.Transactions.ToList();
                            //Transaction t1 = v.Last();
                            //int recordId = t1.RecordID;

                            //t.RecordID = recordId;

                            DateTime returndate = new DateTime(0001,01,01);
                            t.MemberID = MemId;
                            t.BookID = BookId;
                            t.StaffID = LoginForm.StaffIdLogin;
                            t.BorrowDate = BorrowDateD.Value;
                            t.DueDate = DueDateD.Value;
                            t.ReturnDate = returndate;
                            t.Status = "OUT";

                            t.Remarks = RemarkT.Text;
                            context.Transactions.Add(t);



                            Book b = context.Books.Where(x => x.BookID == bId).First();
                            b.NoOfBorrowBooks += 1;

                            Member m = context.Members.Where(x => x.MemberID == MemId).First();
                            m.TotalBorrowBooks += 1;
                            m.CurrentBorrowBooks += 1;

                            context.SaveChanges();

                            //LibraryEntities context1 = new LibraryEntities();

                            Member M1 = context.Members.Where(x => x.MemberID == MemId).First();


                            if (M1.MemberCategory == "N" && M1.TotalBorrowBooks > borrowedbooks && M1.TotalBorrowBooks >99)
                            {

                                SuccessMsgForm.SuccessMsg = "Member has been upgraded to Silver";
                                SuccessMsgForm f = new SuccessMsgForm();
                                f.ShowDialog();

                                m.MemberCategory = "S";
                            }
                            else if (M1.MemberCategory == "S" && M1.TotalBorrowBooks > borrowedbooks)
                            {
                                SuccessMsgForm.SuccessMsg = "Member has been upgraded to Gold";
                                SuccessMsgForm f = new SuccessMsgForm();
                                f.ShowDialog();

                                m.MemberCategory = "G";
                            }
                            context.SaveChanges();
                        }
                        catch
                        {
                            //Transaction t = new Transaction();
                            //int recordId = 1;

                            //t.RecordID = recordId;
                            //t.MemberID = MemId;
                            //t.BookID = BookId;
                            //t.StaffID = 1;
                            //t.BorrowDate = BorrowDateD.Value;
                            //t.DueDate = DueDateD.Value;
                            //t.Status = "OUT";

                            //t.Remarks = RemarkT.Text;
                            //context.Transactions.Add(t);



                            //Book b = context.Books.Where(x => x.BookID == bId).First();
                            //b.NoOfBorrowBooks += 1;

                            //Member m = context.Members.Where(x => x.MemberID == MemId).First();
                            //m.TotalBorrowBooks += 1;
                            //m.CurrentBorrowBooks += 1;

                            //context.SaveChanges();

                            ////LibraryEntities context1 = new LibraryEntities();

                            //Member M1 = context.Members.Where(x => x.MemberID == MemId).First();


                            //if (M1.MemberCategory == "N" && M1.TotalBorrowBooks > borrowedbooks)
                            //{
                            //    m.MemberCategory = "S";
                            //}
                            //else if (M1.MemberCategory == "S" && M1.TotalBorrowBooks > borrowedbooks)
                            //{
                            //    m.MemberCategory = "G";
                            //}
                            //context.SaveChanges();
                        }

                    }
                    else
                    {

                        ErrorMsgForm.ErrorMsg = "You Can't Borrow Now... Please Return your Book First!!!!";
                        ErrorMsgForm f = new ErrorMsgForm();

                        f.ShowDialog();
                        //MessageBox.Show("You Can't Hire Now... Please Return your Book First!!!!");
                    }



                    this.Close();
                }else
                {
                    ErrorMsgForm.ErrorMsg = "Book is Out Of Stock.....!!!!";
                    ErrorMsgForm f = new ErrorMsgForm();

                    f.ShowDialog();
                    
                }

            }
            else if(bookIDT.Text == "")
            {
                wrongBookID.Text = "Please Fill the book first!!!";
            }
            else if(DateTime.Compare(DueDateD.Value.Date, DateTime.Today.Date) <= 0)
            {
                WrongDueDate.Text = "Please Choose Due Date first!!!";
            }
            this.Close();

        }

        private void CancelBorrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

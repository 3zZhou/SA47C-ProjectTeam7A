using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA47Team07AProject
{

    

    public partial class MainPage : Form
    {
        LibraryEntities context = new LibraryEntities();
        public static string MemberID = "";
        public static int MemberIDINT = 0;
        public static string MemberName = "";
        public static int[] recordIdList = new int[10];
        public static int recordIdCount = 0;
        public static List<Transaction> recordList = new List<Transaction>();
        
        

        public MainPage()
        {
            InitializeComponent();
           
            BookSearchTextBox.Visible = false;
            BookTypeBox.Visible = false;
            QueryResultLabel.Visible = false;
            Location.Visible = false;
            BookLocationLabel.Visible = false;
            BooksRemaining.Visible = false;
            BooksRemainingLabel.Visible = false;
            NextAvailableButton.Visible = false;
            NextAvailableAt.Visible = false;
            BookAvailabilityLabel.Visible = false;
            NewQueryButton.Visible = false;

            QueryButton.Visible = false;
            LibraryEntities context = new LibraryEntities();
            dataTrang.DataSource = context.Members.ToList();

            byCategoryReport.Visible = false;
            MemberReportL.Visible = false;
            MemberReportID.Visible = false;
            button3.Visible = false;
            comboBox1.Visible = false;


            Staff s = context.Staffs.Where(x => x.StaffID == LoginForm.StaffIdLogin).First();

            if(s.StaffDesignation == "Manager")
            {
                
            }else if (s.StaffDesignation == "Admin")
            {

            }else if(s.StaffDesignation == "Chief Librarian")
            {
                ManagementReport.Enabled = false;
            }
            else if (s.StaffDesignation == "Libarian")
            {
                ManagementReport.Enabled = false;
                MemberListReport.Enabled = false;
            }



        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();

            if (memberIDT.Text != "")
            {
                //try
                //{

                    int id = Convert.ToInt32(memberIDT.Text);
                    Form addBorrowBooks = new AddBorrowBooks();
                    addBorrowBooks.ShowDialog();

                    

                    DateTime currentdate = DateTime.Now.Date;
                    DateTime yesterday = DateTime.Now.Date.AddDays(-1);

                    var q = from x in context.Transactions where x.MemberID == id && x.Status == "OUT" && x.BorrowDate == currentdate select new { x.RecordID, x.MemberID, x.Book.BookName, x.BorrowDate, x.DueDate };

                    dataGridView1.DataSource = q.ToList();
                //}
                //catch
                //{
                //    wrongMemberID.Text = "Please check your member ID First!!!";
                //}
                

            }
            else
            {
                wrongMemberID.Text = "Please fill in member ID First!!!";
            }
        }

        private void BrowseMemberID_Click(object sender, EventArgs e)
        {

            Form searchMemberID = new MemberIDForm();
            searchMemberID.ShowDialog();

            memberIDT.Text = MemberID;
            MemberNameT.Text = MemberName;
        }

        private void memberIDT_Leave(object sender, EventArgs e)
        {
            
        }

        private void memberIDT_TextChanged(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            wrongMemberID.Text = " ";
            MemberNameT.Text = " ";
            if (memberIDT.Text != "")
            {

                try
                {
                    int memID = Convert.ToInt32(memberIDT.Text);
                    var q = from x in context.Members where x.MemberID == memID select x;

                    if (!q.Any())
                    {
                        wrongMemberID.Text = "There is no such Member in the record";
                    }
                    else
                    {
                        Member b = q.First();
                        MemberNameT.Text = b.MemberName;
                        MemberID = Convert.ToString(memID);

                    }
                }
                catch
                {
                    wrongMemberID.Text = "There is no such Member in the record";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{

            //    int memberId = Convert.ToInt32(MemberID);
            //    //int BookId = Convert.ToInt32(bookIDT.Text);

            //    // Retrieve Member Category to test borrow limit


            //    var q = from x in context.Members
            //            where x.MemberID == memberId
            //            select x;
            //    Member M = q.First();

            //    string memCat = M.MemberCategory;
            //    var r = from x in context.MemberCategories
            //            where x.MemberCategory1 == memCat
            //            select x;
            //    MemberCategory MC = r.First();
            //    int borrowLimit = MC.BorrowLimit;
            //    int borrowedbooks = MC.BorrowedBooks;

            //    int index = dataGridView1.CurrentRow.Index;
            //    string recordIdSt = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //    int recordId = Convert.ToInt32(recordIdSt);

            //    Transaction t = context.Transactions.Where(x => x.RecordID == recordId).First();
            //    int bId = t.BookID;
            //    int MemId = t.MemberID;


            //    Book b = context.Books.Where(x => x.BookID == bId).First();
            //    b.NoOfBorrowBooks -= 1;

            //    Member m = context.Members.Where(x => x.MemberID == MemId).First();
            //    m.TotalBorrowBooks -= 1;
            //    int currentbb = m.CurrentBorrowBooks - 1;
            //    m.CurrentBorrowBooks = Convert.ToInt16(currentbb);

            //    context.Transactions.Remove(t);
            //    //context.SaveChanges();

            //    //LibraryEntities context1 = new LibraryEntities();

            //    Member M1 = context.Members.Where(x => x.MemberID == MemId).First();


            //    if (M1.MemberCategory == "G" && M1.TotalBorrowBooks <= borrowedbooks)
            //    {
            //        m.MemberCategory = "S";
            //    }
            //    else if (M1.MemberCategory == "S" && M1.TotalBorrowBooks <= borrowedbooks)
            //    {
            //        m.MemberCategory = "N";
            //    }
            //    context.SaveChanges();

            //    int id = Convert.ToInt32(memberIDT.Text);


            //    DateTime currentdate = DateTime.Now.Date;
            //    DateTime yesterday = DateTime.Now.Date.AddDays(-1);

            //    var p = from x in context.Transactions where x.MemberID == id && x.Status == "OUT" && x.BorrowDate == currentdate select new { x.RecordID, x.MemberID, x.Book.BookName, x.BorrowDate, x.DueDate };

            //    dataGridView1.DataSource = p.ToList();
                

            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //crystral report......
            if (dataGridView1.Rows.Count > 0)
            {
                PrintReceiptForm.status = true;
                PrintReceiptForm.successMsg = "Please Take your Receipt.....";
                PrintReceiptForm f = new PrintReceiptForm();

                f.ShowDialog();
               
                dataGridView1.DataSource = null;
                memberIDT.Text = "";
                MemberNameT.Text = "";
            }

            //MessageBox.Show("Please Take your Receipt.....");

        }

        

        private void BrowseMemID_Click(object sender, EventArgs e)
        {

            Form searchMemberID = new MemberIDForm();
            searchMemberID.ShowDialog();

            MemIDT.Text = MemberID;
            MemNameT.Text = MemberName;
        }

        private void MemIDT_TextChanged(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            WrongMemID.Text = " ";
            MemNameT.Text = " ";

            

            if (MemIDT.Text != "")
            {
                try
                {
                    int memID = Convert.ToInt32(MemIDT.Text);
                    var q = from x in context.Members where x.MemberID == memID select x;

                    if (!q.Any())
                    {
                        WrongMemID.Text = "There is no such Member in the record";
                    }
                    else
                    {
                        Member b = q.First();
                        MemNameT.Text = b.MemberName;
                        

                    }

                    int id = Convert.ToInt32(MemIDT.Text);

                    var s = from x in context.Transactions where x.MemberID == id && x.Status == "OUT" select new { x.RecordID, x.MemberID, x.Book.BookName, x.BorrowDate, x.DueDate };

                    ReturnGridView.DataSource = s.ToList();
                }
                catch
                {
                    WrongMemID.Text = "There is no such Member in the record";
                }
                
            }




        }
        public static int memID;

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            
            if (ReturnGridView.Rows.Count > 0)
            {
                
                LibraryEntities context1 = new LibraryEntities();
                int index = ReturnGridView.CurrentRow.Index;
                string recordIdSt = ReturnGridView.Rows[index].Cells[0].Value.ToString();
                int recordId = Convert.ToInt32(recordIdSt);

                Transaction T = context1.Transactions.Where(x => x.RecordID == recordId).First();
                T.Status = "IN";
                T.ReturnDate = DateTime.Now.Date;
                int bId = T.BookID;
                int MemId = T.MemberID;

                memID = MemId;
                Book b = context1.Books.Where(x => x.BookID == bId).First();
                b.NoOfBorrowBooks -= 1;

                Member m = context1.Members.Where(x => x.MemberID == MemId).First();
                
                m.CurrentBorrowBooks -= 1;


                context1.SaveChanges();


                int id = Convert.ToInt32(MemIDT.Text);

                var s = from x in context1.Transactions where x.MemberID == id && x.Status == "OUT" select new { x.RecordID, x.MemberID, x.Book.BookName, x.BorrowDate, x.DueDate };

                ReturnGridView.DataSource = s.ToList();

                

                //MessageBox.Show("Finish Return..... \n Please Take your Receipt");
            }
            else
            {
                ErrorMsgForm.ErrorMsg = "Please Select Your Record First!!!!";
                ErrorMsgForm f = new ErrorMsgForm();

                f.ShowDialog();
                //MessageBox.Show("Please Select Your Record First!!!!");
            }
        }











        //Paul Code Start...........







        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            try
            {
                if (SelectionBox.Text == "Book Name") //Book Name Search
                {
                    string A = BookSearchTextBox.Text;
                    BookSearchGridView.DataSource = context.Books.Where(x => x.BookName.Contains(A)).ToList();

                    if (BookSearchGridView.Rows.Count == 0)
                    {
                        ErrorMsgForm.ErrorMsg = "No books found. Please try again.";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                        //MessageBox.Show("No books found. Please try again.");
                    }
                }
                else if (SelectionBox.Text == "Book ID") //Book ID Search
                {
                    if (BookSearchTextBox.Text != "")
                    {
                        if (BookSearchTextBox.Text.All(char.IsDigit) && BookSearchTextBox.Text != "0")
                        {
                            int A = Int32.Parse(BookSearchTextBox.Text);
                            BookSearchGridView.DataSource = context.Books.Where(x => x.BookID == A).ToList();
                        }
                        else
                        {
                            ErrorMsgForm.ErrorMsg = "Please key in numbers only";
                            ErrorMsgForm f = new ErrorMsgForm();
                            f.ShowDialog();
                            //MessageBox.Show("Please key in numbers only");
                        }
                    }
                    else
                    {
                        ErrorMsgForm.ErrorMsg = "Please key in a value";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                        //MessageBox.Show("Please key in a value");
                    }

                    if (BookSearchGridView.Rows.Count == 0)
                    {
                        ErrorMsgForm.ErrorMsg = "No books found. Please try again.";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                        //MessageBox.Show("No books found. Please try again.");
                    }
                }
                else if (SelectionBox.Text == "Publisher") //Publisher Search
                {
                    string A = BookSearchTextBox.Text;
                    BookSearchGridView.DataSource = context.Books.Where(x => x.Publisher.Contains(A)).ToList();
                    if (BookSearchGridView.Rows.Count == 0)
                    {
                        ErrorMsgForm.ErrorMsg = "No books found. Please try again.";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                        //MessageBox.Show("No books found. Please try again.");
                    }
                }
                else if (SelectionBox.Text == "Year") //Year Search
                {
                    if (BookSearchTextBox.Text.All(char.IsDigit))
                    {
                        int A = Int32.Parse(BookSearchTextBox.Text);
                        BookSearchGridView.DataSource = context.Books.Where(x => x.YearOfPublication.Year == A).ToList();
                    }
                    else
                    {
                        ErrorMsgForm.ErrorMsg = "Please key in a value";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                       // MessageBox.Show("Please key in numbers only");
                    }

                    if (BookSearchGridView.Rows.Count == 0)
                    {
                        ErrorMsgForm.ErrorMsg = "No books found. Please try again.";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                       // MessageBox.Show("No books found. Please try again.");
                    }
                }
                else if (SelectionBox.Text == "Language") //Language Search
                {
                    if (BookSearchTextBox.Text.All(char.IsLetter))
                    {
                        string A = BookSearchTextBox.Text;
                        BookSearchGridView.DataSource = context.Books.Where(x => x.Language == A).ToList();
                    }
                    else
                    {

                        ErrorMsgForm.ErrorMsg = "Please type an appropriate language";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                       // MessageBox.Show("Please type an appropriate language");
                    }
                    if (BookSearchGridView.Rows.Count == 0)
                    {
                        ErrorMsgForm.ErrorMsg = "No books found. Please try again.";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                        //MessageBox.Show("No books found. Please try again.");
                    }
                }
                else if (SelectionBox.Text == "Author") //Author Search
                {
                    string A = BookSearchTextBox.Text;
                    BookSearchGridView.DataSource = context.Books.Where(x => x.Author.Contains(A)).ToList();
                    if (BookSearchGridView.Rows.Count == 0)
                    {
                        ErrorMsgForm.ErrorMsg = "No books found. Please try again.";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                       // MessageBox.Show("No books found. Please try again.");
                    }
                }
                else if (SelectionBox.Text == "Book Type") //Book Type Search
                {
                    string A = BookTypeBox.Text;
                    BookSearchGridView.DataSource = context.Books.Where(x => x.BookType == A).ToList();
                    if (BookSearchGridView.Rows.Count == 0)
                    {
                        ErrorMsgForm.ErrorMsg = "No books found. Please try again.";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                        //MessageBox.Show("No books found. Please try again.");
                    }
                }
                else if (SelectionBox.Text == "Genre") //Genre Search
                {
                    if (BookSearchTextBox.Text.All(char.IsLetter))
                    {
                        string A = BookSearchTextBox.Text;
                        BookSearchGridView.DataSource = context.Books.Where(x => x.Genre == A).ToList();
                        if (BookSearchGridView.Rows.Count == 0)
                        {
                            ErrorMsgForm.ErrorMsg = "No books found. Please try again.";
                            ErrorMsgForm f = new ErrorMsgForm();
                            f.ShowDialog();
                           // MessageBox.Show("No books found. Please try again.");
                        }
                    }
                    else
                    {
                        ErrorMsgForm.ErrorMsg = "Please key in letters only";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                       // MessageBox.Show("Please key in letters only");
                    }
                }
                else if (SelectionBox.Text == "Location Number") //Book ID Search
                {
                    string A = BookSearchTextBox.Text;
                    BookSearchGridView.DataSource = context.Books.Where(x => x.LocationNo.Contains(A)).ToList();
                    if (BookSearchGridView.Rows.Count == 0)
                    {
                        
                        MessageBox.Show("Please key in a valid location. (1031 for 1st Floor, Book Case 3, Shelf 1)"
                            + Environment.NewLine + "Each of the 3 Levels has 6 Cases and 3 Shelves.");
                    }
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

        private void BookSearchButton_Click(object sender, EventArgs e)
        {
            QuerySearch a = new QuerySearch();
            DialogResult r = a.ShowDialog();
            QueryButton.Visible = true;
            BookNameLabel.Text = QuerySearch.BkName;
            AuthorLabel.Text = QuerySearch.BkAuthor;
            BookTypeLabel.Text = QuerySearch.BkType;
            GenreLabel.Text = QuerySearch.BkGenre;
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();

            QueryResultLabel.Visible = true;
            Location.Visible = true;
            BookLocationLabel.Visible = true;
            BooksRemaining.Visible = true;
            BooksRemainingLabel.Visible = true;


            try
            {
                Location L = context.Locations.Where(x => x.LocationNo == QuerySearch.BkLocation).First();
                BookLocationLabel.Text = L.LocationDescription.ToString();

                int a = QuerySearch.BkTtlStock - QuerySearch.BkBorrowed;
                BooksRemainingLabel.Text = a.ToString();

                if (BooksRemainingLabel.Text == "0")
                { NextAvailableButton.Visible = true; }

                NewQueryButton.Visible = true;
            }
            catch
            {

            }
        }

        private void NextAvailableButton_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            NextAvailableAt.Visible = true;
            BookAvailabilityLabel.Visible = true;
            Transaction T = context.Transactions.Where(x => x.BookID == QuerySearch.BkID && x.Status == "OUT").OrderBy(y => y.DueDate).First();
            BookAvailabilityLabel.Text = T.DueDate.Date.ToString("dd MMMM yyyy");
        }

        private void NewQueryButton_Click(object sender, EventArgs e)
        {
            QueryResultLabel.Visible = false;
            Location.Visible = false;
            BookLocationLabel.Visible = false;
            BooksRemaining.Visible = false;
            BooksRemainingLabel.Visible = false;
            NextAvailableButton.Visible = false;
            NextAvailableAt.Visible = false;
            BookAvailabilityLabel.Visible = false;
            NewQueryButton.Visible = false;
            BookNameLabel.Text = " ";
            AuthorLabel.Text = " ";
            BookTypeLabel.Text = " ";
            GenreLabel.Text = " ";
        }







        //Treezy Code Start
        






        private void showAllBtn_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            bookMaintainanceDGV.DataSource = context.Books.
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            bookMaintainanceDGV.DataSource = context.Books.
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
            lastRowBookID = Convert.ToInt32(bookMaintainanceDGV.Rows[bookMaintainanceDGV.Rows.Count - 1].Cells["BookID"].Value);
            Add af = new Add();
            af.ShowDialog();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

            RemoveWarningForm rwf = new RemoveWarningForm();
            rwf.ShowDialog();
            if (rwf.DialogResult == DialogResult.OK)
            {

                LibraryEntities context = new LibraryEntities();
                if (bookMaintainanceDGV.Rows.Count > 0)
                {

                    int index = Convert.ToInt32(bookMaintainanceDGV.CurrentRow.Cells["BookID"].Value);
                    Book b = context.Books.Where(x => x.BookID == index).First();
                    context.Books.Remove(b);
                    context.SaveChanges();
                    bookMaintainanceDGV.DataSource = context.Books.
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

                    //MessageBox.Show("Please Select Record First!!!");
                }
            }
        }
        public static int bookID;
        public static string bookName;
        public static string publisher;
        public static DateTime yearOfPublication;
        public static string author;
        public static string language;
        public static string bookType;
        public static string genre;
        public static string locationNumber;
        public static int totalStock;
        public static int numberOfBooksBorrowed;
        public static int lastRowBookID;

        private void editBtn_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            if (bookMaintainanceDGV.Rows.Count > 0)
            {

                bookID = Convert.ToInt32(bookMaintainanceDGV.CurrentRow.Cells["BookID"].Value.ToString());
                bookName = bookMaintainanceDGV.CurrentRow.Cells["BookName"].Value.ToString();
                publisher = bookMaintainanceDGV.CurrentRow.Cells["Publisher"].Value.ToString();
                yearOfPublication = Convert.ToDateTime(bookMaintainanceDGV.CurrentRow.Cells["YearOfPublication"].Value.ToString());
                author = bookMaintainanceDGV.CurrentRow.Cells["Author"].Value.ToString();
                language = bookMaintainanceDGV.CurrentRow.Cells["Language"].Value.ToString();
                bookType = bookMaintainanceDGV.CurrentRow.Cells["BookType"].Value.ToString();
                genre = bookMaintainanceDGV.CurrentRow.Cells["Genre"].Value.ToString();
                locationNumber = bookMaintainanceDGV.CurrentRow.Cells["LocationNo"].Value.ToString();
                totalStock = Convert.ToInt16(bookMaintainanceDGV.CurrentRow.Cells["TotalStock"].Value.ToString());
                numberOfBooksBorrowed = Convert.ToInt16(bookMaintainanceDGV.CurrentRow.Cells["NoOfBorrowBooks"].Value.ToString());
                Edit ef = new Edit();
                ef.ShowDialog();
            }
            else
            {
                ErrorMsgForm.ErrorMsg = "Please Select Record First!!!";
                ErrorMsgForm f = new ErrorMsgForm();

                f.ShowDialog();
                //MessageBox.Show("Please Select Record First!!!!");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchInBookMaintainance sf = new SearchInBookMaintainance();
            sf.ShowDialog();
        }






        //Trang Code Start.............




        public static string memId = "";

        public static int lastRowmemberId;


        private void search_Click(object sender, EventArgs e)
        {
            this.dataTrang.DataSource = null;

            

            LibraryEntities context = new LibraryEntities();
            try
            {
                int memberIdInt = int.Parse(memberIdTrang.Text.ToString());
                Member m = context.Members.Where(x => x.MemberID == memberIdInt).First();
                
                this.dataTrang.ColumnCount = 10;
                dataTrang.Columns[0].Name = "MemberID";
                dataTrang.Columns[1].Name = "MemberName";
                dataTrang.Columns[2].Name = "IDNo";
                dataTrang.Columns[3].Name = "MemberCategory";
                dataTrang.Columns[4].Name = "DateOfBirth";
                dataTrang.Columns[5].Name = "PhoneNo";
                dataTrang.Columns[6].Name = "Address";
                dataTrang.Columns[7].Name = "Email";
                dataTrang.Columns[8].Name = "TotalBorrowBooks";
                dataTrang.Columns[9].Name = "CurrentBorrowBooks";

                this.dataTrang.Rows.Add();
                this.dataTrang.Rows[0].Cells[0].Value = m.MemberID.ToString();
                this.dataTrang.Rows[0].Cells[1].Value = m.MemberName.ToString();
                this.dataTrang.Rows[0].Cells[2].Value = m.IDNo.ToString();
                this.dataTrang.Rows[0].Cells[3].Value = m.MemberCategory.ToString();
                this.dataTrang.Rows[0].Cells[4].Value = m.DateOfBirth.ToString();
                this.dataTrang.Rows[0].Cells[5].Value = m.PhoneNo.ToString();
                this.dataTrang.Rows[0].Cells[6].Value = m.Address.ToString();
                this.dataTrang.Rows[0].Cells[7].Value = m.Email.ToString();
                this.dataTrang.Rows[0].Cells[8].Value = m.TotalBorrowBooks.ToString();
                this.dataTrang.Rows[0].Cells[9].Value = m.CurrentBorrowBooks.ToString();
            }
            catch
            {
                dataTrang.DataSource = context.Members.ToList();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {

            
            int memberId = Int32.Parse(dataTrang.SelectedCells[0].Value.ToString());

            LibraryEntities context = new LibraryEntities();
            Member m = context.Members.Where(x => x.MemberID == memberId).First();
            memId = m.MemberID.ToString();

            //this.Hide();
            var form3 = new EditMember();
           // form3.Closed += (s, args) => this.Close();
            form3.ShowDialog();

            dataTrang.DataSource = context.Members.ToList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();

            dataTrang.DataSource = context.Members.
                 Select(x => new
                 {
                     x.MemberID
                 }).ToList();
            lastRowmemberId = Convert.ToInt32(dataTrang.Rows[dataTrang.Rows.Count - 1].Cells["MemberID"].Value);
            var form2 = new AddMember();
            //form2.Closed += (s, args) => this.Close();
            form2.ShowDialog();

            dataTrang.DataSource = context.Members.ToList();

        }

        private void remove_Click(object sender, EventArgs e)
        {
            int memberId = Int32.Parse(dataTrang.SelectedCells[0].Value.ToString());
            LibraryEntities context = new LibraryEntities();
            Member m = context.Members.Where(x => x.MemberID == memberId).First();

            context.Members.Remove(m);
            context.SaveChanges();

            SuccessMsgForm.SuccessMsg = "Deleted Complete!!!!";
            SuccessMsgForm f = new SuccessMsgForm();

            f.ShowDialog();

            //MessageBox.Show("Deleted");

            dataTrang.DataSource = context.Members.ToList();
        }




        //MyCode.....



        private void button2_Click_1(object sender, EventArgs e)
        {
            PrintReceiptForm.status = false;
            PrintReceiptForm.successMsg = "Finish Return..... \n Please Take the Receipt";
            PrintReceiptForm f = new PrintReceiptForm();

            f.ShowDialog();


            MemIDT.Text = "";
            MemNameT.Text = "";
            ReturnGridView.DataSource = null;


        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //LoginForm A = new LoginForm();
            //DialogResult r = A.ShowDialog();
            //if (r != DialogResult.OK)
            //{
            //    this.Close();
            //}

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (ManagementReport.Checked)
            {

                if (comboBox1.SelectedIndex == 0)
                {

                    ReportForm.form = "Management Report 1";

                    ReportForm f = new ReportForm();
                    f.ShowDialog();
                    //MessageBox.Show("Management Report");
                }else if (comboBox1.SelectedIndex == 1)
                {

                    ReportForm.form = "Management Report 2";

                    ReportForm f = new ReportForm();
                    f.ShowDialog();
                    //MessageBox.Show("Management Report");
                }
                else if (comboBox1.SelectedIndex == 2)
                {

                    ReportForm.form = "Management Report 3";

                    ReportForm f = new ReportForm();
                    f.ShowDialog();
                    //MessageBox.Show("Management Report");
                }
                else if (comboBox1.SelectedIndex == 3)
                {

                    ReportForm.form = "Management Report 4";

                    ReportForm f = new ReportForm();
                    f.ShowDialog();
                    //MessageBox.Show("Management Report");
                }
            }
            else if (BookListReport.Checked)
            {
                ReportForm.form = "Book List";

                ReportForm f = new ReportForm();
                f.ShowDialog();
            }
            else if (MemberListReport.Checked)
            {

                if (byCategoryReport.Checked)
                {
                    ReportForm.form = "Member Category";

                    ReportForm f = new ReportForm();
                    f.ShowDialog();
                }
                else
                {

                    ReportForm.form = "Member List";

                    ReportForm f = new ReportForm();
                    f.ShowDialog();
                }


            }
            else if (ListOfBorrowBook.Checked)
            {

                ReportForm.form = "Book On Loan";

                ReportForm f = new ReportForm();
                f.ShowDialog();

            }
            else if (MemberRecordReport.Checked)
            {

                if (MemberReportID.Text != "")
                {
                    try
                    {
                        int memID = Convert.ToInt32(MemberReportID.Text);
                        var q = from x in context.Members where x.MemberID == memID select x;

                        if (!q.Any())
                        {
                            ErrorReportL.Text = "There is no such Member in the record";
                            ErrorMsgForm.ErrorMsg = "There is no such Member in the record";
                            ErrorMsgForm f = new ErrorMsgForm();
                            f.ShowDialog();
                        }
                        else
                        {
                            ReportForm.MemberId = memID;
                            ReportForm.form = "Member Record";
                            ReportForm f = new ReportForm();
                            f.ShowDialog();
                        }
                    }
                    catch
                    {
                        ErrorReportL.Text = "There is no such Member in the record";
                        ErrorMsgForm.ErrorMsg = "There is no such Member in the record";
                        ErrorMsgForm f = new ErrorMsgForm();
                        f.ShowDialog();
                    }
                }


            }
        }

        private void MemberRecordReport_CheckedChanged(object sender, EventArgs e)
        {
            MemberReportID.Visible = true;
            MemberReportL.Visible = true;
            button3.Visible = true;
            byCategoryReport.Visible = false;
            comboBox1.Visible = false;

        }

        private void MemberListReport_CheckedChanged(object sender, EventArgs e)
        {
            byCategoryReport.Visible = true;
            MemberReportID.Visible = false;
            MemberReportL.Visible = false;
            button3.Visible = false;
            comboBox1.Visible = false;

        }
        
        private void MemberReportID_TextChanged(object sender, EventArgs e)
        {
            if (MemberReportID.Text != "")
            {
                try
                {

                    int memID = Convert.ToInt32(MemberReportID.Text);
                    var q = from x in context.Members where x.MemberID == memID select x;

                    if (!q.Any())
                    {
                        ErrorReportL.Text = "There is no such Member in the record";
                    }
                    else
                    {
                        ErrorReportL.Text = "";
                    }
                }
                catch
                {
                    ErrorReportL.Text = "There is no such Member in the record";
                }
            }
        }

        private void ManagementReport_CheckedChanged(object sender, EventArgs e)
        {
            byCategoryReport.Visible = false;
            MemberReportID.Visible = false;
            MemberReportL.Visible = false;
            button3.Visible = false;
            comboBox1.Visible = true;
        }

        private void BookListReport_CheckedChanged(object sender, EventArgs e)
        {
            byCategoryReport.Visible = false;
            MemberReportID.Visible = false;
            MemberReportL.Visible = false;
            button3.Visible = false;
            comboBox1.Visible = false;


        }

        private void ListOfBorrowBook_CheckedChanged(object sender, EventArgs e)
        {
            byCategoryReport.Visible = false;
            MemberReportID.Visible = false;
            MemberReportL.Visible = false;
            button3.Visible = false;
            comboBox1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form searchMemberID = new MemberIDForm();
            searchMemberID.ShowDialog();

            MemberReportID.Text = MemberID;
            //MemberNameT.Text = MemberName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //LibraryEntities context = new LibraryEntities();
            dataTrang.DataSource = null; 
            dataTrang.DataSource = context.Members.ToList();
        }
    }
}

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

    
    public partial class BorrowReceiptForm : SA47Team07AProject.SubMainForm
    {
       public static bool borrowstatus = false;

        public BorrowReceiptForm()
        {
            InitializeComponent();
        }

        private void BorrowReceiptForm_Load(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            BorrowReceipt A = new BorrowReceipt();
            ReturnReceipt B = new ReturnReceipt();

            if(borrowstatus == true)
            {

                int C = Convert.ToInt32(MainPage.MemberID);

                if (C > 0)
                {
                    DateTime currentdate = DateTime.Now.Date;
                    int count = context.ReceiptView.Where(x => x.MemberID == C && x.Status == "OUT" && x.BorrowDate == currentdate).Count();
                    if (count > 0)
                    {
                        A.SetDataSource(context.ReceiptView.Where(x => x.MemberID == C && x.Status == "OUT" && x.BorrowDate == currentdate).ToList());
                    }
                    else
                    {
                        MessageBox.Show("Member did not borrow any books");
                    }

                    crystalReportViewer1.ReportSource = A;
                }
            }
            else
            {
                int C = Convert.ToInt32(MainPage.memID);

                if (C > 0)
                {
                    DateTime currentdate = DateTime.Now.Date;
                    int count = context.ReceiptView.Where(x => x.MemberID == C && x.Status == "IN" && x.ReturnDate == currentdate).Count();
                    if (count > 0)
                    {
                        B.SetDataSource(context.ReceiptView.Where(x => x.MemberID == C && x.Status == "IN" && x.ReturnDate == currentdate).ToList());
                    }
                    else
                    {
                        MessageBox.Show("Member did not borrow any books");
                    }

                    crystalReportViewer1.ReportSource = B;
                }
            }

            }

            
            
        }
    }


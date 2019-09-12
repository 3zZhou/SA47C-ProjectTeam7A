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
    public partial class ReportForm : SA47Team07AProject.SubMainForm
    {

        public static int MemberId;
        public static string form = "";
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

            if (form == "Member Record")
            {
                LibraryEntities context = new LibraryEntities();
                MemberRecord A = new MemberRecord();

                int C = MemberId;

                if (C > 0)
                {
                    int count = context.ReceiptView.Where(x => x.MemberID == C && x.Status == "OUT").Count();
                    if (count > 0)
                    {
                        A.SetDataSource(context.ReceiptView.Where(x => x.MemberID == C && x.Status == "OUT").ToList());
                        crystalReportViewer1.ReportSource = A;
                    }
                    else
                    {
                        SuccessMsgForm.SuccessMsg = "Member did not borrow any books";
                        SuccessMsgForm f = new SuccessMsgForm();
                        f.ShowDialog();
                        this.Close();
                        //MessageBox.Show("Member did not borrow any books");
                    }


                }
            }else if(form=="Book List")
            {
                LibraryEntities context = new LibraryEntities();
                BookList cr = new BookList();
                cr.SetDataSource(context.Books.ToList());
                crystalReportViewer1.ReportSource = cr;
            }
            else if(form == "Member List")
            {
                LibraryEntities context = new LibraryEntities();
                MemberList mr = new MemberList();
                mr.SetDataSource(context.MemberListView.ToList());
                crystalReportViewer1.ReportSource = mr;
            }else if(form == "Member Category")
            {
                LibraryEntities context = new LibraryEntities();
                MemberByGroupCategory mgr = new MemberByGroupCategory();
                mgr.SetDataSource(context.MemberListView.ToList());
                crystalReportViewer1.ReportSource = mgr;
            }else if(form == "Book On Loan")
            {
                LibraryEntities context = new LibraryEntities();
                BookOnLoan bolr = new BookOnLoan();
                int count = context.ListOfBooksOnLoan.Where(x => x.Status == "OUT").Count();
                if (count > 0)
                {
                    bolr.SetDataSource(context.ListOfBooksOnLoan.Where(x => x.Status == "OUT").ToList());
                }
                else
                {
                    MessageBox.Show("No book is on loan.");
                }
                crystalReportViewer1.ReportSource = bolr;
            }else if(form == "Management Report 3")
            {
                LibraryEntities context = new LibraryEntities();
                ManagementReport3 mgr = new ManagementReport3();
                mgr.SetDataSource(context.ManagementView.ToList());
                crystalReportViewer1.ReportSource = mgr;
            }else if(form == "Management Report 2")
            {
                LibraryEntities context = new LibraryEntities();
                ManagementReport2 mgr = new ManagementReport2();
                mgr.SetDataSource(context.MemberListView.ToList());
                crystalReportViewer1.ReportSource = mgr;
            }
            else if (form == "Management Report 1")
            {
                LibraryEntities context = new LibraryEntities();
                ManagementReport1 mgr = new ManagementReport1();
                mgr.SetDataSource(context.MemberListView.ToList());
                crystalReportViewer1.ReportSource = mgr;
            }
            else if (form == "Management Report 4")
            {
                LibraryEntities context = new LibraryEntities();
                ManagementReport4 mgr = new ManagementReport4();
                mgr.SetDataSource(context.MemberListView.ToList());
                crystalReportViewer1.ReportSource = mgr;
            }
        }
            
        }
    }


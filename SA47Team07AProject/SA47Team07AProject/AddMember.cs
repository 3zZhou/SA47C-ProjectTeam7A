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
    public partial class AddMember : SA47Team07AProject.SubMainForm
    {
        public AddMember()
        {
            InitializeComponent();
            memberId.Text = (MainPage.lastRowmemberId + 1).ToString();
        }

        private void submit_Click(object sender, EventArgs e)
        {

            try
            {
                Member m = new Member();
                m.MemberID = int.Parse(memberId.Text);
                m.MemberName = memberName.Text;
                m.IDNo = IDNo.Text;
                m.MemberCategory = memcat.Text;
                m.DateOfBirth = DateTime.Parse(dob.Text);
                m.PhoneNo = contactNumber.Text;
                m.Address = address.Text;
                m.Email = email.Text;
                m.TotalBorrowBooks = 0;
                m.CurrentBorrowBooks = 0;

                LibraryEntities context = new LibraryEntities();
                context.Members.Add(m);
                context.SaveChanges();

                SuccessMsgForm.SuccessMsg = "Update Complete!!!!";
                SuccessMsgForm f = new SuccessMsgForm();

                f.ShowDialog();
                // MessageBox.Show("Added");

                this.Close();

            }
            catch
            {
                ErrorMsgForm.ErrorMsg = "Please Check Your Input Data.......";
                ErrorMsgForm f = new ErrorMsgForm();

                f.ShowDialog();
            }
            //var form1 = new Form1();
            //form1.Closed += (s, args) => this.Close();
            //form1.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

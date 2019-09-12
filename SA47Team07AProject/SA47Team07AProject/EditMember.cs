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
    public partial class EditMember : SA47Team07AProject.SubMainForm
    {
        public EditMember()
        {
            InitializeComponent();
            int memberIdInt = Int32.Parse(MainPage.memId);

            LibraryEntities context = new LibraryEntities();
            Member m = context.Members.Where(x => x.MemberID == memberIdInt).First();

            memberId.Text = m.MemberID.ToString();
            IDNo.Text = m.IDNo;
            memcat.Text = m.MemberCategory;
            memberName.Text = m.MemberName;
            dob.Text = m.DateOfBirth.ToString();
            address.Text = m.Address;
            email.Text = m.Email;
            contactNumber.Text = m.PhoneNo;
          //  totalBorrowed.Text = m.TotalBorrowBooks.ToString();
          //  currentBorrowed.Text = m.CurrentBorrowBooks.ToString();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int memberIdInt = Int32.Parse(MainPage.memId);

            LibraryEntities context = new LibraryEntities();
            Member m = context.Members.Where(x => x.MemberID == memberIdInt).First();
            m.MemberName = memberName.Text;
            m.MemberCategory = memcat.Text;
            m.DateOfBirth = DateTime.Parse(dob.Text);
            m.PhoneNo = contactNumber.Text;
            m.Address = address.Text;
            m.Email = email.Text;
          //  m.TotalBorrowBooks = short.Parse(totalBorrowed.Text);
          //  m.CurrentBorrowBooks = short.Parse(currentBorrowed.Text);

            context.SaveChanges();

            SuccessMsgForm.SuccessMsg = "Edit Complete!!!!";
            SuccessMsgForm f = new SuccessMsgForm();

            f.ShowDialog();
            this.Close();
            //MessageBox.Show("Edited");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

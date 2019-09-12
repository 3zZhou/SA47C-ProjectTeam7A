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
    public partial class LoginForm : SA47Team07AProject.SubMainForm
    {

        LibraryEntities context = new LibraryEntities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var q = from x in context.Staffs.Where(x => x.UserName == textBox1.Text) select x;

                if (textBox2.Text.CompareTo(q.First().Password.ToString()) == 0)
                {

                    StaffIdLogin = q.First().StaffID;

                    ErrorMsg.Text = " ";
                    Form f = new MainPage();
                    f.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    //this.DialogResult = DialogResult.OK;
                    //this.Close();
                    
                }
                else
                { /*MessageBox.Show("Please check Username & Password");*/
                    ErrorMsgForm.ErrorMsg = "Please check Username & Password";
                    ErrorMsgForm f = new ErrorMsgForm();
                    
                    f.ShowDialog();
                    //ErrorMsg.Text = "Please check Username & Password";
                    //textBox1.Text = "";
                    //textBox2.Text = "";
                }
            }
            catch
            {
                ErrorMsgForm.ErrorMsg = "Please check Username & Password";
                ErrorMsgForm f = new ErrorMsgForm();
                
                f.ShowDialog();
                //textBox1.Text = "";
                //textBox2.Text = "";
            }
        }

        public static int StaffIdLogin;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

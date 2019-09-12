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
    public partial class PrintReceiptForm : Form
    {

        public static string successMsg = "";
        public static bool status=false;
        public PrintReceiptForm()
        {
            InitializeComponent();
            label1.Text = successMsg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                BorrowReceiptForm.borrowstatus = true;
            }
            else
            {
                BorrowReceiptForm.borrowstatus = false;
            }
            BorrowReceiptForm borrow = new BorrowReceiptForm();
            borrow.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}

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
    public partial class ErrorMsgForm : Form
    {

        public static String ErrorMsg = "";

        public ErrorMsgForm()
        {
            InitializeComponent();
            ErrorTextBox.Text = ErrorMsg;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorMsgForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

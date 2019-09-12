using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA47Team07AProject
{

    
    public partial class SuccessMsgForm : SA47Team07AProject.ErrorMsgForm
    {

        public static String SuccessMsg = "";

        public SuccessMsgForm()
        {
            InitializeComponent();
            ErrorTextBox.Text = SuccessMsg;
        }
    }
}

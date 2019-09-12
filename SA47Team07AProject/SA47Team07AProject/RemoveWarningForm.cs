using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA47Team07AProject
{
    public partial class RemoveWarningForm : SA47Team07AProject.SubMainForm
    {
        public RemoveWarningForm()
        {
            InitializeComponent();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

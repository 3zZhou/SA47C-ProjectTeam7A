using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace SA47Team07AProject
{
    public partial class MemberIDForm : SA47Team07AProject.SubMainForm
    {
        LibraryEntities context = new LibraryEntities();
        public MemberIDForm()
        {
            InitializeComponent();


            var q = from x in context.Members select new { x.MemberID, x.IDNo, x.MemberName };

            dataGridView1.DataSource = q.ToList();

        }

        private void SubmitBorrow_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentRow.Index;

            MainPage.MemberID = dataGridView1.Rows[index].Cells[0].Value.ToString();

            MainPage.MemberName = dataGridView1.Rows[index].Cells[2].Value.ToString();

            this.Close();

        }
                private void CancelBorrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

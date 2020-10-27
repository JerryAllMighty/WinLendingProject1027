using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLendingProject
{
    public partial class frmMain : Form
    {
        frmStudent studentFrm;

        public frmMain()
        {
            InitializeComponent();
        }

        private void 학생관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (studentFrm == null)
            {
                studentFrm = new frmStudent();
                studentFrm.MdiParent = this;
                studentFrm.Show(); // Load => Shown => Activate
            }
            else
            {
                studentFrm.Activate(); // Activate
            }
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBook frm = new frmBook();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

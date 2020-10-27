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
    public partial class frmStudentSearch : Form
    {
        public int StudentID 
        {
            get { return int.Parse(txtstudentid.Text); }  
        }

        public frmStudentSearch()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtstudentid.Text.Length < 7)
            {
                MessageBox.Show("검색하실 학번을 7자리로 입력하세요.");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtstudentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtstudentid.Text.Length == 7)
                    btnOK.PerformClick();
                else
                    btnCancel.PerformClick();
            }
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}

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
    public partial class frmBookIns : Form
    {
        public Book BookInfo
        {
            get
            {
                return new Book(int.Parse(txtBookID.Text), txtBookName.Text, txtBookAuthor.Text); }
            set
            {
                txtBookID.Text = value.ID.ToString();
                txtBookName.Text = value.Name;
                txtBookAuthor.Text = value.Author;
            }
        }
        public frmBookIns(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Insert)
            {
                this.Text = "책 정보입력";
                txtBookID.Enabled = true;
            }
            else
            {
                this.Text = "학생정보수정";
                txtBookID.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //유효성체크
            StringBuilder sb = new StringBuilder();

            if (txtBookID.Text.Length < 10)
            {
                sb.AppendLine("책번호는 10자리로 입력하세요.");
                //return;
            }

            if (string.IsNullOrEmpty(txtBookName.Text))
            {
                sb.AppendLine("책 이름을 입력하세요.");

            }
            if (sb.ToString().Length > 0)
            {
                MessageBox.Show(sb.ToString());
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void frmBookIns_Load(object sender, EventArgs e)
        {

        }

        private void txtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

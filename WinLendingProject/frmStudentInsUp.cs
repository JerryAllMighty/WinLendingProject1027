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
    public enum OpenMode { Insert, Update }
    
    public partial class frmStudentInsUp : Form
    {
        public Student StudentInfo 
        {
            get 
            { 
                return new Student(int.Parse(txtStudentid.Text), txtStudentName.Text, txtDepartment.Text); 
            }
            set
            {
                txtStudentid.Text = value.ID.ToString();
                txtStudentName.Text = value.Name;
                txtDepartment.Text = value.Dept;
            } 
        }

        public frmStudentInsUp(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Insert)
            {
                this.Text = "학생정보입력";
                txtStudentid.Enabled = true;
            }
            else
            {
                this.Text = "학생정보수정";
                txtStudentid.Enabled = false;
            }
        }

        private void txtStudentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //유효성체크
            StringBuilder sb = new StringBuilder();            
            if (txtStudentid.Text.Length < 7)
            {
                sb.AppendLine("학번은 7자리로 입력하세요.");
            }

            if (string.IsNullOrEmpty(txtStudentName.Text))
            {
                sb.AppendLine("학생명을 입력하세요.");
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

        private void frmStudentInsUp_Load(object sender, EventArgs e)
        {

        }
    }
}

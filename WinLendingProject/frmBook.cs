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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmBookIns frm = new frmBookIns(OpenMode.Insert);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //입력받은 값으로 DB에 저장
                Book book = frm.BookInfo;
                BookDB db = new BookDB();
                bool result = db.Insert(book);
                db.Dispose();
                if (result)
                {
                    MessageBox.Show("성공적으로 추가되었습니다.");
                    LoadData();
                }
                else { MessageBox.Show("다시 시도하여주십시오"); }
                //
            }
        }

        private void LoadData()
        {
            BookDB db = new BookDB();
            DataTable dt = db.GetAllData();
            db.Dispose();
            dgvMember.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIdx = dgvMember.CurrentRow.Index;

            Book book;

            book.ID = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value);
            book.Name = dgvMember[1, rowIdx].Value.ToString();
            book.Author  = dgvMember[2, rowIdx].Value.ToString();

            //학생정보를 수정폼에 전달해서 오픈
            frmBookIns frm = new frmBookIns (OpenMode.Update);
            frm.BookInfo = book; //set
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //변경된 학생정보를 DB에 수정
                BookDB db = new BookDB();
                bool result = db.Update(frm.BookInfo); //get
                db.Dispose();

                if (result)
                {
                    //MessageBox.Show("수정되었습니다.");
                    //재조회
                    LoadData();
                }
                else
                {
                    MessageBox.Show("다시 수정을 시도하여 주십시오.");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = dgvMember[1, dgvMember.CurrentRow.Index].Value.ToString();

            if (MessageBox.Show($"{name}의 자료를 정말로 삭제할꺼양?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                 int bookid = (int)dgvMember.CurrentRow.Cells[0].Value;

                BookDB db = new BookDB();
                bool result = db.Delete(bookid);
                db.Dispose();

                if (result)
                {
                    //MessageBox.Show("삭제되었습니다.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("다시 삭제를 시도하여 주십시오.");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

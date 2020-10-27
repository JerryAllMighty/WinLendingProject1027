using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLendingProject
{
    public class CommonUtil
    {
        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static void AddGridTextColumn(
                            DataGridView dgv,
                            string headerText,
                            string dataPropertyName,
                            int colWidth = 100,
                            bool visibility = true,
                            DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = textAlign;
            col.Visible = visibility;
            col.ReadOnly = true;

            dgv.Columns.Add(col);
        }
    }
}

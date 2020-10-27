namespace WinLendingProject
{
    partial class frmBookIns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.Label();
            this.lblBooName = new System.Windows.Forms.Label();
            this.lblBookid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(414, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 38);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(269, 308);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 38);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtBookAuthor.Location = new System.Drawing.Point(360, 240);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(175, 25);
            this.txtBookAuthor.TabIndex = 17;
            // 
            // txtBookName
            // 
            this.txtBookName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtBookName.Location = new System.Drawing.Point(360, 172);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(175, 25);
            this.txtBookName.TabIndex = 15;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(360, 104);
            this.txtBookID.MaxLength = 15;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(175, 25);
            this.txtBookID.TabIndex = 13;
            // 
            // txtAuthor
            // 
            this.txtAuthor.AutoSize = true;
            this.txtAuthor.Location = new System.Drawing.Point(265, 248);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(37, 15);
            this.txtAuthor.TabIndex = 18;
            this.txtAuthor.Text = "저자";
            // 
            // lblBooName
            // 
            this.lblBooName.AutoSize = true;
            this.lblBooName.Location = new System.Drawing.Point(265, 176);
            this.lblBooName.Name = "lblBooName";
            this.lblBooName.Size = new System.Drawing.Size(52, 15);
            this.lblBooName.TabIndex = 16;
            this.lblBooName.Text = "책이름";
            // 
            // lblBookid
            // 
            this.lblBookid.AutoSize = true;
            this.lblBookid.Location = new System.Drawing.Point(265, 104);
            this.lblBookid.Name = "lblBookid";
            this.lblBookid.Size = new System.Drawing.Size(52, 15);
            this.lblBookid.TabIndex = 14;
            this.lblBookid.Text = "책번호";
            // 
            // frmBookIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblBooName);
            this.Controls.Add(this.lblBookid);
            this.Name = "frmBookIns";
            this.Text = "frmBookIns";
            this.Load += new System.EventHandler(this.frmBookIns_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label txtAuthor;
        private System.Windows.Forms.Label lblBooName;
        private System.Windows.Forms.Label lblBookid;
    }
}
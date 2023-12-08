using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL
{
    public partial class FQL : Form
    {
        public FQL(string loaitk)
        {
            InitializeComponent();
            this.Loaitk = loaitk;
        }
        string Loaitk = "";

        private void qLPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Loaitk == "Quản lí")
            {
                QLPHONG ql = new QLPHONG();
                this.Hide();
                ql.ShowDialog();
                this.Show();
            }
            else { MessageBox.Show("Bạn không có quyền sử dụng chức năng này"); }
        }

        private void qlTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Loaitk == "Quản lí")
            {
                QLTK qltk = new QLTK();
                this.Hide();
                qltk.ShowDialog();
                this.Show();
            }
            else { MessageBox.Show("Bạn không có quyền sử dụng chức năng này"); }
        }
    
      
        private void FQL_Load(object sender, EventArgs e)
        {
           
            
        }

        private void qLDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Loaitk == "Quản lí")
            {
                QLDV ql = new QLDV();
                this.Hide();
                ql.ShowDialog();
                this.Show();
            }
            else { MessageBox.Show("Bạn không có quyền sử dụng chức năng này"); }
        }

        private void qLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                QLKH ql = new QLKH();
                this.Hide();
                ql.ShowDialog();
                this.Show();
            
            
        }

        private void qlNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Loaitk == "Quản lí")
            {
                QLNV ql = new QLNV();
                this.Hide();
                ql.ShowDialog();
                this.Show();
            }
            else { MessageBox.Show("Bạn không có quyền sử dụng chức năng này"); }
        }

        private void qLHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHOADON ql = new QLHOADON();
            this.Hide();
            ql.ShowDialog();
            this.Show();

        }

        private void qLĐặttrảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLD_TP ql = new QLD_TP();
            this.Hide();
            ql.ShowDialog();
            this.Show();
        }

        private void qLThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTB ql = new QLTB();
            this.Hide();
            ql.ShowDialog();
            this.Show();
        }
    }

}

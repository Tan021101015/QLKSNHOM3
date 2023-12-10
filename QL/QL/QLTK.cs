using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.BUS;
using QL.DAO;
using QL.DTO;
namespace QL
{
    public partial class QLTK : Form
    {
        public QLTK()
        {
            InitializeComponent();
        }
        public void TT_TK()
        {
            DataTable dt = new DataTable();
            dt = QLtaikhoanDAO.TTTK();
            int Sotk = dt.Rows.Count;
            int i;
            for (i = 0; i < Sotk; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][3].ToString());

            }
        }
        public void TTNV()
        {
            DataTable dt = new DataTable();
            dt = QLtaikhoanDAO.TTNV();
            cbmanv.DataSource = dt;
            cbmanv.ValueMember = "manv";
            cbmanv.DisplayMember = "manv";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            QLtaikhoanDTO tk = new QLtaikhoanDTO();
            tk.tentk = txttentk.Text;
            tk.manv = cbmanv.SelectedValue.ToString();
            tk.matkhau = txtmk.Text;
            tk.loaitk = cbloaitk.SelectedItem.ToString();
            QLtaikhoanBUS.Them_TK(tk);
            listView1.Items.Clear();
            TT_TK();
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            TTNV();
            cbloaitk.Items.Add("Quản lí");
            cbloaitk.Items.Add("Nhân viên");
            TT_TK();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLtaikhoanDTO tk = new QLtaikhoanDTO();
            tk.tentk = txttentk.Text;
            tk.manv = cbmanv.SelectedValue.ToString();
            tk.matkhau = txtmk.Text;
            tk.loaitk = cbloaitk.SelectedItem.ToString();
            QLtaikhoanBUS.CapNhat_TK(tk);
            listView1.Items.Clear();
            TT_TK();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QLtaikhoanDTO tk = new QLtaikhoanDTO();
            tk.manv = cbmanv.SelectedValue.ToString();
            QLtaikhoanBUS.Xoa_TK(tk);
            listView1.Items.Clear();
            TT_TK();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txttentk.Text = listView1.SelectedItems[0].SubItems[0].Text;
            cbmanv.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtmk.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cbloaitk.Text = listView1.SelectedItems[0].SubItems[3].Text;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.DAO;
using QL.DTO;
using QL.BUS;

namespace QL
{
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            lvwkh.Items.Clear();
            DataTable dt = new DataTable();
            string sql = "Select*from Khachhang";
            dt = ketNoi.docDL(sql);
            int sl = dt.Rows.Count;
            for (int i = 0; i < sl; i++)
            {
                lvwkh.Items.Add(dt.Rows[i][0].ToString());
                lvwkh.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvwkh.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                lvwkh.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lvwkh.Items[i].SubItems.Add(dt.Rows[i][5].ToString());
                lvwkh.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
            }
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            loaddata();
            txtmkh.ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int vt = lvwkh.SelectedIndices[0];
            txtmkh.Text = lvwkh.Items[vt].SubItems[0].Text;
            txttenkh.Text = lvwkh.Items[vt].SubItems[1].Text;
            if (lvwkh.Items[vt].SubItems[2].Text == "Nam")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            txtdiachi.Text = lvwkh.Items[vt].SubItems[3].Text;
            txtsdt.Text = lvwkh.Items[vt].SubItems[4].Text;
            dateTimePicker1.Text = lvwkh.Items[vt].SubItems[5].Text;

        }
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KhachhangDAO.tt_maKHMax();
            string makh = dt.Rows[0][0].ToString();
            txtmkh.Text = "KH" + (Convert.ToInt32(makh.Substring(2, makh.Length - 2)) + 1).ToString("00");
        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {
            KhachhangDTO kh = new KhachhangDTO();
            kh.makh = txtmkh.Text;
            kh.tenkh = txttenkh.Text;
            if (radioButton1.Checked == true)
            {
                kh.gioitinh = "Nam";
            }
            else
            {
                kh.gioitinh = "Nữ";
            }
            kh.diachi = txtdiachi.Text;
            kh.sodt = txtsdt.Text;
            kh.ngaysinh = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            KhachhangBUS.Luu_KH(kh);
            loaddata();
        }

        private void btncapnhat_Click_1(object sender, EventArgs e)
        {
            KhachhangDTO kh = new KhachhangDTO();
            kh.makh = txtmkh.Text;
            kh.tenkh = txttenkh.Text;
            if (radioButton1.Checked == true)
            {
                kh.gioitinh = "Nam";
            }
            else
            {
                kh.gioitinh = "Nữ";
            }
            kh.diachi = txtdiachi.Text;
            kh.sodt = txtsdt.Text;
            kh.ngaysinh = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            KhachhangBUS.CapNhat_KH(kh);
            loaddata();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            KhachhangDTO kh = new KhachhangDTO();
            kh.makh = txtmkh.Text;
            kh.tenkh = txttenkh.Text;
            if (radioButton1.Checked == true)
            {
                kh.gioitinh = "Nam";
            }
            else
            {
                kh.gioitinh = "Nữ";
            }
            kh.diachi = txtdiachi.Text;
            kh.sodt = txtsdt.Text;
            kh.ngaysinh = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            KhachhangBUS.Xoa_KH(kh);
            loaddata();
        }
    }
}


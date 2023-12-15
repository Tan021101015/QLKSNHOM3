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

namespace QL
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }
        void laydulieu()
        {
            listView1.Items.Clear();
            DataTable dt = new DataTable();
            string sql = "select *from Nhanvien ";
            dt = DAO.ketNoi.docDL(sql);
            int sl = dt.Rows.Count;
            for (int i = 0; i < sl; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        private void QLNV_Load(object sender, EventArgs e)
        {
            laydulieu();
            txtmanv.ReadOnly = true;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = " select top 1 makh from Khachhang order by makh desc";
            dt = ketNoi.docDL(sql);
            string makh = dt.Rows[0][0].ToString();
            txtmanv.Text = "NV" + (Convert.ToInt32(makh.Substring(2, makh.Length - 2)) + 1).ToString("00");
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if(radioButton1.Checked==true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            string sql = "insert into Nhanvien( manv,tennv,ngaysinh ,  gioitinh, sodt ,diachi ) values('"+txtmanv.Text+"',N'"+txttennv.Text+"','"+dateTimePicker1.Value.ToString("MM/dd/yyyy")+"',N'" + gioitinh+ "','"+txtsdt.Text+"',N'"+txtdiachi.Text+"')";
            DAO.ketNoi.docDL(sql);
            laydulieu();
            DataTable dt = new DataTable();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            string sqltk = " delete from Taikhoan where manv = '" + txtmanv.Text + "'";
            string sql = " delete from Nhanvien where manv = '" + txtmanv.Text + "'";
            DAO.ketNoi.docDL(sqltk);
            DAO.ketNoi.docDL(sql);

            laydulieu();
            DataTable dt = new DataTable();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (radioButton1.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            string sql = "Update Nhanvien set manv ='" +txtmanv.Text + "',tennv=N'" +txttennv.Text + "',ngaysinh='" + dateTimePicker1.Text + "',gioitinh =N'" + gioitinh + "',sodt='" + txtsdt.Text + "',diachi=N'" + txtdiachi.Text + "' where (manv ='" + txtmanv.Text + "')";
            DAO.ketNoi.docDL(sql);
            laydulieu();
            DataTable dt = new DataTable();
           //h
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int vt = listView1.SelectedIndices[0];
            txtmanv.Text = listView1.Items[vt].SubItems[0].Text;
            txttennv.Text = listView1.Items[vt].SubItems[1].Text;
            dateTimePicker1.Text= listView1.Items[vt].SubItems[2].Text;
            if (listView1.Items[vt].SubItems[3].Text == "Nam")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            txtmanv.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txttennv.Text= listView1.SelectedItems[0].SubItems[1].Text;
            txtdiachi.Text= listView1.SelectedItems[0].SubItems[4].Text;
            txtsdt.Text= listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    


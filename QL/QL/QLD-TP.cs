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
using QL.BUS;
using QL.DTO;
namespace QL
{
    public partial class QLD_TP : Form
    {
        public QLD_TP()
        {
            InitializeComponent();
        }

        private void QLD_TP_Load(object sender, EventArgs e)
        {
            cbloaiphong.Items.Add("Đơn");
            cbloaiphong.Items.Add("Đôi");
            cbloaiphong.Items.Add("Vip Đơn");
            cbloaiphong.Items.Add("Vip Đôi");
            cbloaiphong.Items.Add("Phòng gia đình");
            TT_P();
            LoadDLComboBox();
            
            LoadDLComboBoxdichvu();
        }
        public void TT_P()
        {
            DataTable dt = new DataTable();
            dt = QLdattraphongDAO.TTdtp();
            int Sotk = dt.Rows.Count;
            int i;
            for (i = 0; i < Sotk; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][4].ToString());

            }
        }
        public void LoadDLComboBox()
        {
            DataTable dt = new DataTable();
            dt = QLdattraphongDAO.TTkhachhang();
            cbmakh.DataSource = dt;
            cbmakh.ValueMember = "makh";
            cbmakh.DisplayMember = "makh";
        }
       
        public void LoadDLComboBoxdichvu()
        {
            DataTable dt = new DataTable();
            dt = QLdattraphongDAO.TTdichvu();
            cbmadv.DataSource = dt;
            cbmadv.ValueMember = "madv";
            cbmadv.DisplayMember = "tendv";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLdattraphongDAO.capnhatphong2(cbmaphong.Text);
            QLdattraphongDTO p = new QLdattraphongDTO();
            p.makh = cbmakh.SelectedValue.ToString();
            p.maphong = cbmaphong.SelectedItem.ToString();
            p.madv = cbmadv.SelectedValue.ToString();
            p.ngaydat = datedat.Value.ToString("MM/dd/yyyy");
            p.ngaytra = datetra.Value.ToString("MM/dd/yyyy");
            QLdattraphongBUS.them(p);
            listView1.Items.Clear();
            TT_P();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            QLdattraphongDTO p = new QLdattraphongDTO();
            p.makh = cbmakh.SelectedValue.ToString();
            p.maphong = cbmaphong.SelectedItem.ToString();
            p.madv = cbmadv.SelectedValue.ToString();
            p.ngaydat = datedat.Value.ToString("MM/dd/yyyy");
            p.ngaytra = datetra.Value.ToString("MM/dd/yyyy");
            QLdattraphongBUS.capnhat(p);
            listView1.Items.Clear();
            TT_P();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QLdattraphongDAO.capnhatphong(cbmaphong.Text);
            QLdattraphongDTO p = new QLdattraphongDTO();
            p.makh = cbmakh.Text;
            QLdattraphongBUS.xoa(p);
            listView1.Items.Clear();
            TT_P();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            cbmakh.Text = listView1.SelectedItems[0].SubItems[0].Text;
            cbmadv.Text = listView1.SelectedItems[0].SubItems[1].Text;
            cbmaphong.SelectedValue = listView1.SelectedItems[0].SubItems[2].Text;
            datedat.Text = listView1.SelectedItems[0].SubItems[3].Text;
            datetra.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void cbloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmaphong.Text = "";
            cbmaphong.Items.Clear();
            DataTable dt = new DataTable();
            dt = QLdattraphongDAO.TTdatphong(cbloaiphong.Text);
            int sldv = dt.Rows.Count;
            for (int i = 0; i < sldv; i++)
            {
                cbmaphong.Items.Add(dt.Rows[i]["maphong"].ToString());
            }
        }
    }
}

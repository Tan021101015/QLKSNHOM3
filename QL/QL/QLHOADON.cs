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
    public partial class QLHOADON : Form
    {
        public QLHOADON()
        {
            InitializeComponent();
        }
        public void tt_HoaDon()
        {
            lvHoaDon.Items.Clear();
            DataTable dtHD = new DataTable();
            dtHD = hoaDonDAO.tt_hoadon();
            int slhd = dtHD.Rows.Count;
            for(int i = 0; i < slhd; i++)
            {
                lvHoaDon.Items.Add(dtHD.Rows[i]["mahd"].ToString());
                lvHoaDon.Items[i].SubItems.Add(dtHD.Rows[i]["makh"].ToString());
                lvHoaDon.Items[i].SubItems.Add(dtHD.Rows[i]["ngaydat"].ToString());
                lvHoaDon.Items[i].SubItems.Add(dtHD.Rows[i]["ngaytra"].ToString());
                lvHoaDon.Items[i].SubItems.Add(dtHD.Rows[i]["madv"].ToString());
                float gia = float.Parse(dtHD.Rows[i]["tongtien"].ToString());
                lvHoaDon.Items[i].SubItems.Add(gia.ToString("#,###") + "VND");
                //lvHoaDon.Items[i].SubItems.Add(dtHD.Rows[i]["tongtien"].ToString());
                lvHoaDon.Items[i].SubItems.Add(dtHD.Rows[i]["soluong"].ToString());
      
                

            }
        }
        public void ttkh()
        {
            DataTable dt = new DataTable();
            dt = hoaDonDAO.tt_kh();
            cbmakh.DataSource = dt;
            cbmakh.DisplayMember = "makh";
            cbmakh.ValueMember = "makh";
        }

        private void QLHOADON_Load(object sender, EventArgs e)
        {
           
            tt_HoaDon();
            ttkh();
        }

        private void lvHoaDon_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = lvHoaDon.SelectedItems[0].SubItems[0].Text;
            cbmakh.Text = lvHoaDon.SelectedItems[0].SubItems[1].Text;
            dtNgayDat.Text = lvHoaDon.SelectedItems[0].SubItems[2].Text;
            dtNgayTra.Text = lvHoaDon.SelectedItems[0].SubItems[3].Text;
            txtDonGia.Text= lvHoaDon.SelectedItems[0].SubItems[5].Text;
            txtSL.Text= lvHoaDon.SelectedItems[0].SubItems[6].Text;
            DataTable dtDichVu = new DataTable();
            dtDichVu = hoaDonDAO.tt_dichvuTheoMaDV(lvHoaDon.SelectedItems[0].SubItems[4].Text);
            cbDichVu.Text = dtDichVu.Rows[0][1].ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            /*DataTable dtKH = new DataTable();
            dtKH = hoaDonDAO.tt_maKHMax(); 
            string makh = dtKH.Rows[0][0].ToString();
            txtMaKH.Text = "KH" + (Convert.ToInt32(makh.Substring(2, makh.Length - 2)) + 1).ToString("00");
            */
            DataTable dtHD = new DataTable();
            dtHD = hoaDonDAO.tt_maHDMax();
            string mahd = dtHD.Rows[0][0].ToString();
            txtMaHD.Text = "HD" + (Convert.ToInt32(mahd.Substring(2, mahd.Length - 2)) + 1).ToString("00");
          
        }

        private void btLuuTru_Click(object sender, EventArgs e)
        {
            QLdattraphongDAO.capnhatphong(cbmaphong.Text);
            hoaDontDTO hd = new hoaDontDTO();
            hd.mahd = txtMaHD.Text;
            hd.makh = cbmakh.SelectedValue.ToString();

            hd.madv = cbDichVu.SelectedItem.ToString();
            hd.soluong = txtSL.Text;
            string input = txtDonGia.Text;
            string output = (int.Parse(input.Replace(",", "").Replace("VND", ""))).ToString();
            hd.tongtien = output.ToString();

            //hd.tongtien = txtDonGia.Text;
            hd.ngaydat = dtNgayDat.Value.ToString("MM/dd/yyyy");
            hd.ngaytra = dtNgayTra.Value.ToString("MM/dd/yyyy");
            hoaDonBUS.Luu_HD(hd);
            tt_HoaDon();
            hoaDonDAO.xoa_phong(cbmaphong.Text);
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            hoaDontDTO hd = new hoaDontDTO();
            hd.mahd = txtMaHD.Text;
            hd.makh = cbmakh.SelectedValue.ToString();
            DataTable dtDichVu = new DataTable();
            dtDichVu = hoaDonDAO.tt_dichvuTheotenDV(cbDichVu.Text);
            hd.madv = dtDichVu.Rows[0][0].ToString();
            hd.soluong = txtSL.Text;
            string input = txtDonGia.Text;
            string output = (int.Parse(input.Replace(",", "").Replace("VND", ""))).ToString();
            hd.tongtien = output.ToString();
            //hd.tongtien = txtDonGia.Text;
            hd.ngaydat = dtNgayDat.Value.ToString("MM/dd/yyyy");
            hd.ngaytra = dtNgayTra.Value.ToString("MM/dd/yyyy");
            hoaDonBUS.CapNhat_HD(hd);
            tt_HoaDon();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            hoaDontDTO hd = new hoaDontDTO();
            hd.mahd = txtMaHD.Text;
            
            hoaDonBUS.Xoa_HD(hd);
            tt_HoaDon();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hoaDonDAO.tt_dattra(cbmakh.Text, cbmaphong.Text, cbDichVu.Text);
            dtNgayDat.Text = dt.Rows[0]["ngaydat"].ToString();
            dtNgayTra.Text = dt.Rows[0]["ngaytra"].ToString();

            DataTable tong = new DataTable();
            tong = hoaDonDAO.tt_tonggia(cbmakh.Text, cbmaphong.Text, cbDichVu.Text);
            txtDonGia.Text = tong.Rows[0]["tong"].ToString();

        }

        private void cbmakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmaphong.Text = "";
            cbmaphong.Items.Clear();
            DataTable dt = new DataTable();
            dt = hoaDonDAO.tt_phong(cbmakh.Text);
            int sldv = dt.Rows.Count;
            for (int i = 0; i < sldv; i++)
            {
                cbmaphong.Items.Add(dt.Rows[i]["maphong"].ToString());
            }
               
        }

        private void cbmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDichVu.Text = "";
            cbDichVu.Items.Clear();
            DataTable dt = new DataTable();
            dt = hoaDonDAO.tt_dvphong(cbmakh.Text, cbmaphong.Text);
            int sldv = dt.Rows.Count;
            for (int i = 0; i < sldv; i++)
            {
                cbDichVu.Items.Add(dt.Rows[i]["madv"].ToString());
            }


           
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

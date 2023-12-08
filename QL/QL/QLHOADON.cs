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
                lvHoaDon.Items[i].SubItems.Add(dtHD.Rows[i]["tongtien"].ToString());
                lvHoaDon.Items[i].SubItems.Add(dtHD.Rows[i]["soluong"].ToString());

            }
        }
        public void ttdichvu()
        {
            DataTable dt = new DataTable();
            dt = hoaDonDAO.tt_dichvu();
            cbDichVu.DataSource = dt;
            cbDichVu.DisplayMember = "tendv";
            cbDichVu.ValueMember = "madv";
        }

        private void QLHOADON_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QLdattraphongDAO.TTkhachhang();
            cbmakh.DataSource = dt;
            cbmakh.ValueMember = "makh";
            cbmakh.DisplayMember = "makh";
            tt_HoaDon();
            ttdichvu();
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
            hoaDontDTO hd = new hoaDontDTO();
            hd.mahd = txtMaHD.Text;
            hd.makh = cbmakh.SelectedValue.ToString();
            hd.madv = cbDichVu.SelectedValue.ToString();
            hd.soluong = txtSL.Text;
            hd.tongtien = txtDonGia.Text;
            hd.ngaydat = dtNgayDat.Value.ToString("MM/dd/yyyy");
            hd.ngaytra = dtNgayTra.Value.ToString("MM/dd/yyyy");
            hoaDonBUS.Luu_HD(hd);
            tt_HoaDon();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            hoaDontDTO hd = new hoaDontDTO();
            hd.mahd = txtMaHD.Text;
            hd.makh = cbmakh.SelectedValue.ToString();
            hd.madv = cbDichVu.SelectedValue.ToString();
            hd.soluong = txtSL.Text;
            hd.tongtien = txtDonGia.Text;
            hd.ngaydat = dtNgayDat.Value.ToString("MM/dd/yyyy");
            hd.ngaytra = dtNgayTra.Value.ToString("MM/dd/yyyy");
            hoaDonBUS.CapNhat_HD(hd);
            tt_HoaDon();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            hoaDontDTO hd = new hoaDontDTO();
            hd.mahd = txtMaHD.Text;
            hd.makh = cbmakh.SelectedItem.ToString();
            hd.madv = cbDichVu.SelectedValue.ToString();
            hd.soluong = txtSL.Text;
            hd.tongtien = txtDonGia.Text;
            hd.ngaydat = dtNgayDat.Value.ToString("MM/dd/yyyy");
            hd.ngaytra = dtNgayTra.Value.ToString("MM/dd/yyyy");
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
    }
}

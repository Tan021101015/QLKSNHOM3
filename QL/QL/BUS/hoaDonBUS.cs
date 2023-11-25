using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL.DAO;
using QL.DTO;
using System.Windows.Forms;
namespace QL.BUS
{
    class hoaDonBUS
    {
        public static void Luu_HD(hoaDontDTO hd)
        {
            try
            {
                hoaDonDAO.luu_hoadon(hd);
            }
            catch (Exception)
            {
                MessageBox.Show("Luu hoa don khong thanh cong!");

            }
        }
        public static void CapNhat_HD(hoaDontDTO hd)
        {
            if (MessageBox.Show("Ban co muon cap nhat hoa don nay?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    hoaDonDAO.capnhat_hoadon(hd);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cap nhat hoa don khong thanh cong!");

                }
            }
        }
        public static void Xoa_HD(hoaDontDTO hd)
        {
            if (MessageBox.Show("Ban co muon xoa hoa don nay?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    hoaDonDAO.xoa_hoadon(hd);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật hóa đơn không thành công!");
                    //cap nhat
                }
            }
        }
    }
}

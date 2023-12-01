using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.DAO;
using QL.DTO;

namespace QL.BUS
{
    class KhachhangBUS
    {
        public static void Luu_KH(KhachhangDTO kh)
        {
            try
            {
                KhachhangDAO.luu_khachhang(kh);
            }
            catch (Exception)
            {
                MessageBox.Show("Luu khach hang khong thanh cong!");

            }
        }
        public static void CapNhat_KH(KhachhangDTO kh)
        {
            if (MessageBox.Show("Ban co muon cap nhat khach hang nay khong?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    KhachhangDAO.capnhat_khachhang(kh);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cap nhat khach hang khong thanh cong!");

                }
            }
        }
        public static void Xoa_KH(KhachhangDTO kh)
        {
            if (MessageBox.Show("Ban co muon xoa khach hang nay?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    KhachhangDAO.xoa_khachhang(kh);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoa khach hang không thành công!");

                }
            }
        }
    }
}

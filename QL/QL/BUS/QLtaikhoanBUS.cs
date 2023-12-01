using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL.DTO;
using QL.DAO;
using System.Windows.Forms;
namespace QL.BUS
{
    class QLtaikhoanBUS
    {
        public static void Them_TK(QLtaikhoanDTO tk)
        {
            try
            {
                QLtaikhoanDAO.Them_TK(tk);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm  không thành công do mã nhân viên sai hoặc chưa có nhân viên này !!!! ");
            }
        }

        public static void Xoa_TK(QLtaikhoanDTO tk)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    QLtaikhoanDAO.Xoa_TK(tk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa tài khoản không thành công !!!");
                }
            }
        }

        public static void CapNhat_TK(QLtaikhoanDTO tk)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    QLtaikhoanDAO.CapNhat_TK(tk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật tài khoản không thành công !!!");
                }
            }
        }
    }
}

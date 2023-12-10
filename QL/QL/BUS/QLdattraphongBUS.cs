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
    class QLdattraphongBUS
    {
        public static void them(QLdattraphongDTO p)
        {
            try
            {
                QLdattraphongDAO.them(p);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm  không thành công do trùng phòng!!!! ");
            }
        }

        public static void xoa(QLdattraphongDTO p)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa  ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    QLdattraphongDAO.xoa(p);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa không thành công !!!");
                }
            }
        }

        public static void capnhat(QLdattraphongDTO p)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    QLdattraphongDAO.capnhat(p);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật không thành công !!!");
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL.DAO;
using QL.DTO;
using System.Windows.Forms;

namespace QL.BUS
{
    class QLTBBUS
    {
        public static void Them_TB(QLTBDTO tb)
        {
            try
            {
                QLTBDAO.Them_TB(tb);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm  không thành công do mã thiết bị sai hoặc chưa có thiết bị này !!!! ");
            }
        }
        public static void Xoa_TB(QLTBDTO tb)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thiết bị này ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    QLTBDAO.Xoa_TB(tb);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thiết bị không thành công !!!");
                }
            }
        }

        public static void CapNhat_TB(QLTBDTO tb)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật bị này ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    QLTBDAO.CapNhat_TB(tb);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật thiết bị không thành công !!!");
                }
            }
        }
    }
}


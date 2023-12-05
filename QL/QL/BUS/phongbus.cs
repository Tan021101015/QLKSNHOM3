using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QL.DTO;
using QL.DAO;

namespace QL.BUS
{
    class phongbus
    {
        public static void themphong(phongdto kh)
        {
            try
            {
                phongdao.tt_mapMax(kh);
            }
            catch (Exception)
            {
                MessageBox.Show("Them khach hang khong thanh cong!");

            }
        }
        public static void CapNhat_phong(phongdto kh)
        {
            if (MessageBox.Show("Ban co muon cap nhat phong nay khong?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    phongdao.capnhatphong(kh);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cap nhat phong khong thanh cong!");

                }
            }
        }
        public static void xoa_phong(phongdto kh)
        {
            if (MessageBox.Show("Ban co muon xoa phong nay khong?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    phongdao.xoaphong(kh);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoa phong khong thanh cong!");
                }
            }
        }
    }
}

    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL.DTO;

namespace QL.DAO
{
    class KhachhangDAO
    {
        public static DataTable tt_maKHMax()
        {
            string sql = " select top 1 makh from Khachhang order by makh desc";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static void luu_khachhang(KhachhangDTO kh)
        {
            string sql = "INSERT INTO Khachhang(makh, diachi, tenkh, ngaysinh, gioitinh, sodt)VALUES(N'" + kh.makh + "', N'" + kh.diachi + "', N'" + kh.tenkh + "', '" + kh.ngaysinh + "', N'" + kh.gioitinh + "', '" + kh.sodt + "')";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void capnhat_khachhang(KhachhangDTO kh)
        {
            string sql = "update Khachhang set tenkh=N'" + kh.tenkh + "',diachi=N'" + kh.diachi + "',ngaysinh='" + kh.ngaysinh + "',gioitinh=N'" + kh.gioitinh + "',sodt='" + kh.sodt + "'where makh=N'" + kh.makh + "'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void xoa_khachhang(KhachhangDTO kh)
        {
            string sql = " delete from Khachhang where makh=N'" + kh.makh + "'";
            ketNoi.thucThiTruyVan(sql);
        }
    }
}


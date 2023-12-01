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
            string sql = "INSERT INTO Khachhang(makh, tenkh, gioitinh, diachi, sodt, ngaysinh) VALUES('" + kh.makh + "', N'" + kh.tenkh + "', N'" + kh.gioitinh + "',N '" + kh.diachi + "', '" + kh.sodt + "', '" + kh.ngaysinh + "')";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void capnhat_khachhang(KhachhangDTO kh)
        {
            string sql = " update Khachhang set tenkh=N'" + kh.tenkh + "',gioitinh=N'" + kh.gioitinh + "',diachi=N'" + kh.diachi + ",sodt='" + kh.sodt + "',ngaysinh='" + kh.ngaysinh + "' where makh=N'" + kh.makh + "'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void xoa_khachhang(KhachhangDTO kh)
        {
            string sql = " delete from Khachhang where makh=N'" + kh.makh + "'";
            ketNoi.thucThiTruyVan(sql);
        }
    }
}


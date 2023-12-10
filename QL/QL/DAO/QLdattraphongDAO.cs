using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL.DTO;
namespace QL.DAO
{
    class QLdattraphongDAO
    {
        public static DataTable TTdtp()
        {
            DataTable dt = new DataTable();
            string sql = "select * from Dattra";
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable TTkhachhang()
        {
            DataTable dt = new DataTable();
            string sql = "select * from Khachhang";
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable TTdichvu()
        {
            DataTable dt = new DataTable();
            string sql = "select * from Dichvu";
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable TTphong()
        {
            DataTable dt = new DataTable();
            string sql = "select * from Phong";
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static void them(QLdattraphongDTO p)
        {
            string sql = "INSERT INTO Dattra VALUES('" + p.makh + "', '" + p.maphong + "', '" + p.madv + "','" + p.ngaydat + "','" + p.ngaytra + "')";
            ketNoi.thucThiTruyVan(sql);
        }

        public static void capnhat(QLdattraphongDTO p)
        {
            string sql = " update Dattra set maphong='" + p.maphong + "',madv='" + p.madv + "',ngaydat='" + p.ngaydat + "',ngaytra='" + p.ngaytra + "' where makh='" + p.makh + "'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void xoa(QLdattraphongDTO p)
        {
            string sql = " delete from Dattra where maphong=N'" + p.maphong + "'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static DataTable TTdatphong(string loaiphong)
        {
            DataTable dt = new DataTable();
            string sql = "select maphong from Phong where loaiphong=N'"+loaiphong+"' and tinhtrang=N'Còn phòng'";
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static void capnhatphong(string maphong)
        {
            string sql = "update Phong set tinhtrang=N'Còn phòng' where maphong='" + maphong + "'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void capnhatphong2(string maphong)
        {
            string sql = "update Phong set tinhtrang=N'Hết phòng' where maphong='" + maphong + "'";
            ketNoi.thucThiTruyVan(sql);
        }
    }
}

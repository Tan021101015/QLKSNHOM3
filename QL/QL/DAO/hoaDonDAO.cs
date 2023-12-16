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
    class hoaDonDAO
    {
        public static DataTable tt_hoadon()
        {
            string sql = "select *from Hoadon";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable tt_kh()
        {
            string sql = "select *from Khachhang";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable tt_dv()
        {
            string sql = "select *from Dichvu";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable tt_dichvuTheoMaDV(string madv)
        {
            string sql = "select *from Dichvu where madv=N'"+madv+"'";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable tt_dichvuTheotenDV(string tendv)
        {
            string sql = "select *from Dichvu where tendv=N'" + tendv + "'";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable tt_maHDMax()
        {
            string sql = " select top 1 mahd from Hoadon order by mahd desc";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable tt_maKHMax()
        {
            string sql = " select top 1 makh from Khachhang order by makh desc";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static void luu_hoadon(hoaDontDTO hd)
        {
            string sql = "INSERT INTO Hoadon(mahd, makh, madv, soluong, tongtien, ngaydat, ngaytra) VALUES(N'"+hd.mahd+"', N'"+hd.makh+"', N'"+hd.madv+"', "+hd.soluong+", "+hd.tongtien+", '"+hd.ngaydat+"', '"+hd.ngaytra+"')";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void capnhat_hoadon(hoaDontDTO hd)
        {
            string sql = " update Hoadon set makh=N'"+hd.makh+"',madv=N'"+hd.madv+"',soluong="+hd.soluong+",tongtien="+hd.tongtien+",ngaydat='"+hd.ngaydat+"',ngaytra='"+hd.ngaytra+"' where mahd=N'"+hd.mahd+"'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void xoa_hoadon(hoaDontDTO hd)
        {
            string sql = " delete from Hoadon where mahd=N'"+hd.mahd+"'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static DataTable tt_phong(string makh)
        {
            string sql = " select maphong from Dattra where makh='" + makh+"'";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable tt_dvphong(string makh,string maphong)
        {
            string sql = " select madv from Dattra where makh='" + makh + "' and maphong='" + maphong + "'";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable tt_dattra(string makh, string maphong, string madv)
        {
            string sql = " select ngaydat,ngaytra from Dattra where makh='" + makh + "' and madv='" + madv + "' and maphong='" + maphong + "'";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable tt_tonggia(string makh, string maphong, string madv)
        {
            string sql = " select dongia + giadv as tong  from Dichvu dv,Phong p, Dattra dt where dt.makh='" + makh + "' and dv.madv='" + madv + "' and p.maphong='" + maphong + "' 		";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable xoa_phong(string maphong)
        {
            string sql = " delete from Dattra where maphong=N'" + maphong + "'";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL.DTO;

namespace QL.DAO
{
    class QLTBDAO
    {
        public static DataTable TTTB()
        {
            string sql = "select * from Thietbi";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable TTPhong()
        {
            string sql = "select * from Phong";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static void Them_TB(QLTBDTO tb)
        {
            string sql = "INSERT INTO Thietbi(matb,maphong,tentb, gia) VALUES(N'" + tb.matb + "',N'" + tb.maphong + "',N'" + tb.tentb + "','" + tb.gia + "')";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void CapNhat_TB(QLTBDTO tb)
        {
            string sql = "Update Thietbi SET maphong='" + tb.maphong + "',tentb=N'" + tb.tentb + "',gia='" + tb.gia + "' where matb ='" + tb.matb + "'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void Xoa_TB(QLTBDTO tb)
        {
            string sql = "Delete from Thietbi where matb='" + tb.matb + "'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static DataTable Matbln()
        {
            string sql = "select top 1 matb from Thietbi order by matb desc";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QL.DTO;

namespace QL.DAO
{
    class phongdao
    {
        public static DataTable tt_phong()
        {
            string sql = "select *from Phong";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable tt_maphongln()
        {
            string sql = " select top 1 maphong from Phong order by maphong desc";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static void tt_mapMax(phongdto kh)
        {
            string sql = " insert into Phong (maphong,tenphong,loaiphong,tinhtrang,dongia) values ('" + kh.maphong + "','" + kh.tenphong + "','" + kh.loaiphong + "','" + kh.tinhtrang + "','" + kh.dongia + "')";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void capnhatphong(phongdto kh)
        {
            string sql = "update Phong set tenphong='" + kh.tenphong + "',loaiphong='" + kh.loaiphong + "',tinhtrang='" + kh.tinhtrang + "',dongia='" + kh.dongia + "'where maphong='" + kh.maphong + "'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void xoaphong(phongdto kh)
        {
            string sql = "delete from Phong where maphong='" + kh.maphong + "'";
            ketNoi.thucThiTruyVan(sql);
        }
    }
}

    


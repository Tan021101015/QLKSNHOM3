using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL.DTO;
namespace QL.DAO
{
    class QLtaikhoanDAO
    {
        public static DataTable TTNV()
        {
            string sql = "SELECT Nhanvien.*FROM Nhanvien LEFT JOIN Taikhoan ON Nhanvien.manv = Taikhoan.manv WHERE Taikhoan.manv IS NULL;";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable TTTK()
        {
            string sql = "select * from Taikhoan";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static void Them_TK(QLtaikhoanDTO tk)
        {
            string sql = "INSERT INTO Taikhoan VALUES(N'" + tk.tentk + "',N'" + tk.manv + "','" + tk.matkhau + "',N'" + tk.loaitk + "')";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void CapNhat_TK(QLtaikhoanDTO tk)
        {
            string sql = "Update Taikhoan SET tentk = N'" + tk.tentk + "' ,matkhau= '" + tk.matkhau + "',loaitk=N'" + tk.loaitk + "' where manv='" + tk.manv + "'";
            ketNoi.thucThiTruyVan(sql);
        }
        public static void Xoa_TK(QLtaikhoanDTO tk)
        {
            string sql = "Delete from Taikhoan where manv='" + tk.manv + "'";
            ketNoi.thucThiTruyVan(sql);
        }

    }
}

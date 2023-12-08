using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL.DTO;
namespace QL.DAO
{
    class QLDVDAO
    {
        public static DataTable ttdv()
        {
            string sql = "select madv,tendv,giadv from Dichvu";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable them(QLDVDTO dv)
        {
            string sql = "INSERT INTO Dichvu(madv, tendv, giadv)VALUES('" + dv.madv + "', N'" + dv.tendv + "','" + dv.giadv + "')";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable cn(QLDVDTO dv)
        {
            string sql = "UPDATE Dichvu SET tendv=N'" + dv.tendv + "' ,giadv='" + dv.giadv + "' WHERE madv='" + dv.madv + "'";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable xoa(QLDVDTO dv)
        {
            string sql = "DELETE FROM Dichvu WHERE madv='" + dv.madv + "'";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
        public static DataTable MaDvLN()
        {
            string sql = "select top 1 madv from Dichvu order by madv desc";
            DataTable dt = new DataTable();
            dt = ketNoi.docDL(sql);
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QL.DAO
{
    class ketNoi
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void moKN()
        {
            try
            {
                string sql = @"Data Source=LAPTOP-6GCI30QH\SQLEXPRESS01;Initial Catalog=qlks1;Integrated Security=True";
                cnn.ConnectionString = sql;
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ket noi khong thanh cong!");

            }
        }
        public static void dongKN()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public static DataTable docDL(string sql)
        {
            moKN();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dongKN();
            return dt;
        }
        public static void thucThiTruyVan(string sql)
        {
            moKN();
            SqlCommand cd = new SqlCommand(sql, cnn);
            cd.ExecuteNonQuery();
            dongKN();
        }
    }
}

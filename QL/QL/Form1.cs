using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLKSNHOM3;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Taikhoan where tentk = '" + textBox1.Text + "'and matkhau ='" + textBox2.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               FQL ql = new FQL(dt.Rows[0][3].ToString());
               
                this.Hide();
                ql.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công !!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            else { textBox2.PasswordChar = '*'; }
        }
    }
    }


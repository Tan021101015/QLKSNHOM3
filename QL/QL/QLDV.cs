using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.DTO;
namespace QL
{
    public partial class QLDV : Form
    {
        public QLDV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DAO.QLDVDAO.MaDvLN();
            string ma = dt.Rows[0][0].ToString();
            textBox1.Text = "DV" + (Convert.ToInt32(ma.Substring(2, ma.Length - 2)) + 1).ToString("00");
        }
        public void TT_DV()
        {
            DataTable dt = new DataTable();
            dt = DAO.QLDVDAO.ttdv();
            int sldt = dt.Rows.Count;
            for (int i = 0; i < sldt; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                float gia = float.Parse( dt.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(gia.ToString("#,###")+"VND");
               

                //textBox1.Text = dt.Rows[i][0].ToString();
                //textBox2.Text = dt.Rows[i][1].ToString();
                //textBox3.Text = dt.Rows[i][2].ToString();
            }

        }
        private void QLDV_Load(object sender, EventArgs e)
        {
            TT_DV();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QLDVDTO dv = new QLDVDTO();
            dv.madv = textBox1.Text;
            dv.tendv = textBox2.Text;
            string input = textBox3.Text;
            string output = (int.Parse(input.Replace(",", "").Replace("VND", ""))).ToString();
            dv.giadv = output.ToString();

            DAO.QLDVDAO.them(dv);
            listView1.Items.Clear();
            TT_DV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLDVDTO dv = new QLDVDTO();
            dv.madv = textBox1.Text;
            dv.tendv = textBox2.Text;
            string input = textBox3.Text;
            string output = (int.Parse(input.Replace(",", "").Replace("VND", ""))).ToString();
            dv.giadv = output.ToString();
            
            DAO.QLDVDAO.cn(dv);
            listView1.Items.Clear();
            TT_DV();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            QLDVDTO dv = new QLDVDTO();
            dv.madv = textBox1.Text;
            DAO.QLDVDAO.xoa(dv);
            listView1.Items.Clear();
            TT_DV();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}

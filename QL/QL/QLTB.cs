using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.DAO;
using QL.BUS;
using QL.DTO;
namespace QL
{
    public partial class QLTB : Form
    {
        public QLTB()
        {
            InitializeComponent();
        }

        private void QLTB_Load(object sender, EventArgs e)
        {
            TT_TB();
            TTPHONG();
        }
        public void TT_TB()
        {
            DataTable dt = new DataTable();
            dt = QLTBDAO.TTTB();
            int matb = dt.Rows.Count;
            int i;
            for (i = 0; i < matb; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][3].ToString());

            }
        }
        public void TTPHONG()
        {
            DataTable dt = new DataTable();
            dt = QLTBDAO.TTPhong();
            cbmap.DataSource = dt;
            cbmap.ValueMember = "maphong";
            cbmap.DisplayMember = "maphong";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = QLTBDAO.Matbln();
            string ma = dt.Rows[0][0].ToString();
            txtma.Text = "TB" + (Convert.ToInt32(ma.Substring(2, ma.Length - 2)) + 1).ToString("00");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QLTBDTO tb = new QLTBDTO();
            tb.matb = txtma.Text;
            tb.maphong = cbmap.SelectedValue.ToString();
            tb.tentb = txttentb.Text;
            tb.gia = txtgia.Text;        
            QLTBBUS.Them_TB(tb);
            listView1.Items.Clear();
            TT_TB();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QLTBDTO tb = new QLTBDTO();
            tb.matb = txtma.Text;
            tb.maphong = cbmap.SelectedValue.ToString();
            tb.tentb = txttentb.Text;
            tb.gia = txtgia.Text;          
            QLTBBUS.CapNhat_TB(tb);
            listView1.Items.Clear();
            TT_TB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLTBDTO tb = new QLTBDTO();
            tb.matb = txtma.Text;
            QLTBBUS.Xoa_TB(tb);
            listView1.Items.Clear();
            TT_TB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txtma.Text = listView1.SelectedItems[0].SubItems[0].Text;
            cbmap.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txttentb.Text = listView1.SelectedItems[0].SubItems[2].Text;          
            txtgia.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
    }
}

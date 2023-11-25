using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL
{
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
        }

        private void QLKH_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int vt = listView1.SelectedIndices[0];
            txtmkh.Text = listView1.Items[vt].SubItems[0].Text;
            txttenkh.Text = listView1.Items[vt].SubItems[1].Text;
            if (listView1.Items[vt].SubItems[2].Text == "Nam")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            txtdiachi.Text = listView1.Items[vt].SubItems[3].Text;
            txtsdt.Text = listView1.Items[vt].SubItems[4].Text;
            txtmaphong.Text = listView1.Items[vt].SubItems[5].Text;

        }
    }
}

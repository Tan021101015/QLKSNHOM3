﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.DAO;
using QL.DTO;
using QL.BUS;

namespace QL
{
    public partial class QLPHONG : Form
    {
        public QLPHONG()
        {
            InitializeComponent();
        }
        public void tt_phong()
        {
            listView1.Items.Clear();
            DataTable dtp = new DataTable();
            dtp = phongdao.tt_phong();
            int slp = dtp.Rows.Count;
            for (int i = 0; i < slp; i++)
            {
                listView1.Items.Add(dtp.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(dtp.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(dtp.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(dtp.Rows[i][3].ToString());
                //listView1.Items[i].SubItems.Add(dtp.Rows[i][4].ToString());
                float gia = float.Parse(dtp.Rows[i][4].ToString());
                listView1.Items[i].SubItems.Add(gia.ToString("#,###") + "VND");
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = phongdao.tt_maphongln();
            string ma = dt.Rows[0][0].ToString();
            txtmaphong.Text = "MP" + (Convert.ToInt32(ma.Substring(2, ma.Length - 2)) + 1).ToString("00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            phongdto kh = new phongdto();
            kh.maphong = txtmaphong.Text;
            kh.tenphong = txttenphong.Text;
            kh.loaiphong = comloaiphong.Text;
            kh.tinhtrang = continhtrang.Text;
            string input = txtdongia.Text;
            string output = (int.Parse(input.Replace(",", "").Replace("VND", ""))).ToString();
            kh.dongia = output.ToString();
            //kh.dongia = txtdongia.Text;
            phongbus.themphong(kh);
            tt_phong();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            phongdto kh = new phongdto();
            kh.maphong = txtmaphong.Text;
            kh.tenphong = txttenphong.Text;
            kh.loaiphong = comloaiphong.Text;
            kh.tinhtrang = continhtrang.Text;
            string input = txtdongia.Text;
            string output = (int.Parse(input.Replace(",", "").Replace("VND", ""))).ToString();
            kh.dongia = output.ToString();

            //kh.dongia = txtdongia.Text;
            phongbus.CapNhat_phong(kh);
            tt_phong();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            phongdto kh = new phongdto();
            kh.maphong = txtmaphong.Text;
            phongbus.xoa_phong(kh);
            tt_phong();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

        
        private void QLPHONG_Load_1(object sender, EventArgs e)
        {
            tt_phong();
            comloaiphong.Items.Add("Đơn");
            comloaiphong.Items.Add("Đôi");
            comloaiphong.Items.Add("Vip Đơn");
            comloaiphong.Items.Add("Vip Đôi");
            comloaiphong.Items.Add("Phòng gia đình");
            continhtrang.Items.Add("Còn phòng");
            continhtrang.Items.Add("Hết Phòng");
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txtmaphong.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txttenphong.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comloaiphong.Text = listView1.SelectedItems[0].SubItems[2].Text;
            continhtrang.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtdongia.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void txttenphong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void continhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
    }



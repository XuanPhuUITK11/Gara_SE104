﻿using Source.DAO;
using Source.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Source
{
	/// <summary>
	/// ////////////////
	/// </summary>
	public partial class Home_page : Form
	{

<<<<<<< HEAD
        public Home_page()
        {
            InitializeComponent();
            //loadaccountlist();
        }
<<<<<<< HEAD
        //public void loadaccountlist()
        //{
        //    //EXEC GETACCOUNTBYUSERNAME @USERNAME
        //    string query = "SELECT *FROM dbo.TAIKHOAN ";
        //    //string query = "INSERT INTO TAIKHOAN VALUES('TK06','NV6','123456','07/02/1788')";
        //    DATAPROVIDER provider = new DATAPROVIDER();
        //    dataGridView1.DataSource = provider.Executequery(query/*,new object[] { "NV2" }*/);
=======
        public void loadaccountlist()
        {
            //EXEC GETACCOUNTBYUSERNAME @USERNAME
            string query = "SELECT *FROM dbo.TAIKHOAN ";
           // string query = "INSERT INTO TAIKHOAN VALUES('TK06','NV6','123456','07/02/1788')";
            DATAPROVIDER provider = new DATAPROVIDER();
            dataGridView1.DataSource = provider.Executequery(query/*new object[] { "NV2" }*/);
>>>>>>> e2023e9337b946c937770b4692e2279112df10ab
            
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
=======
		public Home_page()
		{
			InitializeComponent();
			//loadaccountlist();
		}
>>>>>>> 4fe023875b0b49133466e341884611d9ec8caddd

	
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void khachhang_Click(object sender, EventArgs e)
		{
			Khachhang f = new Khachhang();
            f.Show();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
            Phutung pt = new Phutung();
            pt.Show();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void nhanvien_Click(object sender, EventArgs e)
		{
            Nhanvien nv = new Nhanvien();
            nv.Show();
		}

		private void label2_Click(object sender, EventArgs e)
		{
            
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			QL_SUACHUA f = new QL_SUACHUA();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan ql = new QuanLyTaiKhoan();
            ql.Show();
        }

        private void baocaothang_Click(object sender, EventArgs e)
        {
            BaoCaoThang f = new BaoCaoThang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
	}


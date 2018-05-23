﻿using Source.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source
{
	public partial class PhieuSuaChua : Form
	{
		public PhieuSuaChua()
		{
			InitializeComponent();
            showmanv();
            showmakh();
		}
        void spilit_space(ref string str)
        {
            while (str[str.Length - 1] == ' ')

            {
                str = str.Remove(str.Length - 1);
            }
        }
        void showmanv()
        {
            string query = "SELECT *FROM dbo.NHANVIEN ";
            DATAPROVIDER provider = new DATAPROVIDER();
            DataTable tb = new DataTable();
            tb = provider.Executequery(query);
            foreach (DataRow row in tb.Rows)
            {
                string name = row["MANV"].ToString();
                MANV.Items.Add(name);
            }
            MANV.Show();
        }
        void showmakh()
        {
            string query = "SELECT *FROM dbo.KHACHHANG ";
            DATAPROVIDER provider = new DATAPROVIDER();
            DataTable tb = new DataTable();
            tb = provider.Executequery(query);
            foreach (DataRow row in tb.Rows)
            {
                string name = row["MAKH"].ToString();
                makh.Items.Add(name);
            }
            makh.Show();
        }
        private void label1_Click(object sender, EventArgs e)
		{

		}

		private void PhieuSuaChua_Load(object sender, EventArgs e)
		{

		}

        private void TIEN_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            if(MAPSC.Text==""||MANV.Text=="")
            {
                MessageBox.Show("Mã phiếu sữa chữa hoặc mã nhân viên không được trống!!!");
            }
            else
            {
                string idnv = MANV.SelectedItem.ToString();
                spilit_space(ref idnv);
                string idkh = makh.SelectedItem.ToString();
                spilit_space(ref idkh);
                string ngaysc = NGAYSUACHUA.Value.ToString();

                string query = "INSERT INTO dbo.PHIEUSUACHUA( MAPSC,MANV,MAKH,NGAYSUACHUA,THANHTIEN)VALUES( '"+MAPSC.Text.ToString()+"','"+idnv+"','"+idkh+"','"+ngaysc+"',"+TIEN.Text.ToString()+") ";
                DATAPROVIDER provider = new DATAPROVIDER();
                DataTable tb = new DataTable();
                tb = provider.Executequery(query);
                MessageBox.Show("Thêm phiếu sửa chữa thành công");
            }
        }

        private void makh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

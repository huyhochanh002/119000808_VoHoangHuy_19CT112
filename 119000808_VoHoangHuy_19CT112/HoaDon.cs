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

namespace _119000808_VoHoangHuy_19CT112
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public TrangChinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        private void HoaDon_Load(object sender, EventArgs e)
        {
            ondataviewGAS();
            ondataviewKH();
            ondataviewNhanVien();
        }
        SqlConnection cnn = new SqlConnection();
        string server = "LAPTOP-MV93PLLT\\SQLEXPRESS";
        //dataapdater dataset
        SqlDataAdapter daKH = new SqlDataAdapter();
        SqlDataAdapter daGAS = new SqlDataAdapter();
        SqlDataAdapter daNV = new SqlDataAdapter();
        DataTable dtKH = new DataTable();
        DataTable dtGAS = new DataTable();
        DataTable dtNV = new DataTable();
        BindingSource binKH = new BindingSource();
        BindingSource binGAS = new BindingSource();
        BindingSource binNV = new BindingSource();
        public void Runnow()
        {
            try
            {
                string s = "Server=" + server + ";database=BanGas;uid=sa;pwd=123456";
                cnn.ConnectionString = s;
                cnn.Open();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Có Lỗi Khi Kết Nối Dữ Liệu Server ! ");
            }
        }
        public void ondataviewKH()
        {
            try
            {
                Runnow();
                string s = "Select * From KhachHang";
                SqlCommand cmd = new SqlCommand(s, cnn);
                daKH.SelectCommand = cmd;
                daKH.Fill(dtKH);
                binKH.DataSource = dtKH;
                data_KH.DataSource = binKH;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu ! ");
            }
        }
        public void ondataviewGAS()
        {
            try
            {
                Runnow();
                string s = "Select * From GAS";
                SqlCommand cmd = new SqlCommand(s, cnn);
                daGAS.SelectCommand = cmd;
                daGAS.Fill(dtGAS);
                binGAS.DataSource = dtGAS;
                data_Loaigas.DataSource = binGAS;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu ! ");
            }
        }
        public void ondataviewNhanVien()
        {
            try
            {
                Runnow();
                string s = "Select * From NhanVien";
                SqlCommand cmd = new SqlCommand(s, cnn);
                daNV.SelectCommand = cmd;
                daNV.Fill(dtNV);
                binNV.DataSource = dtNV;
                data_nhanvien.DataSource = binNV;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu ! ");
            }
        }
    }
}

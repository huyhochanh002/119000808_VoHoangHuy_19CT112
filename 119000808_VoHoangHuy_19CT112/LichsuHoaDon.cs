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
    public partial class LichsuHoaDon : Form
    {
        public LichsuHoaDon()
        {
            InitializeComponent();
        }
        public TrangChinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void Report_Load(object sender, EventArgs e)
        {
            ondataviewHoaDon();
        }
        //// Kết Nối Sql Nè 
        SqlConnection cnn = new SqlConnection();
        string server = "LAPTOP-MV93PLLT\\SQLEXPRESS";
        //dataapdater dataset
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bin = new BindingSource();
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
        public void ondataviewHoaDon()
        {
            try
            {
                Runnow();
                string s = "Select * From HoaDon";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_HoaDon.DataSource = bin;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu ! ");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dt.Clear();
            ondataviewHoaDon();


        }
        static int masokhachhang_in;
        private void data_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&&e.ColumnIndex>=0)
            {
                 masokhachhang_in = Convert.ToInt32(data_HoaDon.CurrentRow.Cells["MSKH"].Value);
                txt_msKH.Text = masokhachhang_in.ToString();
                txt_msGAS.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["MSGAS"].Value);
                txt_msNV.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["MSNV"].Value);
                txt_tenKH.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["TENKH"].Value);
                txt_sdtKH.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["SDTKH"].Value);
                txt_DC.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["DIACHI"].Value);
                txt_tongtien.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["TTIEN"].Value);
            }
        }
    }
}

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
            clear();
            ondataviewHoaDon();


        }
        private static int MSHD;

        private void data_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    MSHD = Convert.ToInt32(data_HoaDon.CurrentRow.Cells["MSDONHANG"].Value);
                    txt_msKH.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["MSKH"].Value);
                    txt_msGAS.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["MSGAS"].Value);
                    txt_msNV.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["MSNV"].Value);
                    txt_tenKH.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["TENKH"].Value);
                    txt_sdtKH.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["SDTKH"].Value);
                    txt_DC.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["DIACHI"].Value);
                    txt_tongtien.Text = Convert.ToString(data_HoaDon.CurrentRow.Cells["TTIEN"].Value);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Không có dữ liệu ! ");
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            BaoCao bc = new BaoCao(MSHD);
            bc.ShowDialog();
        }
        public void clear()
        {
            MSHD = 0;
            txt_msKH.Text = "";
            txt_msGAS.Text = "";
            txt_msNV.Text = "";
            txt_tenKH.Text = "";
            txt_sdtKH.Text = "";
            txt_DC.Text = "";
            txt_tongtien.Text = "";
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DongTap();
        }
    }
}

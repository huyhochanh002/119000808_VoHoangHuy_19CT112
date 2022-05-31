
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
        //string server = "LAPTOP-MV93PLLT\\SQLEXPRESS";
        KhaiBaoChung bc = new KhaiBaoChung();
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
        /// <summary>
        /// Kết 1nối sqlserver tại đây
        /// </summary>
        public void Runnow()
        {
            try
            {
                string s = bc.NguyenChuoi1; /*"Server=" + bc.Server + ";database=" + bc.Database + ";uid=" + bc.Uid + ";pwd=" + bc.Pwd;*/
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
        // Lưu giá trị số lần mua
        int solan;
        private void data_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_msKH.Text = Convert.ToString(data_KH.CurrentRow.Cells["MSKH"].Value);
                    txt_tenKH.Text = Convert.ToString(data_KH.CurrentRow.Cells["TENKH"].Value);
                    txt_sdtKH.Text = Convert.ToString(data_KH.CurrentRow.Cells["SDT"].Value);
                    txt_DC.Text = Convert.ToString(data_KH.CurrentRow.Cells["DIACHI"].Value);
                    solan = Convert.ToInt32(data_KH.CurrentRow.Cells["SLDAMUA"].Value);
                }
            }
            catch (Exception e2)
            {
            }
        }

        private void data_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_msNV.Text = Convert.ToString(data_nhanvien.CurrentRow.Cells["MSNV"].Value);
                }
            }
            catch (Exception e2)
            {
            }
        }
        int sltonkho;
        private void data_Loaigas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_msGAS.Text = Convert.ToString(data_Loaigas.CurrentRow.Cells["MSGAS"].Value);
                    double tt = Convert.ToDouble(data_Loaigas.CurrentRow.Cells["DGGAS"].Value);
                    double tong = tt * 1000.0;
                    txt_tongtien.Text = tong.ToString();
                    sltonkho = Convert.ToInt32(data_Loaigas.CurrentRow.Cells["SLTON"].Value);

                }
            }
            catch (Exception e2)
            {
            }
        }
        public void clear()
        {
            txt_msKH.Text = "";
            txt_tenKH.Text = "";
            txt_DC.Text = "";
            txt_sdtKH.Text = "";
            txt_msNV.Text = "";
            txt_msGAS.Text = "";
            txt_tongtien.Text = "";
            dtKH.Clear();
            dtNV.Clear();
            dtGAS.Clear();
            daKH.Fill(dtKH);
            daNV.Fill(dtNV);
            daGAS.Fill(dtGAS);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "insert into HoaDon (MSKH,MSGAS,MSNV,TENKH,SDTKH,DIACHI,TTIEN,NGAYBAN) values " +
                    "(@MSKH,@MSGAS,@MSNV,@TENKH,@SDTKH,@DIACHI,@TTIEN,@NGAYBAN)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MSKH", SqlDbType.Int).Value = int.Parse(txt_msKH.Text);
                cmd.Parameters.Add("@MSGAS", SqlDbType.Int).Value = int.Parse(txt_msGAS.Text);
                cmd.Parameters.Add("@MSNV", SqlDbType.Int).Value = int.Parse(txt_msNV.Text);
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = txt_tenKH.Text;
                cmd.Parameters.Add("@SDTKH", SqlDbType.Int).Value = int.Parse(txt_sdtKH.Text);
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txt_DC.Text;
                cmd.Parameters.Add("@TTIEN", SqlDbType.Float).Value = float.Parse(txt_tongtien.Text);
                cmd.Parameters.Add("@NGAYBAN", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Tạo Hóa Đơn Thành Công");
                updatesolanmua();
                updatehangtonkho();
                clear();

            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Tạo Hóa Đơn Thất Bại ! ");
            }
        }
        public void updatesolanmua()
        {
            try
            {
                Runnow();
                string s = "Update KhachHang set SLDAMUA="+(solan + 1)+ " where MSKH=@MSKH ";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MSKH", SqlDbType.Int).Value = int.Parse(txt_msKH.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception e2)
            {
                cnn.Close();
            }
        }
        public void updatehangtonkho()
        {
            try
            {
                Runnow();
                string s = "Update GAS set SLTON=" + (sltonkho - 1) + " where MSGAS=@MSGAS ";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MSGAS", SqlDbType.Int).Value = int.Parse(txt_msGAS.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception e2)
            {
                cnn.Close();
            }
        }

        private void HoaDon_Leave(object sender, EventArgs e)
        {
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DongTap();
        }
    }
}

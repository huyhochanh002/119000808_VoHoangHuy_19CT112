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
        KhaiBaoChung bc = new KhaiBaoChung();
        //string server = "LAPTOP-MV93PLLT\\SQLEXPRESS";
        //dataapdater dataset
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bin = new BindingSource();
        public void Runnow()
        {
            try
            {
                string s = "Server=" + bc.Server + ";database=" + bc.Database + ";uid=sa;pwd=123456";
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
            clear();


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
            txt_ngay.Text = "";
            txt_nam.Text = "";
            txt_thang.Text = "";
            txt_ngay1.Text = "";
            txt_nam1.Text = "";
            txt_thang1.Text = "";
            dt.Clear();
            ondataviewHoaDon();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DongTap();
        }

        private void btn_locdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nam1.Text == "" || txt_ngay1.Text == "" || txt_thang1.Text == "")
                {
                    Runnow();
                    string s = "Select *  From HoaDon Where (NGAYBAN>=" + "'" + txt_nam.Text + "-" + txt_thang.Text + "-" + txt_ngay.Text + " 00:00:00.000" + "'"
                        + " )and " + "(NGAYBAN <= " + "'" + txt_nam.Text + "-" + txt_thang.Text + "-" + txt_ngay.Text + " 23:59:59.999" + "'"
                        + " )";
                    SqlCommand cmd = new SqlCommand(s, cnn);
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    bin.DataSource = dt;
                    data_HoaDon.DataSource = bin;
                    cnn.Close();
                }
                else
                {
                    Runnow();
                    string s1 = "Select *  From HoaDon Where (NGAYBAN>=" + "'" + txt_nam.Text + "-" + txt_thang.Text + "-" + txt_ngay.Text + " 00:00:00.00" + "'"
                        + " )and " + "(NGAYBAN <= " + "'" + txt_nam1.Text + "-" + txt_thang1.Text + "-" + txt_ngay1.Text + " 23:59:59.999" + "'"
                        + " )";
                    SqlCommand cmd1 = new SqlCommand(s1, cnn);
                    da.SelectCommand = cmd1;
                    dt.Clear();
                    da.Fill(dt);
                    bin.DataSource = dt;
                    data_HoaDon.DataSource = bin;
                    cnn.Close();
                }

            }
            catch (Exception e2)
            {
                cnn.Close();
            }
        }

        private void txt_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_ngay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_nam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_thang1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_ngay1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_intoanbotheongay_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nam1.Text == "" || txt_ngay1.Text == "" || txt_thang1.Text == "")
                {
                    //2022-05-22 11:08:52.903
                    String day1 = txt_nam.Text + "-" + txt_thang.Text + "-" + txt_ngay.Text + " 00:00:00.000";
                    DateTime ngaybd = Convert.ToDateTime(day1);
                    String day2 = txt_nam.Text + "-" + txt_thang.Text + "-" + txt_ngay.Text + " 23:59:59.999";
                    DateTime ngaykt = Convert.ToDateTime(day2);
                    BaoCaoTheoNgay bc = new BaoCaoTheoNgay(ngaybd, ngaykt);
                    bc.ShowDialog();
                }
                else
                {
                    //2022-05-22 11:08:52.903
                    String day1 = txt_nam.Text + "-" + txt_thang.Text + "-" + txt_ngay.Text + " 00:00:00.000";
                    DateTime ngaybd = Convert.ToDateTime(day1);
                    String day2 = txt_nam1.Text + "-" + txt_thang1.Text + "-" + txt_ngay1.Text + " 23:59:59.999";
                    DateTime ngaykt = Convert.ToDateTime(day2);
                    BaoCaoTheoNgay bc = new BaoCaoTheoNgay(ngaybd, ngaykt);
                    bc.ShowDialog();
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Hãy Kiểm Tra Lại Ngày Tháng Nhập !");
            }
        }
    }
}

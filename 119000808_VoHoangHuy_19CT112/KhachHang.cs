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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        // load khi chạy
        private void KhachHang_Load(object sender, EventArgs e)
        {
            ondataviewKH();
        }
        public TrangChinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
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
        public void ondataviewKH()
        {
            try
            {
                Runnow();
                string s = "Select * From KhachHang";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_KhachHang.DataSource = bin;
                cnn.Close();
            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Có Lỗi Khi Hiện thị Dữ Liệu ! ");
            }
        }
        public void clear()
        {
            txt_mskh.Text = "";
            txt_tenkh.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
            txt_sldamua.Text = "";
            btn_them.Enabled = true;
        }
        private void data_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_mskh.Text = Convert.ToString(data_KhachHang.CurrentRow.Cells["MSKH"].Value);
                    txt_tenkh.Text = Convert.ToString(data_KhachHang.CurrentRow.Cells["TENKH"].Value);
                    txt_sdt.Text = Convert.ToString(data_KhachHang.CurrentRow.Cells["SDT"].Value);
                    txt_diachi.Text = Convert.ToString(data_KhachHang.CurrentRow.Cells["DIACHI"].Value);
                    txt_sldamua.Text = Convert.ToString(data_KhachHang.CurrentRow.Cells["SLDAMUA"].Value);
                    btn_them.Enabled = false;
                }
            }
            catch (Exception e2)
            {
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
            dt.Clear();
            ondataviewKH();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "insert into KhachHang(TENKH,SDT,DIACHI,SLDAMUA) values " +
                    "(@TENKH,@SDT,@DIACHI,@SLDAMUA)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = txt_tenkh.Text;
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = int.Parse(txt_sdt.Text);
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txt_diachi.Text;
                cmd.Parameters.Add("@SLDAMUA", SqlDbType.Int).Value =0;
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Thêm Thành Công");
                clear();
                dt.Clear();
                da.Fill(dt);

            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Dữ Liệu nhập ! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Runnow();
                string s = "Update KhachHang set TENKH=@TENKH,SDT=@SDT,DIACHI=@DIACHI,SLDAMUA=@SLDAMUA where MSKH=@MSKH ";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MSKH", SqlDbType.Int).Value = int.Parse(txt_mskh.Text);
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = txt_tenkh.Text;
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = int.Parse(txt_sdt.Text);
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txt_diachi.Text;
                cmd.Parameters.Add("@SLDAMUA", SqlDbType.Int).Value = int.Parse(txt_sldamua.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Đã Sữa Thành Công");
                clear();
                dt.Clear();
                da.Fill(dt);

            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Dữ Liệu nhập ! ");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                Runnow();
                string s = "DELETE FROM KhachHang Where MSKH = @MSKH";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MSKH", SqlDbType.Int).Value = int.Parse(txt_mskh.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Đã Xóa Thành Công");
                clear();
                dt.Clear();
                da.Fill(dt);

            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Xóa Thất Bại ! ");
            }

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DongTap();
        }

        private void txt_timkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                try
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = "TENKH like '%" + txt_timkiem.Text + "%'";
                    data_KhachHang.DataSource = dv;
                }catch(Exception e2)
                {

                }
            }
        }
    }
}

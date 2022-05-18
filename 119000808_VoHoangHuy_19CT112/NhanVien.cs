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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        public TrangChinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DongTap();
        }
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
        public void ondataviewNV()
        {
            try
            {
                Runnow();
                string s = "Select * From NhanVien";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_nhanvien.DataSource = bin;
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
            txt_msnv.Text = "";
            txt_tennv.Text = "";
            txt_sdtnv.Text = "";
            txt_diachinv.Text = "";
            btn_them.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "insert into NhanVien (TENNV,SDT,DIACHI) values " +
                    "(@TENNV,@SDT,@DIACHI)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = txt_tennv.Text;
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = int.Parse(txt_sdtnv.Text);
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txt_diachinv.Text;
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
                string s = "Update NhanVien set TENNV=@TENNV,SDT=@SDT,DIACHI=@DIACHI where MSNV=@MSNV ";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MSNV", SqlDbType.Int).Value = int.Parse(txt_msnv.Text);
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = txt_tennv.Text;
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = int.Parse(txt_sdtnv.Text);
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txt_diachinv.Text;
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
                string s = "DELETE FROM NhanVien Where MSNV = @MSNV";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MSNV", SqlDbType.Int).Value = int.Parse(txt_msnv.Text);
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            ondataviewNV();
        }

        private void data_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_msnv.Text = Convert.ToString(data_nhanvien.CurrentRow.Cells["MSNV"].Value);
                    txt_tennv.Text = Convert.ToString(data_nhanvien.CurrentRow.Cells["TENNV"].Value);
                    txt_sdtnv.Text = Convert.ToString(data_nhanvien.CurrentRow.Cells["SDT"].Value);
                    txt_diachinv.Text = Convert.ToString(data_nhanvien.CurrentRow.Cells["DIACHI"].Value);
                    btn_them.Enabled = false;
                }
            }
            catch (Exception e2)
            {
            }
        }
    }

}

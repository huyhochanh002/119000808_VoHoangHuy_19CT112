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
    public partial class Gas : Form
    {
        public Gas()
        {
            InitializeComponent();
        }

        private void pn_top_Paint(object sender, PaintEventArgs e)
        {

        }
        public TrangChinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
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
        public void ondataviewGAS()
        {

            try
            {
                Runnow();
                string s = "Select * From Gas";
                SqlCommand cmd = new SqlCommand(s, cnn);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bin.DataSource = dt;
                data_gas.DataSource = bin;
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
            txt_msgas.Text = "";
            txt_dongia.Text = "";
            txt_size.Text = "";
            txt_ton.Text = "";
            btn_them.Enabled = true;
            dt.Clear();
            da.Fill(dt);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "insert into GAS (SIZE,DGGAS,SLTON) values " +
                    "(@SIZE,@DGGAS,@SLTON)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@SIZE", SqlDbType.Int).Value = int.Parse(txt_size.Text);
                cmd.Parameters.Add("@DGGAS", SqlDbType.Float).Value = float.Parse(txt_dongia.Text);
                cmd.Parameters.Add("@SLTON", SqlDbType.Int).Value = int.Parse(txt_ton.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Thêm Thành Công");
                clear();

            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Dữ Liệu nhập ! ");
            }

        }

        private void Gas_Load(object sender, EventArgs e)
        {
            ondataviewGAS();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DongTap();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Runnow();
                string s = "Update GAS set SIZE=@SIZE,DGGAS=@DGGAS,SLTON=@SLTON where MSGAS=@MSGAS ";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MSGAS", SqlDbType.Int).Value = int.Parse(txt_msgas.Text);
                cmd.Parameters.Add("@SIZE", SqlDbType.Int).Value = int.Parse(txt_size.Text);
                cmd.Parameters.Add("@DGGAS", SqlDbType.Float).Value = float.Parse(txt_dongia.Text);
                cmd.Parameters.Add("@SLTON", SqlDbType.Int).Value = int.Parse(txt_ton.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Đã Sữa Thành Công");
                clear();

            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Dữ Liệu nhập ! ");
            }

        }

        private void data_gas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txt_msgas.Text = Convert.ToString(data_gas.CurrentRow.Cells["MSGAS"].Value);
                    txt_dongia.Text = Convert.ToString(data_gas.CurrentRow.Cells["DGGAS"].Value);
                    txt_size.Text = Convert.ToString(data_gas.CurrentRow.Cells["SIZE"].Value);
                    txt_ton.Text = Convert.ToString(data_gas.CurrentRow.Cells["SLTON"].Value);
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
            ondataviewGAS();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "DELETE FROM GAS Where MSGAS = @MSGAS";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MSGAS", SqlDbType.Int).Value = int.Parse(txt_msgas.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Đã Xóa Thành Công");
                clear();

            }
            catch (Exception e2)
            {
                cnn.Close();
                MessageBox.Show("Xóa Thất Bại ! ");
            }

        }
    }
}

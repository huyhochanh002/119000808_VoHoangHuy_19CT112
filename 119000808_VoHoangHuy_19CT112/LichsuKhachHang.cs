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
    public partial class LichsuKhachHang : Form
    {
        public LichsuKhachHang()
        {
            InitializeComponent();
        }

        private void LichsuKhachHang_Load(object sender, EventArgs e)
        {
            Runnow();
            Datquanhe("KhachHang","HoaDon","MSKH","MSKH","KhachHang_HoaDon");
            cb = new SqlCommandBuilder(dacon);
            buocdieukien();

        }
        //// Kết Nối Sql Nè 
        SqlConnection cnn = new SqlConnection();
        KhaiBaoChung bc = new KhaiBaoChung();
        //
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bin = new BindingSource();
        SqlDataAdapter dacha = new SqlDataAdapter();
        SqlDataAdapter dacon=new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder cb;
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
        public void Datquanhe(String Cha,String Con,String Khoachinh,String Khoaphu,String Tenquanhe)
        {
            try
            {
                SqlCommand cmdcha = new SqlCommand("select * from " + Cha, cnn);
                dacha.SelectCommand = cmdcha;
                SqlCommand cmdcon = new SqlCommand("select * from " + Con, cnn);
                dacon.SelectCommand = cmdcon;
                dacha.Fill(ds, Cha);
                dacon.Fill(ds, Con);
                DataColumn chinh = ds.Tables[Cha].Columns[Khoachinh];
                DataColumn phu = ds.Tables[Con].Columns[Khoaphu];
                DataRelation r = new DataRelation(Tenquanhe, chinh, phu);
                ds.Relations.Add(r);
            }catch(Exception e2)
            {
                cnn.Close();
            }
        }
        public void buocdieukien()
        {
            try
            {
                list_msKH.DataSource = ds;
                list_msKH.DisplayMember = "KhachHang.MSKH";
                datalichsuKH.DataSource = ds;
                datalichsuKH.DataMember = "KhachHang.KhachHang_HoaDon";
            }catch (Exception e2)
            {
                cnn.Close();
            }
        }
    }
}

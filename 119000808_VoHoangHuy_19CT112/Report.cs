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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection();
        string server = "LAPTOP-MV93PLLT\\SQLEXPRESS";
        private void Report_Load(object sender, EventArgs e)
        {
            string s = "Server=" + server + ";database=BanGas;uid=sa;pwd=123456";
            cnn.ConnectionString = s;

            this.reportViewer1.RefreshReport();
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}

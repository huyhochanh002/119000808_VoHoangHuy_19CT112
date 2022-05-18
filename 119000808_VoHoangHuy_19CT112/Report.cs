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
        string maHD = string.Empty;
        KhachHang db;
        DataTable dtInHoaDon;
        string err = string.Empty;
        int rows = 0;
        private void Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}

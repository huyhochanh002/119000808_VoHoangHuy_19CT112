using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _119000808_VoHoangHuy_19CT112
{
    public partial class BaoCaoTheoNgay : Form
    {
        public BaoCaoTheoNgay(DateTime ngaybd,DateTime ngaykt)
        {
            _ngaybd = ngaybd;
            _ngaykt = ngaykt;
            InitializeComponent();
        }
        DateTime _ngaybd;
        DateTime _ngaykt;

        private void BaoCaoTheoNgay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banGasDataSet.RPT_HOADONTHEONGAY' table. You can move, or remove it, as needed.
            this.rPT_HOADONTHEONGAYTableAdapter.Fill(this.banGasDataSet.RPT_HOADONTHEONGAY,_ngaybd,_ngaykt);

            this.reportViewer1.RefreshReport();
        }
    }
}

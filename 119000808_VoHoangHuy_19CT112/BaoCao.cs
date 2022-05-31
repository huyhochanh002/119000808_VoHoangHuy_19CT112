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
    public partial class BaoCao : Form
    {
        public BaoCao(int MSHD)
        {
            layso = MSHD;
            InitializeComponent();
        }
        int layso;
        
        private void BaoCao_Load(object sender, EventArgs e)
        {
            try
            {            // TODO: This line of code loads data into the 'banGasDataSet.RPT_HOADON' table. You can move, or remove it, as needed.
                this.rPT_HOADONTableAdapter.Fill(this.banGasDataSet.RPT_HOADON, layso);
            }
            catch(Exception e2)
            {

            }


        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}

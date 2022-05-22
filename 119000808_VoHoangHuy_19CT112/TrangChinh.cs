using DevComponents.DotNetBar;
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
    public partial class TrangChinh : Form
    {
        public TrangChinh()
        {
            InitializeComponent();
        }

        private void TrangChinh_Load(object sender, EventArgs e)
        {

        }
        #region Kiem Tra Tab
        bool trangThai = false;
        private String tentabmo;
        private bool Kiemtramotab(string name)
        {
            for (int i = 0; i < tab_main.Tabs.Count; i++)
            {
                if (tab_main.Tabs[i].Text == name)
                {
                    tab_main.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        private void DongTab()
        {
            foreach (TabItem item in tab_main.Tabs)
            {
                if (item.IsSelected == true)
                {
                    tab_main.Tabs.Remove(item);
                    return;
                }
            }
        }
        #endregion
        public TrangChinh frm;
        public delegate void _dongTap();

        private void btn_KH_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "Quản lý Khách Hàng";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "KhachHang";

                    KhachHang khachhang = new KhachHang()
                    {
                        DongTap = new KhachHang._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(khachhang);
                    khachhang.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab khách Hàng !");
            }
        }

        private void btn_gas_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "Quản lý Gas";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "Gas";

                    Gas gas = new Gas()
                    {
                        DongTap = new Gas._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(gas);
                    gas.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Gas !");
            }
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "Quản lý Nhân Viên";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "nhanvien";

                    NhanVien nhanvien = new NhanVien()
                    {
                        DongTap = new NhanVien._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(nhanvien);
                    nhanvien.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Nhân Viên !");
            }
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "Quản lý Hóa Đơn";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "hoadon";

                    HoaDon hoaDon = new HoaDon()
                    {
                        DongTap = new HoaDon._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(hoaDon);
                    hoaDon.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab Bán Hàng!");
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            try
            {
                this.trangThai = true;
                this.tentabmo = "In Hóa Đơn";
                if (!Kiemtramotab(tentabmo))
                {
                    TabItem t = tab_main.CreateTab(tentabmo);
                    t.Name = "inhoadon";

                    LichsuHoaDon report = new LichsuHoaDon()
                    {
                        DongTap = new LichsuHoaDon._dongTap(DongTab),
                        frm = this,
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                    };
                    t.AttachedControl.Controls.Add(report);
                    report.Show();
                    tab_main.SelectedTabIndex = tab_main.Tabs.Count - 1;
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Mở Tab In Hóa Đơn !");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119000808_VoHoangHuy_19CT112
{
    internal class KhaiBaoChung
    {
        String database;
        String server;
        String uid;
        String pwd;
        String NguyenChuoi;
        // Chỉnh Sữa Thông Tin Database ở đây
        public KhaiBaoChung()
        {
            // tên database
            // database = "BanGas";
            // chuỗi server
            // server = "LAPTOP-MV93PLLT\\SQLEXPRESS"; // phải 2 dấu \\ mới được nha 
            // tên user
            // Uid = "sa";
            // mật khẩu user
            //pwd = "123456";
            NguyenChuoi = laychuoi();
        }

        public string Database { get => database; set => database = value; }
        public string Server { get => server; set => server = value; }
        public string Uid { get => uid; set => uid = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string NguyenChuoi1 { get => NguyenChuoi; set => NguyenChuoi = value; }

        public string laychuoi()
        {
            String s;
            StreamReader rd = new StreamReader("ketnoi.txt");
            s = rd.ReadToEnd();
            rd.Close();
            return s;
        }
    }
}

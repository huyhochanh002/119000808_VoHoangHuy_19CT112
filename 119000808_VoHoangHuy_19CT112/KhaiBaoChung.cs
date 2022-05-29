using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119000808_VoHoangHuy_19CT112
{
    internal class KhaiBaoChung
    {
        String database;
        String server;

        public KhaiBaoChung()
        {
            database = "BanGas";
            server = "LAPTOP-MV93PLLT\\SQLEXPRESS";
        }

        public string Database { get => database; set => database = value; }
        public string Server { get => server; set => server = value; }
    }
}

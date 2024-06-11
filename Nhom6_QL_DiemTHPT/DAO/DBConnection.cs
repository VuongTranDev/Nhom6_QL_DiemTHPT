using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Nhom6_QL_DiemTHPT.DAO
{
    public static class DBConnection
    {
<<<<<<< Updated upstream
        private static string con = "Data Source=DESKTOP-PM2GBTG;Initial Catalog=QL_DIEM_THPT;Persist Security Info=True;User ID=sa;Password=123";
=======

        private static string con = "Data Source=MSI\\MSSQLSERVER_2022;Initial Catalog=QL_DIEM_THPT;Persist Security Info=True;User ID=sa;Password=123";
>>>>>>> Stashed changes
        public static IDbConnection GetConnection()
        {
            return new SqlConnection(con);
        }
    }
}

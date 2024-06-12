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

        private static string con = @"Data Source=VO-NHUT-HAO\SQLEXPRESS;Initial Catalog=QL_DIEM_THPT;Persist Security Info=True;User ID=sa;Password=123";
        public static IDbConnection GetConnection()
        {
            return new SqlConnection(con);
        }
        public static string getConStr()
        {
            return con;
        }
        
    }
}

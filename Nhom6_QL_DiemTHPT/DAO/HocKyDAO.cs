using Nhom6_QL_DiemTHPT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Nhom6_QL_DiemTHPT.DAO
{
    public class HocKyDAO
    {
        public List<HocKyDTO> GetHocKy()
        {
            string query = "SELECT * FROM HOCKY";

            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                return connection.Query<HocKyDTO>(query).ToList();
            }
        }
    }
}

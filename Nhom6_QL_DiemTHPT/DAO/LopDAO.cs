using Dapper;
using Nhom6_QL_DiemTHPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_QL_DiemTHPT.DAO
{
    public class LopDAO
    {
        public List<LopDTO> GetLop()
        {
            string query = "SELECT * FROM LOP";

            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                return connection.Query<LopDTO>(query).ToList();
            }
        }
    }
}

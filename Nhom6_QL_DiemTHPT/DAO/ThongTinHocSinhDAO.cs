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
    public class ThongTinHocSinhDAO
    {
        public ThongTinHocSinhDTO GetThongTinHocSinh(string mahs)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                string procedureName = "GetThongTinHocSinh";
                var parameters = new { MAHS = mahs };
                return connection.QueryFirstOrDefault<ThongTinHocSinhDTO>(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

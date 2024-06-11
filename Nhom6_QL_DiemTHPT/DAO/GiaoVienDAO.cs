using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nhom6_QL_DiemTHPT.ASD;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Nhom6_QL_DiemTHPT.DAO
{
    class GiaoVienDAO
    {
        public List<GIAOVIEN> LayDSGiaoVien()
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                var giaovienList = connection.Query<GIAOVIEN>("LayDSGiaoVien", commandType: CommandType.StoredProcedure).AsList();
                return giaovienList;
            }
        }
      
    }
}

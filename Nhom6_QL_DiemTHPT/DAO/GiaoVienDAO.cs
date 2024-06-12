using Dapper;
using Nhom6_QL_DiemTHPT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Nhom6_QL_DiemTHPT.DTO;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Nhom6_QL_DiemTHPT.DAO
{
    public class GiaoVienDAO
    {
        public GiaoVienDTO GetGiaoVien(string maGiaoVien)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                string procedureName = "GetGiaoVien";
                var parameters = new { MAGV = maGiaoVien };
                return connection.QueryFirstOrDefault<GiaoVienDTO>(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public List<GIAOVIEN> LayDSGiaoVien()
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                
                var giaovienList = connection.Query<GIAOVIEN>("LayDSGiaoVien", commandType: CommandType.StoredProcedure).AsList();
                return giaovienList;
            }
        }
      
        public List<string> GetDanhSachMonHocPhuTrach(string maGiaoVien)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                string procedureName = "GetDanhSachMonHocPhuTrach";
                var parameters = new { MAGV = maGiaoVien };
                return connection.Query<string>(procedureName, parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Nhom6_QL_DiemTHPT.DTO;
using Dapper;

namespace Nhom6_QL_DiemTHPT.DAO
{
    public class HocSinhDAO
    {
        public List<HocSinhDTO> GetAllHocSinh()
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                var hocSinhList = connection.Query<HocSinhDTO>("GetAllHocSinh", commandType: CommandType.StoredProcedure).AsList();
                return hocSinhList;
            }
        }

        public List<string> GetAllMaHS()
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                var maHSList = connection.Query<string>("SELECT MAHS FROM HOCSINH").AsList();
                return maHSList;
            }
        }

        public List<HocSinhDTO> GetHocSinhByMaLop(string maLop)
        {
            using (IDbConnection dbConnection = DBConnection.GetConnection())
            {
                dbConnection.Open();
                string query = @"
            SELECT HS.* 
            FROM HOCSINH AS HS
            INNER JOIN HOCSINH_LOP AS HS_Lop ON HS.MAHS = HS_Lop.MAHS
            WHERE HS_Lop.MALOP = @MaLop";
                return dbConnection.Query<HocSinhDTO>(query, new { MaLop = maLop }).AsList();
            }
        }
    }
}

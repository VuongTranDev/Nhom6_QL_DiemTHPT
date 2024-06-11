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
    public class XemDiemDAO
    {
        public List<XemDiemDTO> HienThiDiemTheoMaHs(string mahs, string mahk)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                string procedureName = "TimDiemHocSinh";
                var parameters = new { MAHS = mahs, MAHK = mahk };
                return connection.Query<XemDiemDTO>(procedureName, parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public HocBaDTO GetDiemTongTheoMaHS(string mahs)
        {
            using(IDbConnection connection = DBConnection.GetConnection())
            {
                string nameProcedure = "TimDiemTongKetTheoMaHS";
                var parameters = new { MAHS = mahs };
                return connection.QueryFirstOrDefault<HocBaDTO>(nameProcedure, parameters, commandType: CommandType.StoredProcedure);
            }    
        }
    }
}

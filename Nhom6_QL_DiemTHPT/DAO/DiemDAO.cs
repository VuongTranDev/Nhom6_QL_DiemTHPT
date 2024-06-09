using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom6_QL_DiemTHPT.DTO;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Nhom6_QL_DiemTHPT.DAO
{
    public class DiemDAO
    {
        public List<DiemDTO> GetDiemByMaHS(string maHS, string mahk)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                return connection.Query<DiemDTO>("GetDiemByMaHS", new { MaHS = maHS, MaHK = mahk }, commandType: CommandType.StoredProcedure).AsList();
            }
        }

        public void UpdateDiem(string maHS, string maMH, string maHK, float? diemHS1, float? diemHS2, float? diemThi)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    MaHS = maHS,
                    MaMH = maMH,
                    MaHK = maHK,
                    DiemHS1 = diemHS1,
                    DiemHS2 = diemHS2,
                    DiemThi = diemThi
                };
                connection.Execute("UpdateDiemMonHoc", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public float TinhDiemTB(string maHS)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                var parameters = new { MaHS = maHS };
                float diemTB = connection.Query<float>("TinhDiemTB", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return diemTB;
            }
        }


    }
}

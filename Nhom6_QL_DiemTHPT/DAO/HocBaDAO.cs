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
    public class HocBaDAO
    {
        public List<HocBaDTO> GetAllHocBa()
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                return connection.Query<HocBaDTO>("GetAllHocBa", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<HocBaDTO> GetHocBaByLop(string malop)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                return connection.Query<HocBaDTO>("GetHocBaByLop", new { MALOP = malop }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public bool TinhDiemTong()
        {
            try
            {
                using (IDbConnection connection = DBConnection.GetConnection())
                {
                    connection.Execute("UpdateHocBaDiem", commandType: CommandType.StoredProcedure);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool TinhXepLoaiHanhKiem()
        {
            try
            {
                using (IDbConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    connection.Execute("TinhXepLoaiVaHanhKiem", commandType: CommandType.StoredProcedure);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public string GetLastMaHB()
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                string lastMaHB = connection.QueryFirstOrDefault<string>("GetLastMaHB", commandType: CommandType.StoredProcedure);
                return lastMaHB;
            }
        }

        public void updateHocBa(string mahb, string hanhkiem, string xeploai)
        {
            using(IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                var parameters = new
                {
                    MAHB = mahb,
                    HANHKIEM = hanhkiem,
                    XEPLOAI = xeploai
                };
                connection.Execute("UpdateHocBa", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void insertHocBa(string mahb, string mahs, string hanhkiem, string xeploai, float diemhk1, float diemhk2, float diemtong)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                connection.Execute("InsertHocBa", new
                {
                    MaHB = mahb,
                    MaHS = mahs,
                    HanhKiem = hanhkiem,
                    XepLoai = xeploai,
                    DiemHK1 = diemhk1,
                    DiemHK2 = diemhk2,
                    DiemTong = diemtong
                }, commandType: CommandType.StoredProcedure);

                connection.Close();
            }
        }
    }
}
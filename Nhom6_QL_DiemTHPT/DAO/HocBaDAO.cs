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
        public List<HocBaDTO> GetHocBaByMaHS(string maHS)
        {
            List<HocBaDTO> hocBaList = new List<HocBaDTO>();

            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM HOCBA WHERE MAHS = @MaHS";
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    IDbDataParameter parameter = command.CreateParameter();
                    parameter.ParameterName = "@MaHS";
                    parameter.Value = maHS;
                    command.Parameters.Add(parameter);

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HocBaDTO hocBa = new HocBaDTO
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                MAHB = reader["MAHB"].ToString(),
                                MAHS = reader["MAHS"].ToString(),
                                XEPLOAI = reader["XEPLOAI"].ToString(),
                                HANHKIEM = reader["HANHKIEM"].ToString()
                            };
                            hocBaList.Add(hocBa);
                        }
                    }
                }
            }

            return hocBaList;
        }

        public List<HocBaDTO> GetAllHocBa()
        {
                string query = "SELECT MAHB, MAHS, XEPLOAI, HANHKIEM, DIEMHK1, DIEMHK2, DIEMTONG FROM HOCBA";

                using (IDbConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    return connection.Query<HocBaDTO>(query).ToList();
                }
        }

        public void AddHocBa(HocBaDTO hocBa)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO HOCBA (MAHS, XEPLOAI, HANHKIEM) VALUES (@MaHS, @XepLoai, @HanhKiem)";
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.Add(new SqlParameter("@MaHS", hocBa.MAHS));
                    command.Parameters.Add(new SqlParameter("@XepLoai", hocBa.XEPLOAI));
                    command.Parameters.Add(new SqlParameter("@HanhKiem", hocBa.HANHKIEM));
                    command.ExecuteNonQuery();
                }
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
            try
            {
                using (IDbConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    string lastMaHB = connection.QueryFirstOrDefault<string>("SELECT TOP 1 MAHB FROM HOCBA ORDER BY MAHB DESC");
                    return lastMaHB;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy mã học bạ cuối cùng: " + ex.Message);
                return null;
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Nhom6_QL_DiemTHPT.ASD;
using Dapper;
using System.Windows.Forms;

namespace Nhom6_QL_DiemTHPT.DAO
{
    class GiangDayDAO
    {
        public List<GIANGDAY> LayDSMonHocCuaLOP(string maLop)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                var parameters = new
                {
                    maLop
                };
                var dsMonHoc = connection.Query<GIANGDAY>("LayDSMonHocCuaLOP", parameters, commandType: CommandType.StoredProcedure).AsList();
                return dsMonHoc;
            }
        }

        public List<MONHOC> getTenMH (string mamh)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                var parameters = new
                {
                    mamh
                };
                var tenMH = connection.Query<MONHOC>("getTenMH", parameters, commandType: CommandType.StoredProcedure).AsList();
                return tenMH;
            }
        }
        public int getSLMonHocTrongLop(string malop)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                var parameters = new
                {
                    malop
                };
                int soluong = connection.ExecuteScalar<int>("getSLMonHocTrongLop", parameters, commandType: CommandType.StoredProcedure);
                return soluong;
            }
        }
        public bool PhanCongGVVaoLop(string malop, string maMH, string maGV)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                var parameters = new
                {
                    malop,
                    maMH,
                    maGV
                };
                int rowsAffected = connection.Execute("phanCongGVVaoLop", parameters, commandType: CommandType.StoredProcedure);
                return rowsAffected > 0; // Trả về true nếu có bản ghi được cập nhật, ngược lại trả về false
            }
        }

        
        public bool goPhanCongGvTaiLop(string malop,string maMH, string maGV)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                var parameters = new
                {
                    malop,
                    maMH,
                    maGV
                };
                int rowsAffected = connection.Execute("goPhanCongGvTaiLop", parameters, commandType: CommandType.StoredProcedure);
                return rowsAffected > 0; // Trả về true nếu có bản ghi được cập nhật, ngược lại trả về false
            }
        }
        public bool boNhiemGVCN(string malop, string maGV)
        {
            try
            {
                using (IDbConnection connection = DBConnection.GetConnection())
                {
                    var parameters = new
                    {
                        malop,
                        maGV
                    };
                    int rowsAffected = connection.Execute("boNhiemGVCN", parameters, commandType: CommandType.StoredProcedure);
                    return rowsAffected > 0; // Trả về true nếu có bản ghi được cập nhật, ngược lại trả về false
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // Hiển thị thông báo lỗi từ SQL Server
                return false;
            }
        }


        public List<GIANGDAY> layDSLopGVDay(string maGV)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                var parameters = new
                {
                    maGV
                };
                var dsLop = connection.Query<GIANGDAY>("layDSLopGVDay", parameters, commandType: CommandType.StoredProcedure).AsList();
                return dsLop;
            }
        }

        public string getTenGV(string maGV)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                var parameters = new
                {
                    maGV
                };
                string tenGV = connection.QuerySingleOrDefault<string>("getTenGV", parameters, commandType: CommandType.StoredProcedure);
                return tenGV;
            }
        }
        
        public string getTTGVCN(string maLop)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                var parameters = new
                {
                    maLop
                };
                string tenGV = connection.QuerySingleOrDefault<string>("getTTGVCN", parameters, commandType: CommandType.StoredProcedure);
                return tenGV;
            }
        }
    }
}


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
    public class TaiKhoanDAO
    {
        public TaiKhoanDTO GetTaiKhoan(string username, string password)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                string query = "EXEC GetTaiKhoan @Username, @Password";
                return connection.QueryFirstOrDefault<TaiKhoanDTO>(query, new { Username = username, Password = password });
            }
        }

        public string ValidateLogin(string tenDangNhap, string matKhau)
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                string procedureName = "ValidateLogin";
                var parameters = new { TenDangNhap = tenDangNhap, MatKhau = matKhau };

                return connection.QuerySingleOrDefault<string>(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

    }
}

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
    public class ThongTinCaNhanDAO
    {
        public List<ThongTinCaNhanDTO> GetNameAllHocSinh()
        {
            using (IDbConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                var hocSinhList = connection.Query<ThongTinCaNhanDTO>("GetNameAllHocSinh", commandType: CommandType.StoredProcedure).AsList();
                return hocSinhList;
            }
        }
    }
}

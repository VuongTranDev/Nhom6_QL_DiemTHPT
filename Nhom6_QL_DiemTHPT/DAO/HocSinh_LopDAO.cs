using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Nhom6_QL_DiemTHPT.DAO
{
    class HocSinh_LopDAO
    {
        public DataTable GetHSDaCoLop()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("GetHSDaCoLop", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return dataTable;
        }
        public DataTable GetHSChuaCoLop()
        {

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("GetHSChuaCoLop", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return dataTable;
        }
    }
}

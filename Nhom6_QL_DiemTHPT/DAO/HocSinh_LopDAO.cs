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
        public string newMaHocSinh()
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("TaoMaHSMoi", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@maHS", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();

                string newMaHS = command.Parameters["@maHS"].Value.ToString();

                return newMaHS;
            }
        }
        public string newMaTT()
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("TaoMaTTMoi", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@maTT", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();

                string newMaTT = command.Parameters["@maTT"].Value.ToString();

                return newMaTT;
            }
        }
        public void themHocSinh(DataTable dataTable)
        {

            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                foreach (DataRow row in dataTable.Rows)
                {
                    
                    using (SqlCommand command = new SqlCommand("ThemHocSinhMoi", connection))
                    {
                        string maHSMoi = newMaHocSinh();
                        string maTT = newMaTT();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MAHS", maHSMoi);
                        command.Parameters.AddWithValue("@DANTOC", row["DANTOC"]);
                        command.Parameters.AddWithValue("@TONGIAO", row["TONGIAO"]);
                        command.Parameters.AddWithValue("@DIACHI", row["DIACHI"]);
                        command.Parameters.AddWithValue("@MATRUONG", row["MATRUONG"]);
                        command.Parameters.AddWithValue("@MATT", maTT);
                        command.Parameters.AddWithValue("@HOTEN", row["HOTEN"]);
                        command.Parameters.AddWithValue("@GIOITINH", row["GIOITINH"]);
                        string ngaySinhString = row["NGAYSINH"].ToString();
                        ngaySinhString = ngaySinhString.Replace('/', '-');
                        DateTime ngaySinh = DateTime.ParseExact(ngaySinhString, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        command.Parameters.AddWithValue("@NGAYSINH", ngaySinh);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}

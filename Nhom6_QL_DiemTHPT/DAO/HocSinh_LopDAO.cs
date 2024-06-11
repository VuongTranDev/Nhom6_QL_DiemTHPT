using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Nhom6_QL_DiemTHPT.DTO;

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
                        DateTime ngaySinh;

                        string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "d-M-yyyy", "M/d/yyyy h:mm:ss tt", "M-d-yyyy h:mm:ss tt" };
                        if (DateTime.TryParseExact(ngaySinhString, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                        {
                            command.Parameters.AddWithValue("@NGAYSINH", ngaySinh);
                        }
                        else
                        {
                            throw new FormatException("Ngày sinh không đúng định dạng.");
                        }

                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
        }
        public void callProcXepLop(string maLop, string maHS)
        {
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("XepLopHocSinhMoi", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@MALOP", maLop));
                    command.Parameters.Add(new SqlParameter("@MAHS", maHS));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        string RandomMALOP(List<LOP> lops)
        {
            Random random = new Random();
            if (lops.Count == 0)
            {
                throw new ArgumentException("Danh sách lớp không có phần tử nào.");
            }

            int randomIndex = random.Next(0, lops.Count);
            return lops[randomIndex].MALOP;
        }
        public bool kiemTraSoLuongHS()
        {
            List<LOP> lops = layRaLopTheoNam();
            int check = 0;
            foreach (LOP item in lops)
            {
                if(item.SOLUONG > item.SOLUONGHOCSINH)
                {
                    check++;
                }
            }
            if(check == 0)
            {
                return false;
            }
            return true;
        }
        public void updateSoLuongLop(string maLop)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateSoLuongLop", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = maLop;

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Cập nhật thành công!");
                    }
                    else
                    {
                        Console.WriteLine("Không có dòng nào được cập nhật.");
                    }
                }
                connection.Close();
            }
        }
        public void xepLopHocSinhMoi()
        {
            List<LOP> lops = layRaLopTheoNam();
            List<HOCSINH> hocSinhs = layRaHocSinh();
            foreach (HOCSINH item in hocSinhs)
            {
                foreach(LOP lop in lops)
                {
                    if(kiemTraSoLuongHS() == false)
                    {
                        updateSoLuongLop(lop.MALOP);
                    }
                    string maLop = RandomMALOP(lops);
                    callProcXepLop(maLop, item.MAHS);
                }
            }
        }

        public List<HOCSINH> layRaHocSinh()
        {
            List<HOCSINH> listHocSinh = new List<HOCSINH>();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("GetHSChuaCoLop", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HOCSINH hs = new HOCSINH();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                hs.MAHS = reader["MAHS"].ToString();
                            }
                            listHocSinh.Add(hs);
                        }
                    }
                }
                connection.Close();
            }
            return listHocSinh;
        }
        public List<LOP> layRaLopTheoNam()
        {
            List<LOP> lops = new List<LOP>();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LayLopTheoNam", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                LOP lop = new LOP();
                                lop.MALOP = reader["MALOP"].ToString();
                                lop.NIENKHOA = Convert.ToInt32(reader["NIENKHOA"].ToString());
                                lop.TENLOP = reader["TENLOP"].ToString();
                                lop.SOLUONG = Convert.ToInt32(reader["SOLUONG"].ToString());
                                lop.SOLUONGHOCSINH = Convert.ToInt32(reader["SOLUONGHOCSINH"].ToString());
                                lops.Add(lop);
                            }
                        }
                    }
                }
                connection.Close();
            }
            return lops;
        }
    }
}

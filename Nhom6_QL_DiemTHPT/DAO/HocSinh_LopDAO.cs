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
        public DataTable GetTatCaHocSinh()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("GetTatCaHocSinh", connection))
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
        public DataTable GetHocSinhTheoTinhTrang(string tinhTrang)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("GetHocSinhTheoTinhTrang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TINHTRANG", tinhTrang);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return dataTable;
        }
        public DataTable GetHocSinhTheoLopNamHoc(string maLop)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("GetHocSinhTheoLopNamHoc", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MALOP", maLop);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return dataTable;
        }
        public DataTable GetTatCaHocSinhCoLop()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("GetTatCaHocSinhCoLop", connection))
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
                string maLop = RandomMALOP(lops);
                if (kiemTraSoLuongHS() == false)
                {
                    updateSoLuongLop(maLop);
                }
                callProcXepLop(maLop, item.MAHS);
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
                            hs.MAHS = reader["MAHS"].ToString();
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
                connection.Close();
            }
            return lops;
        }
        public void layRaLopCuaHocSinh(string maHS)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("LayRaLopCuaHocSinh", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = maHS;

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void capNhatHocSinhLenLop10(string maHS)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateHocSinhLenLop10", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = maHS;

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void capNhatHocSinhLenLop11(string maHS)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateHocSinhLenLop11", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = maHS;

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void capNhatHocSinhLenLop12(string maHS)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateHocSinhLenLop12", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = maHS;

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public List<HOCSINH_LOP> layRaHocSinhLenLop10()
        {
            List<HOCSINH_LOP> listHocSinh = new List<HOCSINH_LOP>();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LayRaHocSinhLenLop10", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HOCSINH_LOP hs_lop = new HOCSINH_LOP();
                            hs_lop.MAHS = reader["MAHS"].ToString();
                            listHocSinh.Add(hs_lop);
                        }
                    }
                }
                connection.Close();
            }
            return listHocSinh;
        }
        public List<HOCSINH_LOP> layRaHocSinhLenLop11()
        {
            List<HOCSINH_LOP> listHocSinh = new List<HOCSINH_LOP>();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LayRaHocSinhLenLop11", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HOCSINH_LOP hs_lop = new HOCSINH_LOP();
                            hs_lop.MAHS = reader["MAHS"].ToString();
                            listHocSinh.Add(hs_lop);
                        }
                    }
                }
                connection.Close();
            }
            return listHocSinh;
        }
        public void lenLopHocSinh()
        {
            List<HOCSINH_LOP> listHocSinh10 = layRaHocSinhLenLop10();
            List<HOCSINH_LOP> listHocSinh11 = layRaHocSinhLenLop11();

            foreach(HOCSINH_LOP item in listHocSinh10)
            {
                capNhatHocSinhLenLop11(item.MAHS);
            }
            foreach(HOCSINH_LOP item in listHocSinh11)
            {
                capNhatHocSinhLenLop12(item.MAHS);
            }
        }

        // Lưu Ban
        public List<HOCSINH_LOP> layRaHocSinhLuuBan10()
        {
            List<HOCSINH_LOP> listHocSinh = new List<HOCSINH_LOP>();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LayRaHocSinhLuuBan10", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HOCSINH_LOP hs_lop = new HOCSINH_LOP();
                            hs_lop.MAHS = reader["MAHS"].ToString();
                            listHocSinh.Add(hs_lop);
                        }
                    }
                }
                connection.Close();
            }
            return listHocSinh;
        }
        public List<HOCSINH_LOP> layRaHocSinhLuuBan11()
        {
            List<HOCSINH_LOP> listHocSinh = new List<HOCSINH_LOP>();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LayRaHocSinhLuuBan11", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HOCSINH_LOP hs_lop = new HOCSINH_LOP();
                            hs_lop.MAHS = reader["MAHS"].ToString();
                            listHocSinh.Add(hs_lop);
                        }
                    }
                }
                connection.Close();
            }
            return listHocSinh;
        }
        public List<HOCSINH_LOP> layRaHocSinhLuuBan12()
        {
            List<HOCSINH_LOP> listHocSinh = new List<HOCSINH_LOP>();
            using (SqlConnection connection = (SqlConnection)DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LayRaHocSinhLuuBan12", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HOCSINH_LOP hs_lop = new HOCSINH_LOP();
                            hs_lop.MAHS = reader["MAHS"].ToString();
                            listHocSinh.Add(hs_lop);
                        }
                    }
                }
                connection.Close();
            }
            return listHocSinh;
        }
        public void capNhatHocSinhLuuBan10(string maHS)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateHocSinhLuuBanLop10", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = maHS;

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void capNhatHocSinhLuuBan11(string maHS)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateHocSinhLuuBanLop11", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = maHS;

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void capNhatHocSinhLuuBan12(string maHS)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateHocSinhLuuBanLop12", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = maHS;

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void luuBanHocSinh()
        {
            List<HOCSINH_LOP> listHocSinh10 = layRaHocSinhLuuBan10();
            List<HOCSINH_LOP> listHocSinh11 = layRaHocSinhLuuBan11();
            List<HOCSINH_LOP> listHocSinh12 = layRaHocSinhLuuBan12();

            if(listHocSinh10.Count > 0)
            {
                foreach (HOCSINH_LOP item in listHocSinh10)
                {
                    capNhatHocSinhLuuBan10(item.MAHS);
                }
            }
            if(listHocSinh11.Count > 0)
            {
                foreach (HOCSINH_LOP item in listHocSinh11)
                {
                    capNhatHocSinhLuuBan11(item.MAHS);
                }
            }
            if (listHocSinh12.Count > 0)
            {
                foreach (HOCSINH_LOP item in listHocSinh11)
                {
                    capNhatHocSinhLuuBan12(item.MAHS);
                }
            }

        }
        public void xepLopTheoDieuKien(string maHS, string maLop)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateHocSinhTheoDieuKien", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = maHS;
                    command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = maLop;

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public string layMaLopKhiCoTenLop(string tenLop, int nienKhoa)
        {
            string maLop = "";
            using (SqlConnection connection = new SqlConnection(DBConnection.getConStr()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("LayRaMaLopKhiCoTenLop", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = tenLop;
                    command.Parameters.Add("@NIENKHOA", SqlDbType.Int).Value = nienKhoa;

                    SqlParameter parameter = new SqlParameter("@MALOP", SqlDbType.VarChar, 20);
                    parameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(parameter);

                    command.ExecuteNonQuery();

                    maLop = command.Parameters["@MALOP"].Value.ToString();
                }
                connection.Close();
            }
            return maLop;
        }

    }
}

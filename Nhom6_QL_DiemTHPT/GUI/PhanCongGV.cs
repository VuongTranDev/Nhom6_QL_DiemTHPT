using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom6_QL_DiemTHPT.DTO;
using Nhom6_QL_DiemTHPT.DAO;
namespace Nhom6_QL_DiemTHPT.GUI
{
    public partial class PhanCongGV : Form
    {
        private readonly GiaoVienDAO giaovienDAO;
        private readonly LopDAO lopDAO;
        private readonly GiangDayDAO giangdayDAO;

        private string maGV;
        private string maMH;
        private string maGVLOP;
        public PhanCongGV()
        {
            InitializeComponent();
            giaovienDAO = new GiaoVienDAO();
            lopDAO = new LopDAO();
            giangdayDAO = new GiangDayDAO();
        }

  

        private void HienThiDSGiaoVien()
        {
            List<GIAOVIEN> giaovienList = giaovienDAO.LayDSGiaoVien();
            dtgvDSGV.DataSource = giaovienList;
            dtgvDSGV.Columns.Clear();

            dtgvDSGV.Columns.Add("MAGV", "Mã Giáo Viên");
            dtgvDSGV.Columns["MAGV"].DataPropertyName = "MAGV";

            dtgvDSGV.Columns.Add("HOTEN", "Tên Giáo Viên");
            dtgvDSGV.Columns["HOTEN"].DataPropertyName = "HOTEN";

            dtgvDSGV.Columns.Add("CHUYENMON", "Chuyên Môn");
            dtgvDSGV.Columns["CHUYENMON"].DataPropertyName = "CHUYENMON";
        }
        private void HienThiTenLop()
        {
            cbLop.Items.Clear();
            List<LopDTO> lopList = lopDAO.GetLop();

            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
            cbLop.DataSource = lopList;

        
        }
        private void HienThiDSLopday(string magv)
        {
            cbDSLopDay.DataSource = null; // Xóa dữ liệu nguồn hiện tại
            cbDSLopDay.Items.Clear(); // Xóa tất cả các mục hiện tại (nếu có)
            List<GIANGDAY> lopgvList = giangdayDAO.layDSLopGVDay(magv);
            cbDSLopDay.DisplayMember = "TENLOP";
            cbDSLopDay.ValueMember = "MALOP";
            cbDSLopDay.DataSource = lopgvList;
        }
        private void HienThiMonHocChoLop(string malop)
        {

                List<GIANGDAY> giangdayList = giangdayDAO.LayDSMonHocCuaLOP(malop);

                dtgvGiangDay.DataSource = giangdayList;
                dtgvGiangDay.Columns.Clear();

                // Thiết lập các cột cho DataGridView
                dtgvGiangDay.Columns.Add("MAMH", "Mã Môn Học");
                dtgvGiangDay.Columns["MAMH"].DataPropertyName = "MAMH";
                dtgvGiangDay.Columns.Add("TENMH", "Tên Môn Học");
                dtgvGiangDay.Columns["TENMH"].DataPropertyName = "TENMH";
                dtgvGiangDay.Columns.Add("MAGV", "Mã Giáo Viên");
                dtgvGiangDay.Columns["MAGV"].DataPropertyName = "MAGV";
           
        }


        private void BindTextBoxes()
        {

            txtTenGV.DataBindings.Clear();
            txtChuyenMon.DataBindings.Clear();
            txtTenGV.DataBindings.Add("Text", dtgvDSGV.DataSource, "HOTEN");
            txtChuyenMon.DataBindings.Add("Text", dtgvDSGV.DataSource, "CHUYENMON");
           
        }
        private void PhanCongGV_Load(object sender, EventArgs e)
        {
            HienThiTenLop();
            HienThiDSGiaoVien();
            BindTextBoxes();
           
        }
        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLop.SelectedValue != null)
            {
                string malop = cbLop.SelectedValue.ToString();
                if (malop != null)
                {
                    HienThiMonHocChoLop(malop);
                    txtTenMH.DataBindings.Clear();
                    txtTenMH.DataBindings.Add("Text", dtgvGiangDay.DataSource, "TENMH");
                    txtChuNhiem.Text = giangdayDAO.getTTGVCN(malop);
                }
               
            }
        }

        private void dtgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvDSGV.Rows[e.RowIndex];
                maGV = row.Cells["MAGV"].Value.ToString();
                HienThiDSLopday(maGV);
            }
        }
        private void dtgvGiangDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvGiangDay.Rows[e.RowIndex];
                maMH = row.Cells["MAMH"].Value?.ToString(); // Sử dụng dấu ? để kiểm tra null trước

                var magvCellValue = row.Cells["MAGV"].Value;
                maGVLOP = magvCellValue != null ? magvCellValue.ToString() : null; // Kiểm tra null trước khi chuyển đổi
                
            }
        }

        private bool CheckExistingGV(string maGV)
        {
            foreach (DataGridViewRow row in dtgvGiangDay.Rows)
            {
                if (row.Cells["MAGV"].Value != null && row.Cells["MAGV"].Value.ToString() == maGV)
                {
                    return true; // Đã tồn tại MAGV trong dtgvGiangDay
                }
            }
            return false; // Không tồn tại MAGV trong dtgvGiangDay
        }

        private void btnPhanCongGV_Click(object sender, EventArgs e)
        {
            string malop = cbLop.SelectedValue.ToString();

            if (txtTenMH.Text.Contains(txtChuyenMon.Text))
            {
                if (!CheckExistingGV(maGV))
                {
                    if (giangdayDAO.PhanCongGVVaoLop(malop, maMH, maGV))
                    {
                        MessageBox.Show("Cập nhật thành công");

                        // Tìm chỉ mục của dòng tương ứng trong dtgvGiangDay
                        foreach (DataGridViewRow row in dtgvGiangDay.Rows)
                        {
                            if (row.Cells["MAMH"].Value.ToString() == maMH)
                            {
                                row.Cells["MAGV"].Value = maGV; // Cập nhật giáo viên
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật được");
                    }
                }
                else
                {
                    MessageBox.Show("Giáo viên đã được phân công cho môn này");
                }
            }
            else
            {
                MessageBox.Show("Môn này không nằm trong chuyên môn của giáo viên");
            }
        }

        private void btnGoPhanCong_Click(object sender, EventArgs e)
        {
            string malop = cbLop.SelectedValue.ToString();
            if (maGVLOP != null)
            {
                if (giangdayDAO.goPhanCongGvTaiLop(malop, maMH,maGVLOP))
                {
                    MessageBox.Show("Gỡ bỏ thành công");

                    // Tìm chỉ mục của dòng tương ứng trong dtgvGiangDay và cập nhật
                    foreach (DataGridViewRow row in dtgvGiangDay.Rows)
                    {
                        if (row.Cells["MAMH"].Value.ToString() == maMH)
                        {
                            row.Cells["MAGV"].Value = null; // Xóa mã giáo viên
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Gỡ thất bại");
                }
            }
            else
            {
                MessageBox.Show("Môn này chưa có giáo viên giảng dạy");
            }
        }

        private void btnboNhiemGVCN_Click(object sender, EventArgs e)
        {
            string malop = cbLop.SelectedValue.ToString();

            // Kiểm tra nếu TextBox chu nhiệm đã có giá trị
            if (string.IsNullOrWhiteSpace(txtChuNhiem.Text))
            {
                if (!string.IsNullOrEmpty(maGVLOP))
                {
                    if (giangdayDAO.boNhiemGVCN(malop, maGVLOP))
                    {
                        MessageBox.Show("Bổ nhiệm thành công");
                        txtChuNhiem.Text = giangdayDAO.getTTGVCN(malop);
                    }
                    else
                    {
                        MessageBox.Show("Không thể bổ nhiệm giáo viên");
                    }
                }
                else
                {
                    MessageBox.Show("Giáo viên được phân công phải dạy lớp này");
                }
            }
            else
            {
                MessageBox.Show("Lớp này đã có giáo viên chủ nhiệm");
            }
        }


    }
}

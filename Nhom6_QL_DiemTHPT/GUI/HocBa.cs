using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom6_QL_DiemTHPT.DAO;
using Nhom6_QL_DiemTHPT.DTO;

namespace Nhom6_QL_DiemTHPT.GUI
{
    public partial class HocBa : Form
    {
        private readonly HocBaDAO hocBaDAO = new HocBaDAO();
        private readonly HocSinhDAO hocSinhDAO= new HocSinhDAO();
        private readonly LopDAO lopDAO = new LopDAO();
        public HocBa()     
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void HocBa_Load(object sender, EventArgs e)
        {
            //loadDataGridView();
            loadCboXepLoai();
            loadCboHanhKiem();
            loadMaHS();
            loadCboLop();
            loadDataGridView();
        }

        private void loadDataGridView(string malop = null)
        {
            List<HocBaDTO> hocBaList;

            if (string.IsNullOrEmpty(malop))
            {
                hocBaList = hocBaDAO.GetAllHocBa();
            }
            else
            {
                hocBaList = hocBaDAO.GetHocBaByLop(malop);
            }

            dataGridView1.DataSource = hocBaList;
        }


        private void btnTinhDiemTong_Click(object sender, EventArgs e)
        {
            string maGiaoVien = Prompt.ShowDialog("Nhập mã giáo viên để tính điểm tổng học bạ:", "Xác nhận mã giáo viên");

            if (!IsValidGiaoVienChuNhiem(maGiaoVien))
            {
                MessageBox.Show("Mã giáo viên không hợp lệ hoặc không có quyền tính điểm học bạ học bạ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hocBaDAO.TinhDiemTong())
            {
                var malop = cbo_Lop.SelectedItem as LopDTO;
                if (malop != null)
                {
                    loadDataGridView(malop.MaLop);
                }
                MessageBox.Show("Đã cập nhật điểm thành công!");
            }
        }

        private void btnTinhXepLoai_Click(object sender, EventArgs e)
        {
            string maGiaoVien = Prompt.ShowDialog("Nhập mã giáo viên để xếp loại học bạ:", "Xác nhận mã giáo viên");

            if (!IsValidGiaoVienChuNhiem(maGiaoVien))
            {
                MessageBox.Show("Mã giáo viên không hợp lệ hoặc không có quyền xếp loại học bạ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hocBaDAO.TinhXepLoaiHanhKiem();
            var malop = cbo_Lop.SelectedItem as LopDTO;
            if (malop != null)
            {
                loadDataGridView(malop.MaLop);
            }
            MessageBox.Show("Đã cập nhật xếp loại và hạnh kiểm thành công!");
        }

        private void loadCboXepLoai()
        {
            string[] xepLoai = { "Giỏi", "Khá", "Trung Bình", "Yếu" };
            cboXepLoai.Items.Clear();
            cboXepLoai.Items.AddRange(xepLoai);
            cboXepLoai.SelectedIndex = 0;
        }

        private void loadCboHanhKiem()
        {
            string[] HanhKiem = { "Tốt", "Khá", "Yếu" };
            cboHanhKiem.Items.Clear();
            cboHanhKiem.Items.AddRange(HanhKiem);
            cboHanhKiem.SelectedIndex = 0;
        }

        private void loadMaHS()
        {
            var maHSList = hocSinhDAO.GetAllMaHS();
            cboMaHS.DataSource = maHSList;
        }

        private void loadCboLop()
        {
            cbo_Lop.Items.Clear();
            List<LopDTO> lopList = lopDAO.GetLop();

            cbo_Lop.DisplayMember = "TENLOP";
            cbo_Lop.ValueMember = "MALOP";
            cbo_Lop.DataSource = lopList;

            cbo_Lop.SelectedIndexChanged += Cbo_Lop_SelectedIndexChanged;
        }

        private void Cbo_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLop = cbo_Lop.SelectedValue.ToString();
            loadDataGridView(selectedLop);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                txtMAHB.Text = row.Cells["MAHB"].Value.ToString();
                txtDiemHk1.Text = row.Cells["DIEMHK1"].Value.ToString();
                txtDiemHK2.Text = row.Cells["DIEMHK2"].Value.ToString();
                txtDiemTong.Text = row.Cells["DIEMTONG"].Value.ToString();
                string mahs = row.Cells["MAHS"].Value.ToString();
                cboMaHS.SelectedItem = mahs;

                string xepLoai = row.Cells["XEPLOAI"].Value.ToString();
                if (cboXepLoai.Items.Contains(xepLoai))
                {
                    cboXepLoai.SelectedItem = xepLoai;
                }
                else
                {
                    cboXepLoai.SelectedIndex = -1;
                }

                string hanhKiem = row.Cells["HANHKIEM"].Value.ToString();
                if (cboHanhKiem.Items.Contains(hanhKiem))
                {
                    cboHanhKiem.SelectedItem = hanhKiem;
                }
                else
                {
                    cboHanhKiem.SelectedIndex = -1;
                }
            }
        }

        private void btnTaoMaHB_Click(object sender, EventArgs e)
        {
            try
            {
                string lastMaHB = hocBaDAO.GetLastMaHB();
                if (!string.IsNullOrEmpty(lastMaHB))
                {
                    int lastNumber = int.Parse(lastMaHB.Substring(2));
                    string newMaHB = "HB" + (lastNumber + 1);
                    txtMAHB.Text = newMaHB;
                }
                else
                {
                    MessageBox.Show("Không thể tạo mã học bạ mới.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã học bạ mới: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maGiaoVien = Prompt.ShowDialog("Nhập mã giáo viên để sửa học bạ:", "Xác nhận mã giáo viên");

            if (!IsValidGiaoVienChuNhiem(maGiaoVien))
            {
                MessageBox.Show("Mã giáo viên không hợp lệ hoặc không có quyền sửa học bạ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string maHB = txtMAHB.Text;
                string hanhKiem = cboHanhKiem.SelectedItem?.ToString();
                string xepLoai = cboXepLoai.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(maHB) && !string.IsNullOrEmpty(hanhKiem) && !string.IsNullOrEmpty(xepLoai))
                {
                    hocBaDAO.updateHocBa(maHB, hanhKiem, xepLoai);

                    MessageBox.Show("Cập nhật học bạ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var selectedLop = cbo_Lop.SelectedItem as LopDTO;
                    if (selectedLop != null)
                    {
                        loadDataGridView(selectedLop.MaLop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật học bạ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maGiaoVien = Prompt.ShowDialog("Nhập mã giáo viên để thêm học bạ:", "Xác nhận mã giáo viên");

            string maHB = txtMAHB.Text;
            string maHS = cboMaHS.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(maHB) && !string.IsNullOrEmpty(maHS))
            {
                if (!IsValidGiaoVienChuNhiem(maGiaoVien))
                {
                    MessageBox.Show("Mã giáo viên không hợp lệ hoặc không có quyền thêm học bạ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    hocBaDAO.insertHocBa(maHB, maHS, "Chưa xét", "Chưa xét", 0, 0, 0);
                    MessageBox.Show("Thêm mới học bạ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var selectedLop = cbo_Lop.SelectedItem as LopDTO;
                    if (selectedLop != null)
                    {
                        loadDataGridView(selectedLop.MaLop);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm mới học bạ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsValidGiaoVienChuNhiem(string maGiaoVien)
        {
            LopDTO giaoVienChuNhiem = lopDAO.GetGiaoVienChuNhiem(maGiaoVien);

            if (giaoVienChuNhiem == null)
            {
                return false;
            }

            LopDTO selectedLop = cbo_Lop.SelectedItem as LopDTO;
            if (giaoVienChuNhiem.MaGVCN == selectedLop.MaGVCN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static class PromptGVCN
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}

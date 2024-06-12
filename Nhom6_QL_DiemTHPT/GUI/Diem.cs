using Nhom6_QL_DiemTHPT.DAO;
using Nhom6_QL_DiemTHPT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nhom6_QL_DiemTHPT.GUI
{
    public partial class Diem : Form
    {
        private readonly HocSinhDAO hocSinhDAO;
        private readonly ThongTinCaNhanDAO thongTinCaNhanDAO;
        private readonly DiemDAO diemDAO;
        private readonly HocKyDAO hocKyDAO;
        private readonly LopDAO lopDAO;
        private readonly GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
        private string currentMaHS;

        public Diem()
        {
            InitializeComponent();
            thongTinCaNhanDAO = new ThongTinCaNhanDAO();
            hocSinhDAO = new HocSinhDAO();
            diemDAO = new DiemDAO();
            hocKyDAO = new HocKyDAO();
            lopDAO = new LopDAO();
        }

        private void HienThiHocSinh(List<HocSinhDTO> hocSinhList)
        {
            treeView1.Nodes.Clear();
            List<ThongTinCaNhanDTO> thongTinCaNhanList = thongTinCaNhanDAO.GetNameAllHocSinh();
            foreach (HocSinhDTO hocSinh in hocSinhList)
            {
                string maTT = hocSinh.MaTT;
                ThongTinCaNhanDTO thongTinCaNhan = thongTinCaNhanList.FirstOrDefault(tt => tt.MaTT == maTT);

                if (thongTinCaNhan != null)
                {
                    string tenHocSinh = thongTinCaNhan.HoTen;
                    string maHS = hocSinh.MaHS;

                    TreeNode node = new TreeNode(tenHocSinh);
                    node.Tag = maHS;
                    treeView1.Nodes.Add(node);
                }
            }
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            LoadCboHocKy();
            LoadCboLop();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string maHocSinh = e.Node.Tag as string;
            currentMaHS = maHocSinh;
            if (!string.IsNullOrEmpty(maHocSinh))
            {
                var selectedHocKy = cboHK.SelectedItem as HocKyDTO;
                if (selectedHocKy != null)
                {
                    lb_MaHS.Text = maHocSinh;
                    lb_TenHS.Text = e.Node.Text;
                    HienThiBangDiem(maHocSinh, selectedHocKy.MAHK);
                }
            }
        }

        private void LoadCboHocKy()
        {
            cboHK.Items.Clear();
            List<HocKyDTO> hocKyList = hocKyDAO.GetHocKy();

            cboHK.DisplayMember = "TENHK";
            cboHK.ValueMember = "MAHK";
            cboHK.DataSource = hocKyList;

            cboHK.SelectedIndexChanged += cboHK_SelectedIndexChanged;
        }

        private void LoadCboLop()
        {
            cboLop.Items.Clear();
            List<LopDTO> lopList = lopDAO.GetLop();

            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
            cboLop.DataSource = lopList;

            cboLop.SelectedIndexChanged += cboHK_SelectedIndexChanged;
        }

        private void cboHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentMaHS))
            {
                var selectedHocKy = cboHK.SelectedItem as HocKyDTO;
                if (selectedHocKy != null)
                {
                    HienThiBangDiem(currentMaHS, selectedHocKy.MAHK);
                }
            }
        }

        private void HienThiBangDiem(string maHS, string mahk)
        {
                List<DiemDTO> diemList = diemDAO.GetDiemByMaHS(maHS, mahk);
                dataGridView1.DataSource = diemList;

                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("MAMH", "Mã Môn học");
                dataGridView1.Columns["MAMH"].DataPropertyName = "MAMH";

                dataGridView1.Columns.Add("TENMH", "Môn học");
                dataGridView1.Columns["TENMH"].DataPropertyName = "TENMH";

            dataGridView1.Columns.Add("MAHK", "Học kỳ");
            dataGridView1.Columns["MAHK"].DataPropertyName = "MAHK";

            dataGridView1.Columns.Add("DIEMHS1", "Điểm HS1");
            dataGridView1.Columns["DIEMHS1"].DataPropertyName = "DIEMHS1";

            dataGridView1.Columns.Add("DIEMHS2", "Điểm HS2");
            dataGridView1.Columns["DIEMHS2"].DataPropertyName = "DIEMHS2";

            dataGridView1.Columns.Add("DIEMTHI", "Điểm thi");
            dataGridView1.Columns["DIEMTHI"].DataPropertyName = "DIEMTHI";

            dataGridView1.Columns.Add("DIEMTB", "Điểm TB");
            dataGridView1.Columns["DIEMTB"].DataPropertyName = "DIEMTB";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {

                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                txtMAMH.Text = row.Cells["MAMH"].Value.ToString();
                txtTenMH.Text = row.Cells["TENMH"].Value.ToString();
                txtDiemHS1.Text = row.Cells["DIEMHS1"].Value.ToString();
                txtDiemHS2.Text = row.Cells["DIEMHS2"].Value.ToString();
                txtDiemThi.Text = row.Cells["DIEMTHI"].Value.ToString();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdateDiem_Click(object sender, EventArgs e)
        {
            string maGiaoVien = Prompt.ShowDialog("Nhập mã giáo viên để sửa điểm:", "Xác nhận mã giáo viên");

            if (dataGridView1.CurrentRow != null)
            {
                string maMonHoc = dataGridView1.CurrentRow.Cells["MAMH"].Value.ToString();

                if (!IsValidGiaoVien(maGiaoVien, maMonHoc))
                {
                    MessageBox.Show("Mã giáo viên không hợp lệ hoặc không có quyền sửa điểm môn học này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        string maHS = lb_MaHS.Text;
                        string maMH = maMonHoc;
                        string maHK = row.Cells["MAHK"].Value.ToString();
                        float? diemHS1 = string.IsNullOrEmpty(txtDiemHS1.Text) ? (float?)null : Convert.ToSingle(txtDiemHS1.Text);
                        float? diemHS2 = string.IsNullOrEmpty(txtDiemHS2.Text) ? (float?)null : Convert.ToSingle(txtDiemHS2.Text);
                        float? diemThi = string.IsNullOrEmpty(txtDiemThi.Text) ? (float?)null : Convert.ToSingle(txtDiemThi.Text);

                        diemDAO.UpdateDiem(maHS, maMH, maHK, diemHS1, diemHS2, diemThi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                HienThiBangDiem(lb_MaHS.Text, ((HocKyDTO)cboHK.SelectedItem).MAHK);
                MessageBox.Show("Đã cập nhật điểm thành công!");
            }
            else
            {
                MessageBox.Show("Không có dòng nào được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedIndex != -1)
            {
                string maLop = cboLop.SelectedValue.ToString();
                List<HocSinhDTO> hocSinhTheoLop = hocSinhDAO.GetHocSinhByMaLop(maLop);
                HienThiHocSinh(hocSinhTheoLop);
            }
            else
            {
                HienThiHocSinh(hocSinhDAO.GetAllHocSinh());
            }
        }

        private bool IsValidGiaoVien(string maGiaoVien, string maMonHoc)
        {
            GiaoVienDTO giaoVien = giaoVienDAO.GetGiaoVien(maGiaoVien);

            if (giaoVien == null)
            {
                return false;
            }

            List<string> dsMonHocPhuTrach = giaoVienDAO.GetDanhSachMonHocPhuTrach(maGiaoVien);

            return dsMonHocPhuTrach.Contains(maMonHoc);
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }
    }

    public static class Prompt
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

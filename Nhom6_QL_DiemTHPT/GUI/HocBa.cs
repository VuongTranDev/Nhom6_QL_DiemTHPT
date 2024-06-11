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
        }
        private void HocBa_Load(object sender, EventArgs e)
        {
            //loadDataGridView();
            loadCboXepLoai();
            loadCboHanhKiem();
            loadMaHS();
            loadCboLop();
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
                cboXepLoai.SelectedItem = xepLoai;
                string hanhKiem = row.Cells["HANHKIEM"].Value.ToString();
                cboHanhKiem.SelectedItem = hanhKiem;
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
    }
}

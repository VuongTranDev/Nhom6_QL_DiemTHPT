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
        private readonly HocBaDAO hocBaDAO;
        private readonly HocSinhDAO hocSinhDAO;
        public HocBa()
        {
            InitializeComponent();
            hocBaDAO = new HocBaDAO();
            hocSinhDAO = new HocSinhDAO();
        }
        private void HocBa_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadCboXepLoai();
            loadCboHanhKiem();
            loadMaHS();
        }

        private void loadDataGridView()
        {
            List<HocBaDTO> hocBaList = hocBaDAO.GetAllHocBa();
            dataGridView1.DataSource = hocBaList;
        }

        private void btnTinhDiemTong_Click(object sender, EventArgs e)
        {
            if(hocBaDAO.TinhDiemTong())
            {
                loadDataGridView();
                MessageBox.Show("Đã cập nhật điểm thành công!");
            }
            
        }

        private void btnTinhXepLoai_Click(object sender, EventArgs e)
        {
            hocBaDAO.TinhXepLoaiHanhKiem();
            loadDataGridView();
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

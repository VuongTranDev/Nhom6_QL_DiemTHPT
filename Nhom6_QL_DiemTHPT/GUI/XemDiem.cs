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
    public partial class XemDiem : Form
    {
        private readonly ThongTinHocSinhDAO thongTinHocSinhDAO = new ThongTinHocSinhDAO();
        private readonly XemDiemDAO xemDiemDAO = new XemDiemDAO();
        private readonly HocKyDAO hocKyDAO = new HocKyDAO();
        private readonly HocBaDAO hocBaDAO = new HocBaDAO();
        public XemDiem()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mahs = txtSearch.Text;
            ThongTinHocSinhDTO hocSinh = thongTinHocSinhDAO.GetThongTinHocSinh(mahs);

            if (hocSinh != null)
            {
                lb_MAHS.Text = hocSinh.MaHS;
                lb_TenHS.Text = hocSinh.HoTen;
                lb_GioiTinh.Text = hocSinh.GioiTinh;
                lb_NgaySinh.Text = hocSinh.NgaySinh;
                lb_DanToc.Text = hocSinh.DanToc;
                lb_DiaChi.Text = hocSinh.DiaChi;
                lb_TonGiao.Text = hocSinh.TonGiao;
                lb_Lop.Text = hocSinh.TenLop;

                var selectedHocKy = cbo_hocKy.SelectedItem as HocKyDTO;
                if (selectedHocKy != null)
                {
                    loadDiemMonHoc(mahs, selectedHocKy.MAHK);
                }

                HocBaDTO diem = xemDiemDAO.GetDiemTongTheoMaHS(mahs);
                lb_DiemHK1.Text = diem.DIEMHK1.ToString();
                lb_DiemHK2.Text = diem.DIEMHK2.ToString();
                lb_DiemTong.Text = diem.DIEMTONG.ToString();
                lb_HanhKiem.Text = diem.HANHKIEM;
                lb_HocLuc.Text = diem.XEPLOAI;
            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh!");
            }
        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            LoadCboHocKy();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void loadDiemMonHoc(string mahs, string mahk)
        {
            dataGridView1.Columns.Clear();
            List<XemDiemDTO> diemList = xemDiemDAO.HienThiDiemTheoMaHs(mahs, mahk);

            if (diemList != null)
            {
                dataGridView1.DataSource = diemList;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu điểm cho học sinh này!");
                ClearDataGridView();
            }
        }

        private void ClearDataGridView()
        {

            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
        }

        private void LoadCboHocKy()
        {
            cbo_hocKy.Items.Clear();
            List<HocKyDTO> hocKyList = hocKyDAO.GetHocKy();
            foreach (var hocKy in hocKyList)
            {
                cbo_hocKy.Items.Add(hocKy);
            }
            cbo_hocKy.DisplayMember = "TENHK";
            cbo_hocKy.ValueMember = "MAHK";
            cbo_hocKy.SelectedIndexChanged += cboHK_SelectedIndexChanged;
            cbo_hocKy.SelectedIndex = 0;
        }

        private void cboHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentMaHS = lb_MAHS.Text;

            var selectedHocKy = cbo_hocKy.SelectedItem as HocKyDTO;
            if (selectedHocKy != null)
            {
                
                loadDiemMonHoc(currentMaHS, selectedHocKy.MAHK);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                switch (column.Name)
                {
                    case "TENMH":
                        e.Value = "Tên môn học";
                        break;
                    case "DIEMHS1":
                        e.Value = "Điểm HS1";
                        break;
                    case "DIEMHS2":
                        e.Value = "Điểm HS2";
                        break;
                    case "DIEMTHI":
                        e.Value = "Điểm thi";
                        break;
                    case "DIEMTB":
                        e.Value = "Điểm TB";
                        break;
                    default:
                        break;
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

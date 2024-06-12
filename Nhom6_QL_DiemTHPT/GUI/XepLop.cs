using ExcelDataReader;
using Nhom6_QL_DiemTHPT.DAO;
using Nhom6_QL_DiemTHPT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nhom6_QL_DiemTHPT.GUI
{
    public partial class XepLop : Form
    {
        LopDAO lopDAO = new LopDAO();
        HocSinh_LopDAO hocSinh_LopDAO = new HocSinh_LopDAO();
        public XepLop()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void dataBingDing(DataTable pDT)
        {
            txt_MaHocSinh.DataBindings.Clear();

            txt_MaHocSinh.DataBindings.Add("Text", pDT, "MAHS");

            txt_TenHocSinh.DataBindings.Clear();

            txt_TenHocSinh.DataBindings.Add("Text", pDT, "HOTEN");

            txt_NamHoc.DataBindings.Clear();

            txt_TinhTrang.DataBindings.Clear();

            txt_TinhTrang.DataBindings.Add("Text", pDT, "TINHTRANG");


        }
        void loadCboTinhTrang()
        {
            string[] tinhTrangs = { "Tất cả", "Lên lớp", "Lưu ban", "Mới", "Đang học" };

            cbo_DanhSachHocSinhTT.DataSource = tinhTrangs;
        }
        void loadCboLop()
        {
            List<LopDTO> lopList = lopDAO.GetLop();
            LopDTO tatCaLop = new LopDTO
            {
                MaLop = "0", 
                TenLop = "Tất cả"
            };

            lopList.Insert(0, tatCaLop);
            cbo_Lop.DisplayMember = "TENLOP";
            cbo_Lop.ValueMember = "MALOP";
            
            cbo_Lop.DataSource = lopList;

            cbo_Lop.SelectedValue = "0";
        }
        void loadDGV_HocSinh()
        {
            DataTable data = hocSinh_LopDAO.GetTatCaHocSinhCoLop();
            dgv_DanhSachHocSinh.DataSource = data;
            dataBingDing(data);
            cbo_Lop.DataBindings.Add("Text", data, "TENLOP");

        }
        void loadDGV_HocSinh(DataTable data)
        {
            dgv_DanhSachHocSinh.DataSource = data;
            dataBingDing(data);
            
        }
        private void XepLop_Load(object sender, EventArgs e)
        {
            loadCboLop();
            loadCboTinhTrang();
            loadDGV_HocSinh();
            cbo_Lop.SelectedValue = "0";
        }

        private void btn_ThemDanhSachHocSinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Select an Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    ReadExcelFile(filePath);

                }
            }
        }
        private void ReadExcelFile(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    DataTable table = result.Tables[0];
                    dgv_DanhSachHocSinh.DataSource = table;
                }
            }
        }

        private void btn_LuuDanhSach_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dgv_DanhSachHocSinh.DataSource;
            if (dataTable != null)
            {
                hocSinh_LopDAO.themHocSinh(dataTable);
                DataTable data = hocSinh_LopDAO.GetTatCaHocSinh();
                loadDGV_HocSinh();
                MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu.");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu.");
            }

        }

        private void btn_XepLopHocSinhMoi_Click(object sender, EventArgs e)
        {
            hocSinh_LopDAO.xepLopHocSinhMoi();
            DataTable data = hocSinh_LopDAO.GetTatCaHocSinhCoLop();
            loadDGV_HocSinh(data);
            cbo_Lop.DataBindings.Add("Text", data, "TENLOP");
            MessageBox.Show("Thêm thành công");

        }

        private void btn_XepLopHocSinhCu_Click(object sender, EventArgs e)
        {
            hocSinh_LopDAO.lenLopHocSinh();
            DataTable data = hocSinh_LopDAO.GetTatCaHocSinhCoLop();
            loadDGV_HocSinh(data);
            cbo_Lop.DataBindings.Add("Text", data, "TENLOP");
            MessageBox.Show("Cập nhật thành công");
        }

        private void btn_XepLopLuuBan_Click(object sender, EventArgs e)
        {
            hocSinh_LopDAO.luuBanHocSinh();
            DataTable data = hocSinh_LopDAO.GetTatCaHocSinhCoLop();
            loadDGV_HocSinh(data);
            cbo_Lop.DataBindings.Add("Text", data, "TENLOP");
            MessageBox.Show("Cập nhật thành công");
        }

        private void btn_XepLopTheoDieuKien_Click(object sender, EventArgs e)
        {

            if (txt_MaHocSinh.Text != "")
            {
                string maHS = txt_MaHocSinh.Text;
                if (txt_Lop.Text != "")
                {
                    string tenLop = txt_Lop.Text;
                    if (txt_NienKhoa.Text != "")
                    {
                        int nienKhoa = Convert.ToInt32(txt_NienKhoa.Text);
                        string maLop = hocSinh_LopDAO.layMaLopKhiCoTenLop(tenLop, nienKhoa);
                        if (maLop != "")
                        {
                            hocSinh_LopDAO.xepLopTheoDieuKien(maHS, maLop);
                            DataTable data = hocSinh_LopDAO.GetTatCaHocSinhCoLop();
                            loadDGV_HocSinh(data);
                            MessageBox.Show("Xếp lớp thành công");
                        }
                        else
                        {
                            MessageBox.Show("Lớp không tồn tại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Niên khoá không được để trống");
                    }
                }
                else
                {
                    MessageBox.Show("Tên lớp không được để trống");
                }
            }
            else
            {
                MessageBox.Show("Mã học sinh không được để trống");
            }

        }

        private void cbo_DanhSachHocSinhTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinhTrang = cbo_DanhSachHocSinhTT.SelectedValue.ToString();
            DataTable data = new DataTable();
            if (tinhTrang.Equals("Tất cả"))
            {
                data = hocSinh_LopDAO.GetTatCaHocSinh();
            }
            else
            {
                data = hocSinh_LopDAO.GetHocSinhTheoTinhTrang(tinhTrang);
                
            }
            if (data.Rows.Count > 0)
            {
                loadDGV_HocSinh(data);
            }
            else
            {
                MessageBox.Show("Không có học sinh nào với tình trạng bạn chọn !!!");
                dgv_DanhSachHocSinh.DataSource = null;
            }
        }

        private void cbo_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {

            string lop = cbo_Lop.SelectedValue.ToString();
            DataTable data = new DataTable();
            if (lop.Equals("0"))
            {
                data = hocSinh_LopDAO.GetTatCaHocSinh();
            }
            else
            {
                data = hocSinh_LopDAO.GetHocSinhTheoLopNamHoc(lop);

                txt_NamHoc.DataBindings.Clear();
                txt_NamHoc.DataBindings.Add("Text", data, "NIENKHOA");
            }
            if (data.Rows.Count > 0)
            {
                loadDGV_HocSinh(data);
                
            }
            else
            {
                MessageBox.Show("Không có học sinh nào với lớp bạn chọn !!!");
                dgv_DanhSachHocSinh.DataSource = null;
            }
        }
    }
}

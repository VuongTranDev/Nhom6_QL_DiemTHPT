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

        void loadCboTinhTrang()
        {
            string[] tinhTrangs = { "Tất cả", "Lên lớp", "Lưu ban", "Mới" };

            cbo_DanhSachHocSinhTT.DataSource = tinhTrangs;
        }
        void loadCboLop()
        {
            List<LopDTO> lopList = lopDAO.GetLop();

            cbo_Lop.DisplayMember = "TENLOP";
            cbo_Lop.ValueMember = "MALOP";
            cbo_Lop.DataSource = lopList;
        }
        void loadDGV_HocSinh()
        {
            DataTable data = hocSinh_LopDAO.GetHSDaCoLop();
            dgv_DanhSachHocSinh.DataSource = data;
        }
        private void XepLop_Load(object sender, EventArgs e)
        {
            loadCboLop();
            loadCboTinhTrang();
            loadDGV_HocSinh();
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
                MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu.");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lưu.");
            }
        }
    }
}

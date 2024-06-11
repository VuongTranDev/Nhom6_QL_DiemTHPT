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
    public partial class DangNhap : Form
    {
        private readonly TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        public DangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtMatKhau.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            string loaiTaiKhoan = taiKhoanDAO.ValidateLogin(tenDangNhap, matKhau);

            if (!string.IsNullOrEmpty(loaiTaiKhoan))
            {
                switch (loaiTaiKhoan)
                {
                    case "hocsinh":
                        HomeForm homeForm = new HomeForm(tenDangNhap);
                        homeForm.Show();
                        break;
                    case "admin":
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        break;
                    case "giaovien":
                        GiaoVienForm giaoVienForm = new GiaoVienForm(tenDangNhap);
                        giaoVienForm.Show();
                        break;
                    default:
                        MessageBox.Show("Loại tài khoản không hợp lệ!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1_Click(sender, e);
            }
        }
    }
}

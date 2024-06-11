using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom6_QL_DiemTHPT.GUI
{
    public partial class GiaoVienForm : Form
    {
        public GiaoVienForm(string tenDangNhap)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lb_TenTK.Text = tenDangNhap;
        }

        Form currentFormChild;
        void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_QL_Diem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Diem());
        }

        private void btn_QL_HocBa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.HocBa());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            GUI.DangNhap f = new GUI.DangNhap();
            f.Show();
            this.Hide();
        }

        private void GiaoVienForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Diem());
        }
    }
}

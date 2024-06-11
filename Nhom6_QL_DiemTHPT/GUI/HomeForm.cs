using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom6_QL_DiemTHPT
{
    public partial class HomeForm : Form
    {
        public HomeForm(string tenDangNhap)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            tenTk.Text = tenDangNhap;
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


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            GUI.DangNhap f = new GUI.DangNhap();
            f.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.XemDiem());
        }
    }
}

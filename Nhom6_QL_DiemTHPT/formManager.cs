using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom6_QL_DiemTHPT
{
    class formManager
    {
        private Form currentFormChild;
        private Panel panelBody;
        private static formManager instance;
        public formManager(Panel panel)
        {
            panelBody = panel;
        }
        public static formManager GetInstance(Panel panel)
        {
            if (instance == null)
            {
                instance = new formManager(panel);
            }
            return instance;
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}

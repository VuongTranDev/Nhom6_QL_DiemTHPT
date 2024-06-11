
namespace Nhom6_QL_DiemTHPT.GUI
{
    partial class GiaoVienForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_QL_Diem = new System.Windows.Forms.Button();
            this.btn_QL_HocBa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btn_DangXuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 64);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btn_QL_HocBa);
            this.panel2.Controls.Add(this.btn_QL_Diem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 642);
            this.panel2.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(174, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1032, 642);
            this.mainPanel.TabIndex = 2;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Location = new System.Drawing.Point(1106, 23);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(75, 23);
            this.btn_DangXuat.TabIndex = 0;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_QL_Diem
            // 
            this.btn_QL_Diem.Location = new System.Drawing.Point(29, 29);
            this.btn_QL_Diem.Name = "btn_QL_Diem";
            this.btn_QL_Diem.Size = new System.Drawing.Size(113, 35);
            this.btn_QL_Diem.TabIndex = 0;
            this.btn_QL_Diem.Text = "Quản lý điểm";
            this.btn_QL_Diem.UseVisualStyleBackColor = true;
            this.btn_QL_Diem.Click += new System.EventHandler(this.btn_QL_Diem_Click);
            // 
            // btn_QL_HocBa
            // 
            this.btn_QL_HocBa.Location = new System.Drawing.Point(29, 86);
            this.btn_QL_HocBa.Name = "btn_QL_HocBa";
            this.btn_QL_HocBa.Size = new System.Drawing.Size(113, 33);
            this.btn_QL_HocBa.TabIndex = 1;
            this.btn_QL_HocBa.Text = "Quản lý học bạ";
            this.btn_QL_HocBa.UseVisualStyleBackColor = true;
            this.btn_QL_HocBa.Click += new System.EventHandler(this.btn_QL_HocBa_Click);
            // 
            // GiaoVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 706);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GiaoVienForm";
            this.Text = "GiaoVienForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_QL_HocBa;
        private System.Windows.Forms.Button btn_QL_Diem;
        private System.Windows.Forms.Panel mainPanel;
    }
}
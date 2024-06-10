
namespace Nhom6_QL_DiemTHPT.GUI
{
    partial class XepLop
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
            this.txt_MaHocSinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenHocSinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_DanhSachHocSinhTT = new System.Windows.Forms.ComboBox();
            this.btn_XepLopTheoDieuKien = new System.Windows.Forms.Button();
            this.btn_XepLopLuuBan = new System.Windows.Forms.Button();
            this.btn_ThemDanhSachHocSinh = new System.Windows.Forms.Button();
            this.cbo_TinhTrang = new System.Windows.Forms.ComboBox();
            this.cbo_Lop = new System.Windows.Forms.ComboBox();
            this.btn_XepLopHocSinhCu = new System.Windows.Forms.Button();
            this.btn_XepLopHocSinhMoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NamHoc = new System.Windows.Forms.TextBox();
            this.btn_LuuDanhSach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHocSinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_MaHocSinh
            // 
            this.txt_MaHocSinh.Enabled = false;
            this.txt_MaHocSinh.Location = new System.Drawing.Point(140, 31);
            this.txt_MaHocSinh.Name = "txt_MaHocSinh";
            this.txt_MaHocSinh.Size = new System.Drawing.Size(186, 22);
            this.txt_MaHocSinh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên học sinh";
            // 
            // txt_TenHocSinh
            // 
            this.txt_TenHocSinh.Enabled = false;
            this.txt_TenHocSinh.Location = new System.Drawing.Point(140, 66);
            this.txt_TenHocSinh.Name = "txt_TenHocSinh";
            this.txt_TenHocSinh.Size = new System.Drawing.Size(186, 22);
            this.txt_TenHocSinh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dgv_DanhSachHocSinh);
            this.groupBox1.Location = new System.Drawing.Point(77, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 367);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_DanhSachHocSinh
            // 
            this.dgv_DanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHocSinh.Location = new System.Drawing.Point(15, 37);
            this.dgv_DanhSachHocSinh.Name = "dgv_DanhSachHocSinh";
            this.dgv_DanhSachHocSinh.RowHeadersWidth = 51;
            this.dgv_DanhSachHocSinh.RowTemplate.Height = 24;
            this.dgv_DanhSachHocSinh.Size = new System.Drawing.Size(1100, 309);
            this.dgv_DanhSachHocSinh.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbo_DanhSachHocSinhTT);
            this.groupBox2.Controls.Add(this.btn_XepLopTheoDieuKien);
            this.groupBox2.Controls.Add(this.btn_XepLopLuuBan);
            this.groupBox2.Controls.Add(this.btn_ThemDanhSachHocSinh);
            this.groupBox2.Controls.Add(this.cbo_TinhTrang);
            this.groupBox2.Controls.Add(this.cbo_Lop);
            this.groupBox2.Controls.Add(this.btn_XepLopHocSinhCu);
            this.groupBox2.Controls.Add(this.btn_XepLopHocSinhMoi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_NamHoc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_MaHocSinh);
            this.groupBox2.Controls.Add(this.txt_TenHocSinh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(81, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1117, 215);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin học sinh";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(749, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Danh Sách (Tình trạng)";
            // 
            // cbo_DanhSachHocSinhTT
            // 
            this.cbo_DanhSachHocSinhTT.FormattingEnabled = true;
            this.cbo_DanhSachHocSinhTT.Location = new System.Drawing.Point(912, 69);
            this.cbo_DanhSachHocSinhTT.Name = "cbo_DanhSachHocSinhTT";
            this.cbo_DanhSachHocSinhTT.Size = new System.Drawing.Size(186, 24);
            this.cbo_DanhSachHocSinhTT.TabIndex = 17;
            // 
            // btn_XepLopTheoDieuKien
            // 
            this.btn_XepLopTheoDieuKien.Location = new System.Drawing.Point(926, 129);
            this.btn_XepLopTheoDieuKien.Name = "btn_XepLopTheoDieuKien";
            this.btn_XepLopTheoDieuKien.Size = new System.Drawing.Size(114, 63);
            this.btn_XepLopTheoDieuKien.TabIndex = 16;
            this.btn_XepLopTheoDieuKien.Text = "Xếp lớp học sinh theo điều kiện";
            this.btn_XepLopTheoDieuKien.UseVisualStyleBackColor = true;
            // 
            // btn_XepLopLuuBan
            // 
            this.btn_XepLopLuuBan.Location = new System.Drawing.Point(714, 129);
            this.btn_XepLopLuuBan.Name = "btn_XepLopLuuBan";
            this.btn_XepLopLuuBan.Size = new System.Drawing.Size(114, 63);
            this.btn_XepLopLuuBan.TabIndex = 15;
            this.btn_XepLopLuuBan.Text = "Xếp lớp học sinh lưu ban";
            this.btn_XepLopLuuBan.UseVisualStyleBackColor = true;
            // 
            // btn_ThemDanhSachHocSinh
            // 
            this.btn_ThemDanhSachHocSinh.AutoSize = true;
            this.btn_ThemDanhSachHocSinh.Location = new System.Drawing.Point(36, 131);
            this.btn_ThemDanhSachHocSinh.Name = "btn_ThemDanhSachHocSinh";
            this.btn_ThemDanhSachHocSinh.Size = new System.Drawing.Size(181, 63);
            this.btn_ThemDanhSachHocSinh.TabIndex = 14;
            this.btn_ThemDanhSachHocSinh.Text = "Thêm danh sách học sinh";
            this.btn_ThemDanhSachHocSinh.UseVisualStyleBackColor = true;
            this.btn_ThemDanhSachHocSinh.Click += new System.EventHandler(this.btn_ThemDanhSachHocSinh_Click);
            // 
            // cbo_TinhTrang
            // 
            this.cbo_TinhTrang.Enabled = false;
            this.cbo_TinhTrang.FormattingEnabled = true;
            this.cbo_TinhTrang.Location = new System.Drawing.Point(483, 66);
            this.cbo_TinhTrang.Name = "cbo_TinhTrang";
            this.cbo_TinhTrang.Size = new System.Drawing.Size(186, 24);
            this.cbo_TinhTrang.TabIndex = 13;
            // 
            // cbo_Lop
            // 
            this.cbo_Lop.Enabled = false;
            this.cbo_Lop.FormattingEnabled = true;
            this.cbo_Lop.Location = new System.Drawing.Point(844, 13);
            this.cbo_Lop.Name = "cbo_Lop";
            this.cbo_Lop.Size = new System.Drawing.Size(141, 24);
            this.cbo_Lop.TabIndex = 12;
            // 
            // btn_XepLopHocSinhCu
            // 
            this.btn_XepLopHocSinhCu.Location = new System.Drawing.Point(504, 129);
            this.btn_XepLopHocSinhCu.Name = "btn_XepLopHocSinhCu";
            this.btn_XepLopHocSinhCu.Size = new System.Drawing.Size(114, 63);
            this.btn_XepLopHocSinhCu.TabIndex = 11;
            this.btn_XepLopHocSinhCu.Text = "Xếp lớp học sinh cũ";
            this.btn_XepLopHocSinhCu.UseVisualStyleBackColor = true;
            // 
            // btn_XepLopHocSinhMoi
            // 
            this.btn_XepLopHocSinhMoi.AutoSize = true;
            this.btn_XepLopHocSinhMoi.Location = new System.Drawing.Point(275, 129);
            this.btn_XepLopHocSinhMoi.Name = "btn_XepLopHocSinhMoi";
            this.btn_XepLopHocSinhMoi.Size = new System.Drawing.Size(149, 63);
            this.btn_XepLopHocSinhMoi.TabIndex = 10;
            this.btn_XepLopHocSinhMoi.Text = "Xếp lớp học sinh mới";
            this.btn_XepLopHocSinhMoi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Năm học";
            // 
            // txt_NamHoc
            // 
            this.txt_NamHoc.Enabled = false;
            this.txt_NamHoc.Location = new System.Drawing.Point(483, 15);
            this.txt_NamHoc.Name = "txt_NamHoc";
            this.txt_NamHoc.Size = new System.Drawing.Size(186, 22);
            this.txt_NamHoc.TabIndex = 6;
            // 
            // btn_LuuDanhSach
            // 
            this.btn_LuuDanhSach.AutoSize = true;
            this.btn_LuuDanhSach.Location = new System.Drawing.Point(585, 617);
            this.btn_LuuDanhSach.Name = "btn_LuuDanhSach";
            this.btn_LuuDanhSach.Size = new System.Drawing.Size(195, 63);
            this.btn_LuuDanhSach.TabIndex = 19;
            this.btn_LuuDanhSach.Text = "Lưu danh sách học sinh mới";
            this.btn_LuuDanhSach.UseVisualStyleBackColor = true;
            this.btn_LuuDanhSach.Click += new System.EventHandler(this.btn_LuuDanhSach_Click);
            // 
            // XepLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 703);
            this.Controls.Add(this.btn_LuuDanhSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "XepLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHocSinh";
            this.Load += new System.EventHandler(this.XepLop_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHocSinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaHocSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenHocSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_XepLopHocSinhCu;
        private System.Windows.Forms.Button btn_XepLopHocSinhMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NamHoc;
        private System.Windows.Forms.ComboBox cbo_TinhTrang;
        private System.Windows.Forms.ComboBox cbo_Lop;
        private System.Windows.Forms.Button btn_ThemDanhSachHocSinh;
        private System.Windows.Forms.Button btn_XepLopLuuBan;
        private System.Windows.Forms.Button btn_XepLopTheoDieuKien;
        private System.Windows.Forms.DataGridView dgv_DanhSachHocSinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_DanhSachHocSinhTT;
        private System.Windows.Forms.Button btn_LuuDanhSach;
    }
}

namespace Nhom6_QL_DiemTHPT.GUI
{
    partial class XemDiem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_TonGiao = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_DanToc = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_Lop = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_TenHS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_MAHS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_hocKy = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_DiemHK1 = new System.Windows.Forms.Label();
            this.lb_DiemHK2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_DiemTong = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_HanhKiem = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_HocLuc = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_GioiTinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_TonGiao);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lb_DanToc);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lb_NgaySinh);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lb_DiaChi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_Lop);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_TenHS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_MAHS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(384, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Location = new System.Drawing.Point(296, 89);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(0, 13);
            this.lb_GioiTinh.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giới tính";
            // 
            // lb_TonGiao
            // 
            this.lb_TonGiao.AutoSize = true;
            this.lb_TonGiao.Location = new System.Drawing.Point(296, 61);
            this.lb_TonGiao.Name = "lb_TonGiao";
            this.lb_TonGiao.Size = new System.Drawing.Size(0, 13);
            this.lb_TonGiao.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(222, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Tôn giáo";
            // 
            // lb_DanToc
            // 
            this.lb_DanToc.AutoSize = true;
            this.lb_DanToc.Location = new System.Drawing.Point(296, 32);
            this.lb_DanToc.Name = "lb_DanToc";
            this.lb_DanToc.Size = new System.Drawing.Size(0, 13);
            this.lb_DanToc.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Dân tộc";
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(95, 120);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(0, 13);
            this.lb_NgaySinh.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ngày sinh";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(95, 151);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(0, 13);
            this.lb_DiaChi.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Địa chỉ";
            // 
            // lb_Lop
            // 
            this.lb_Lop.AutoSize = true;
            this.lb_Lop.Location = new System.Drawing.Point(95, 89);
            this.lb_Lop.Name = "lb_Lop";
            this.lb_Lop.Size = new System.Drawing.Size(0, 13);
            this.lb_Lop.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Lớp";
            // 
            // lb_TenHS
            // 
            this.lb_TenHS.AutoSize = true;
            this.lb_TenHS.Location = new System.Drawing.Point(95, 61);
            this.lb_TenHS.Name = "lb_TenHS";
            this.lb_TenHS.Size = new System.Drawing.Size(0, 13);
            this.lb_TenHS.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên học sinh:";
            // 
            // lb_MAHS
            // 
            this.lb_MAHS.AutoSize = true;
            this.lb_MAHS.Location = new System.Drawing.Point(95, 32);
            this.lb_MAHS.Name = "lb_MAHS";
            this.lb_MAHS.Size = new System.Drawing.Size(0, 13);
            this.lb_MAHS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học sinh:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(54, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(175, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(105, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn học kỳ";
            // 
            // cbo_hocKy
            // 
            this.cbo_hocKy.FormattingEnabled = true;
            this.cbo_hocKy.Location = new System.Drawing.Point(121, 191);
            this.cbo_hocKy.Name = "cbo_hocKy";
            this.cbo_hocKy.Size = new System.Drawing.Size(123, 21);
            this.cbo_hocKy.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_HocLuc);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.lb_HanhKiem);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lb_DiemTong);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lb_DiemHK2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lb_DiemHK1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(641, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 201);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Điểm tổng";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm TB HK 1:";
            // 
            // lb_DiemHK1
            // 
            this.lb_DiemHK1.AutoSize = true;
            this.lb_DiemHK1.Location = new System.Drawing.Point(104, 37);
            this.lb_DiemHK1.Name = "lb_DiemHK1";
            this.lb_DiemHK1.Size = new System.Drawing.Size(0, 13);
            this.lb_DiemHK1.TabIndex = 1;
            // 
            // lb_DiemHK2
            // 
            this.lb_DiemHK2.AutoSize = true;
            this.lb_DiemHK2.Location = new System.Drawing.Point(104, 71);
            this.lb_DiemHK2.Name = "lb_DiemHK2";
            this.lb_DiemHK2.Size = new System.Drawing.Size(0, 13);
            this.lb_DiemHK2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Điểm TB HK 2:";
            // 
            // lb_DiemTong
            // 
            this.lb_DiemTong.AutoSize = true;
            this.lb_DiemTong.Location = new System.Drawing.Point(104, 104);
            this.lb_DiemTong.Name = "lb_DiemTong";
            this.lb_DiemTong.Size = new System.Drawing.Size(0, 13);
            this.lb_DiemTong.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Điểm tổng kết:";
            // 
            // lb_HanhKiem
            // 
            this.lb_HanhKiem.AutoSize = true;
            this.lb_HanhKiem.Location = new System.Drawing.Point(104, 134);
            this.lb_HanhKiem.Name = "lb_HanhKiem";
            this.lb_HanhKiem.Size = new System.Drawing.Size(0, 13);
            this.lb_HanhKiem.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Hạnh kiểm:";
            // 
            // lb_HocLuc
            // 
            this.lb_HocLuc.AutoSize = true;
            this.lb_HocLuc.Location = new System.Drawing.Point(104, 169);
            this.lb_HocLuc.Name = "lb_HocLuc";
            this.lb_HocLuc.Size = new System.Drawing.Size(0, 13);
            this.lb_HocLuc.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Học lực:";
            // 
            // XemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 589);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbo_hocKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "XemDiem";
            this.Text = "XemDiem";
            this.Load += new System.EventHandler(this.XemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_TonGiao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_DanToc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_Lop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_TenHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_MAHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_hocKy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_HocLuc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lb_HanhKiem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_DiemTong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_DiemHK2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_DiemHK1;
        private System.Windows.Forms.Label label6;
    }
}
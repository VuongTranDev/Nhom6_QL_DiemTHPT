
namespace Nhom6_QL_DiemTHPT.GUI
{
    partial class PhanCongGV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPhanCongGV = new System.Windows.Forms.Button();
            this.cbDSLopDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChuyenMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDSGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvGiangDay = new System.Windows.Forms.DataGridView();
            this.txtChuNhiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoPhanCong = new System.Windows.Forms.Button();
            this.btnboNhiemGVCN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiangDay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPhanCongGV);
            this.groupBox1.Controls.Add(this.cbDSLopDay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtChuyenMon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // btnPhanCongGV
            // 
            this.btnPhanCongGV.Location = new System.Drawing.Point(161, 180);
            this.btnPhanCongGV.Name = "btnPhanCongGV";
            this.btnPhanCongGV.Size = new System.Drawing.Size(184, 46);
            this.btnPhanCongGV.TabIndex = 10;
            this.btnPhanCongGV.Text = "Phân công GV";
            this.btnPhanCongGV.UseVisualStyleBackColor = true;
            this.btnPhanCongGV.Click += new System.EventHandler(this.btnPhanCongGV_Click);
            // 
            // cbDSLopDay
            // 
            this.cbDSLopDay.FormattingEnabled = true;
            this.cbDSLopDay.Location = new System.Drawing.Point(351, 58);
            this.cbDSLopDay.Name = "cbDSLopDay";
            this.cbDSLopDay.Size = new System.Drawing.Size(121, 24);
            this.cbDSLopDay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "DS lớp dạy";
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.Location = new System.Drawing.Point(129, 83);
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.Size = new System.Drawing.Size(100, 22);
            this.txtChuyenMon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chuyên môn";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(129, 32);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(100, 22);
            this.txtTenGV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên GV";
            // 
            // dtgvDSGV
            // 
            this.dtgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSGV.Location = new System.Drawing.Point(21, 35);
            this.dtgvDSGV.Name = "dtgvDSGV";
            this.dtgvDSGV.RowHeadersWidth = 51;
            this.dtgvDSGV.RowTemplate.Height = 24;
            this.dtgvDSGV.Size = new System.Drawing.Size(432, 281);
            this.dtgvDSGV.TabIndex = 1;
            this.dtgvDSGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSGV_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvDSGV);
            this.groupBox2.Location = new System.Drawing.Point(52, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách giáo viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnboNhiemGVCN);
            this.groupBox3.Controls.Add(this.btnGoPhanCong);
            this.groupBox3.Controls.Add(this.txtTenMH);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtgvGiangDay);
            this.groupBox3.Controls.Add(this.txtChuNhiem);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbLop);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(577, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(790, 533);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin lớp";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(149, 240);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(121, 22);
            this.txtTenMH.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên Môn Học";
            // 
            // dtgvGiangDay
            // 
            this.dtgvGiangDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGiangDay.Location = new System.Drawing.Point(310, 43);
            this.dtgvGiangDay.Name = "dtgvGiangDay";
            this.dtgvGiangDay.RowHeadersWidth = 51;
            this.dtgvGiangDay.RowTemplate.Height = 24;
            this.dtgvGiangDay.Size = new System.Drawing.Size(442, 449);
            this.dtgvGiangDay.TabIndex = 10;
            this.dtgvGiangDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGiangDay_CellClick);
            // 
            // txtChuNhiem
            // 
            this.txtChuNhiem.Enabled = false;
            this.txtChuNhiem.Location = new System.Drawing.Point(149, 138);
            this.txtChuNhiem.Name = "txtChuNhiem";
            this.txtChuNhiem.Size = new System.Drawing.Size(121, 22);
            this.txtChuNhiem.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chủ nhiệm";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(149, 43);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 24);
            this.cbLop.TabIndex = 8;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Lớp";
            // 
            // btnGoPhanCong
            // 
            this.btnGoPhanCong.Location = new System.Drawing.Point(29, 328);
            this.btnGoPhanCong.Name = "btnGoPhanCong";
            this.btnGoPhanCong.Size = new System.Drawing.Size(241, 46);
            this.btnGoPhanCong.TabIndex = 15;
            this.btnGoPhanCong.Text = "Gỡ phân công";
            this.btnGoPhanCong.UseVisualStyleBackColor = true;
            this.btnGoPhanCong.Click += new System.EventHandler(this.btnGoPhanCong_Click);
            // 
            // btnboNhiemGVCN
            // 
            this.btnboNhiemGVCN.Location = new System.Drawing.Point(29, 424);
            this.btnboNhiemGVCN.Name = "btnboNhiemGVCN";
            this.btnboNhiemGVCN.Size = new System.Drawing.Size(241, 46);
            this.btnboNhiemGVCN.TabIndex = 12;
            this.btnboNhiemGVCN.Text = "Bổ nhiệm GVCN";
            this.btnboNhiemGVCN.UseVisualStyleBackColor = true;
            this.btnboNhiemGVCN.Click += new System.EventHandler(this.btnboNhiemGVCN_Click);
            // 
            // PhanCongGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 678);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhanCongGV";
            this.Text = "PhanCongGV";
            this.Load += new System.EventHandler(this.PhanCongGV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiangDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDSLopDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChuyenMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDSGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvGiangDay;
        private System.Windows.Forms.TextBox txtChuNhiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPhanCongGV;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGoPhanCong;
        private System.Windows.Forms.Button btnboNhiemGVCN;
    }
}
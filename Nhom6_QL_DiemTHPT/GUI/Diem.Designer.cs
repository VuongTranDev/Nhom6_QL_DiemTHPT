
namespace Nhom6_QL_DiemTHPT.GUI
{
    partial class Diem
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMHS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMHS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboHK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateDiem = new System.Windows.Forms.Button();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiemHS2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiemHS1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMAMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TenHS = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_MaHS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chon lớp";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(85, 12);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(141, 21);
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(15, 92);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(211, 536);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMH,
            this.TENMH,
            this.MAHK,
            this.DIEMHS1,
            this.DIEMHS2,
            this.DIEMTHI,
            this.DIEMTB});
            this.dataGridView1.Location = new System.Drawing.Point(267, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 325);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MAMH
            // 
            this.MAMH.DataPropertyName = "MAMH";
            this.MAMH.HeaderText = "Mã môn học";
            this.MAMH.Name = "MAMH";
            // 
            // TENMH
            // 
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "Tên môn học";
            this.TENMH.Name = "TENMH";
            // 
            // MAHK
            // 
            this.MAHK.DataPropertyName = "MAHK";
            this.MAHK.HeaderText = "Học kỳ";
            this.MAHK.Name = "MAHK";
            // 
            // DIEMHS1
            // 
            this.DIEMHS1.DataPropertyName = "DIEMHS1";
            this.DIEMHS1.HeaderText = "Điểm hs 1";
            this.DIEMHS1.Name = "DIEMHS1";
            // 
            // DIEMHS2
            // 
            this.DIEMHS2.DataPropertyName = "DIEMHS2";
            this.DIEMHS2.HeaderText = "Điểm hs 2";
            this.DIEMHS2.Name = "DIEMHS2";
            // 
            // DIEMTHI
            // 
            this.DIEMTHI.DataPropertyName = "DIEMTHI";
            this.DIEMTHI.HeaderText = "Điểm thi";
            this.DIEMTHI.Name = "DIEMTHI";
            // 
            // DIEMTB
            // 
            this.DIEMTB.DataPropertyName = "DIEMTB";
            this.DIEMTB.HeaderText = "Điểm TB";
            this.DIEMTB.Name = "DIEMTB";
            // 
            // cboHK
            // 
            this.cboHK.FormattingEnabled = true;
            this.cboHK.Location = new System.Drawing.Point(85, 53);
            this.cboHK.Name = "cboHK";
            this.cboHK.Size = new System.Drawing.Size(141, 21);
            this.cboHK.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chon học kỳ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDiemThi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiemHS2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiemHS1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMAMH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_TenHS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lb_MaHS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(267, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 260);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateDiem);
            this.groupBox2.Location = new System.Drawing.Point(303, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 80);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnUpdateDiem
            // 
            this.btnUpdateDiem.Location = new System.Drawing.Point(26, 34);
            this.btnUpdateDiem.Name = "btnUpdateDiem";
            this.btnUpdateDiem.Size = new System.Drawing.Size(140, 23);
            this.btnUpdateDiem.TabIndex = 0;
            this.btnUpdateDiem.Text = "Cập nhật điểm";
            this.btnUpdateDiem.UseVisualStyleBackColor = true;
            this.btnUpdateDiem.Click += new System.EventHandler(this.btnUpdateDiem_Click);
            // 
            // txtTenMH
            // 
            this.txtTenMH.Enabled = false;
            this.txtTenMH.Location = new System.Drawing.Point(116, 120);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(134, 20);
            this.txtTenMH.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tên môn học";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(116, 221);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(134, 20);
            this.txtDiemThi.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Điểm thi";
            // 
            // txtDiemHS2
            // 
            this.txtDiemHS2.Location = new System.Drawing.Point(116, 185);
            this.txtDiemHS2.Name = "txtDiemHS2";
            this.txtDiemHS2.Size = new System.Drawing.Size(134, 20);
            this.txtDiemHS2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Điểm hs 2";
            // 
            // txtDiemHS1
            // 
            this.txtDiemHS1.Location = new System.Drawing.Point(116, 149);
            this.txtDiemHS1.Name = "txtDiemHS1";
            this.txtDiemHS1.Size = new System.Drawing.Size(134, 20);
            this.txtDiemHS1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Điểm hs 1";
            // 
            // txtMAMH
            // 
            this.txtMAMH.Enabled = false;
            this.txtMAMH.Location = new System.Drawing.Point(116, 89);
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Size = new System.Drawing.Size(134, 20);
            this.txtMAMH.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã môn học";
            // 
            // lb_TenHS
            // 
            this.lb_TenHS.AutoSize = true;
            this.lb_TenHS.Location = new System.Drawing.Point(113, 57);
            this.lb_TenHS.Name = "lb_TenHS";
            this.lb_TenHS.Size = new System.Drawing.Size(35, 13);
            this.lb_TenHS.TabIndex = 5;
            this.lb_TenHS.Text = "NULL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tên học sinh";
            // 
            // lb_MaHS
            // 
            this.lb_MaHS.AutoSize = true;
            this.lb_MaHS.Location = new System.Drawing.Point(113, 28);
            this.lb_MaHS.Name = "lb_MaHS";
            this.lb_MaHS.Size = new System.Drawing.Size(35, 13);
            this.lb_MaHS.TabIndex = 3;
            this.lb_MaHS.Text = "NULL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã học sinh";
            // 
            // Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboHK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label1);
            this.Name = "Diem";
            this.Text = "Diem";
            this.Load += new System.EventHandler(this.Diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboHK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMHS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMHS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_TenHS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_MaHS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiemHS2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiemHS1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMAMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateDiem;
    }
}
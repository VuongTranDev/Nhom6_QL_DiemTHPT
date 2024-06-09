
namespace Nhom6_QL_DiemTHPT.GUI
{
    partial class HocBa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboHanhKiem = new System.Windows.Forms.ComboBox();
            this.cboXepLoai = new System.Windows.Forms.ComboBox();
            this.txtDiemTong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiemHK2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiemHk1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMAHB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTinhXepLoai = new System.Windows.Forms.Button();
            this.btnTinhDiemTong = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MAHB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMHK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMHK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XEPLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANHKIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTaoMaHB = new System.Windows.Forms.Button();
            this.cboMaHS = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(61, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học bạ của học sinh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHB,
            this.MAHS,
            this.DIEMHK1,
            this.DIEMHK2,
            this.DIEMTONG,
            this.XEPLOAI,
            this.HANHKIEM});
            this.dataGridView1.Location = new System.Drawing.Point(19, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboMaHS);
            this.groupBox2.Controls.Add(this.btnTaoMaHB);
            this.groupBox2.Controls.Add(this.cboHanhKiem);
            this.groupBox2.Controls.Add(this.cboXepLoai);
            this.groupBox2.Controls.Add(this.txtDiemTong);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDiemHK2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDiemHk1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMAHB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(61, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // cboHanhKiem
            // 
            this.cboHanhKiem.FormattingEnabled = true;
            this.cboHanhKiem.Location = new System.Drawing.Point(82, 135);
            this.cboHanhKiem.Name = "cboHanhKiem";
            this.cboHanhKiem.Size = new System.Drawing.Size(166, 21);
            this.cboHanhKiem.TabIndex = 17;
            // 
            // cboXepLoai
            // 
            this.cboXepLoai.FormattingEnabled = true;
            this.cboXepLoai.Location = new System.Drawing.Point(82, 95);
            this.cboXepLoai.Name = "cboXepLoai";
            this.cboXepLoai.Size = new System.Drawing.Size(166, 21);
            this.cboXepLoai.TabIndex = 16;
            // 
            // txtDiemTong
            // 
            this.txtDiemTong.Enabled = false;
            this.txtDiemTong.Location = new System.Drawing.Point(370, 93);
            this.txtDiemTong.Name = "txtDiemTong";
            this.txtDiemTong.Size = new System.Drawing.Size(166, 20);
            this.txtDiemTong.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Điểm tổng";
            // 
            // txtDiemHK2
            // 
            this.txtDiemHK2.Enabled = false;
            this.txtDiemHK2.Location = new System.Drawing.Point(370, 57);
            this.txtDiemHK2.Name = "txtDiemHK2";
            this.txtDiemHK2.Size = new System.Drawing.Size(166, 20);
            this.txtDiemHK2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Điểm hk 2";
            // 
            // txtDiemHk1
            // 
            this.txtDiemHk1.Enabled = false;
            this.txtDiemHk1.Location = new System.Drawing.Point(370, 22);
            this.txtDiemHk1.Name = "txtDiemHk1";
            this.txtDiemHk1.Size = new System.Drawing.Size(166, 20);
            this.txtDiemHk1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điểm hk 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hạnh kiểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Xếp loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã học sinh";
            // 
            // txtMAHB
            // 
            this.txtMAHB.Enabled = false;
            this.txtMAHB.Location = new System.Drawing.Point(82, 22);
            this.txtMAHB.Name = "txtMAHB";
            this.txtMAHB.Size = new System.Drawing.Size(166, 20);
            this.txtMAHB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã học bạ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTinhXepLoai);
            this.groupBox3.Controls.Add(this.btnTinhDiemTong);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(668, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 172);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnTinhXepLoai
            // 
            this.btnTinhXepLoai.Location = new System.Drawing.Point(27, 125);
            this.btnTinhXepLoai.Name = "btnTinhXepLoai";
            this.btnTinhXepLoai.Size = new System.Drawing.Size(75, 23);
            this.btnTinhXepLoai.TabIndex = 4;
            this.btnTinhXepLoai.Text = "Xếp loại";
            this.btnTinhXepLoai.UseVisualStyleBackColor = true;
            this.btnTinhXepLoai.Click += new System.EventHandler(this.btnTinhXepLoai_Click);
            // 
            // btnTinhDiemTong
            // 
            this.btnTinhDiemTong.Location = new System.Drawing.Point(27, 94);
            this.btnTinhDiemTong.Name = "btnTinhDiemTong";
            this.btnTinhDiemTong.Size = new System.Drawing.Size(75, 23);
            this.btnTinhDiemTong.TabIndex = 3;
            this.btnTinhDiemTong.Text = "Tính điểm";
            this.btnTinhDiemTong.UseVisualStyleBackColor = true;
            this.btnTinhDiemTong.Click += new System.EventHandler(this.btnTinhDiemTong_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MAHB
            // 
            this.MAHB.DataPropertyName = "MAHB";
            this.MAHB.HeaderText = "Mã học bạ";
            this.MAHB.Name = "MAHB";
            // 
            // MAHS
            // 
            this.MAHS.DataPropertyName = "MAHS";
            this.MAHS.HeaderText = "Mã học sinh";
            this.MAHS.Name = "MAHS";
            // 
            // DIEMHK1
            // 
            this.DIEMHK1.DataPropertyName = "DIEMHK1";
            this.DIEMHK1.HeaderText = "Điểm hk 1";
            this.DIEMHK1.Name = "DIEMHK1";
            // 
            // DIEMHK2
            // 
            this.DIEMHK2.DataPropertyName = "DIEMHK2";
            this.DIEMHK2.HeaderText = "Điểm hk 2";
            this.DIEMHK2.Name = "DIEMHK2";
            // 
            // DIEMTONG
            // 
            this.DIEMTONG.DataPropertyName = "DIEMTONG";
            this.DIEMTONG.HeaderText = "Điểm tổng";
            this.DIEMTONG.Name = "DIEMTONG";
            this.DIEMTONG.Width = 133;
            // 
            // XEPLOAI
            // 
            this.XEPLOAI.DataPropertyName = "XEPLOAI";
            this.XEPLOAI.HeaderText = "Xếp loại";
            this.XEPLOAI.Name = "XEPLOAI";
            // 
            // HANHKIEM
            // 
            this.HANHKIEM.DataPropertyName = "HANHKIEM";
            this.HANHKIEM.HeaderText = "Hạnh kiểm";
            this.HANHKIEM.Name = "HANHKIEM";
            // 
            // btnTaoMaHB
            // 
            this.btnTaoMaHB.Location = new System.Drawing.Point(302, 135);
            this.btnTaoMaHB.Name = "btnTaoMaHB";
            this.btnTaoMaHB.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMaHB.TabIndex = 18;
            this.btnTaoMaHB.Text = "Tạo MAHB";
            this.btnTaoMaHB.UseVisualStyleBackColor = true;
            this.btnTaoMaHB.Click += new System.EventHandler(this.btnTaoMaHB_Click);
            // 
            // cboMaHS
            // 
            this.cboMaHS.FormattingEnabled = true;
            this.cboMaHS.Location = new System.Drawing.Point(82, 56);
            this.cboMaHS.Name = "cboMaHS";
            this.cboMaHS.Size = new System.Drawing.Size(166, 21);
            this.cboMaHS.TabIndex = 19;
            // 
            // HocBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HocBa";
            this.Text = "HocBa";
            this.Load += new System.EventHandler(this.HocBa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMAHB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTinhDiemTong;
        private System.Windows.Forms.Button btnTinhXepLoai;
        private System.Windows.Forms.TextBox txtDiemTong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiemHK2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiemHk1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboHanhKiem;
        private System.Windows.Forms.ComboBox cboXepLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMHK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMHK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn XEPLOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANHKIEM;
        private System.Windows.Forms.Button btnTaoMaHB;
        private System.Windows.Forms.ComboBox cboMaHS;
    }
}
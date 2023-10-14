namespace QuanLySinhVien
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSua = new System.Windows.Forms.Panel();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbTruong = new System.Windows.Forms.ComboBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTimKiem = new System.Windows.Forms.DataGridView();
            this.radNgaySinh = new System.Windows.Forms.RadioButton();
            this.radGioiTinh = new System.Windows.Forms.RadioButton();
            this.radMaSV = new System.Windows.Forms.RadioButton();
            this.radTruong = new System.Windows.Forms.RadioButton();
            this.radLop = new System.Windows.Forms.RadioButton();
            this.radQueQuan = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaSV1 = new System.Windows.Forms.TextBox();
            this.txtLop1 = new System.Windows.Forms.TextBox();
            this.txtQueQuan1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh1 = new System.Windows.Forms.ComboBox();
            this.cbTruong1 = new System.Windows.Forms.ComboBox();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.btnSua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSinhVien);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông Tin Sinh Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewTimKiem);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm Kiếm Sinh Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Controls.Add(this.cbGioiTinh);
            this.btnSua.Controls.Add(this.cbTruong);
            this.btnSua.Controls.Add(this.dateTimePicker1);
            this.btnSua.Controls.Add(this.txtQueQuan);
            this.btnSua.Controls.Add(this.txtLop);
            this.btnSua.Controls.Add(this.txtHoTen);
            this.btnSua.Controls.Add(this.txtMaSV);
            this.btnSua.Controls.Add(this.label5);
            this.btnSua.Controls.Add(this.label3);
            this.btnSua.Controls.Add(this.label7);
            this.btnSua.Controls.Add(this.label4);
            this.btnSua.Controls.Add(this.label6);
            this.btnSua.Controls.Add(this.label2);
            this.btnSua.Controls.Add(this.label1);
            this.btnSua.Controls.Add(this.btnXoa);
            this.btnSua.Controls.Add(this.button2);
            this.btnSua.Controls.Add(this.btnThem);
            this.btnSua.Location = new System.Drawing.Point(8, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(779, 206);
            this.btnSua.TabIndex = 0;
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(8, 247);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(776, 168);
            this.dataGridViewSinhVien.TabIndex = 0;
            this.dataGridViewSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinhVien_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(123, 180);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(536, 183);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trường";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Quê Quán";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(165, 32);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 20);
            this.txtMaSV.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(169, 71);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(361, 74);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(100, 20);
            this.txtLop.TabIndex = 4;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(595, 29);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(100, 20);
            this.txtQueQuan.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cbTruong
            // 
            this.cbTruong.FormattingEnabled = true;
            this.cbTruong.Location = new System.Drawing.Point(377, 112);
            this.cbTruong.Name = "cbTruong";
            this.cbTruong.Size = new System.Drawing.Size(126, 21);
            this.cbTruong.TabIndex = 6;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(387, 28);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(107, 21);
            this.cbGioiTinh.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Lớp";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Trường";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Quê Quán";
            this.Column7.Name = "Column7";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTruong1);
            this.panel1.Controls.Add(this.cbGioiTinh1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.txtQueQuan1);
            this.panel1.Controls.Add(this.txtLop1);
            this.panel1.Controls.Add(this.txtMaSV1);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.radQueQuan);
            this.panel1.Controls.Add(this.radGioiTinh);
            this.panel1.Controls.Add(this.radLop);
            this.panel1.Controls.Add(this.radMaSV);
            this.panel1.Controls.Add(this.radTruong);
            this.panel1.Controls.Add(this.radNgaySinh);
            this.panel1.Location = new System.Drawing.Point(8, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 206);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewTimKiem
            // 
            this.dataGridViewTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridViewTimKiem.Location = new System.Drawing.Point(8, 214);
            this.dataGridViewTimKiem.Name = "dataGridViewTimKiem";
            this.dataGridViewTimKiem.Size = new System.Drawing.Size(779, 205);
            this.dataGridViewTimKiem.TabIndex = 1;
            // 
            // radNgaySinh
            // 
            this.radNgaySinh.AutoSize = true;
            this.radNgaySinh.Location = new System.Drawing.Point(51, 70);
            this.radNgaySinh.Name = "radNgaySinh";
            this.radNgaySinh.Size = new System.Drawing.Size(74, 17);
            this.radNgaySinh.TabIndex = 0;
            this.radNgaySinh.TabStop = true;
            this.radNgaySinh.Text = "Ngày Sinh";
            this.radNgaySinh.UseVisualStyleBackColor = true;
            // 
            // radGioiTinh
            // 
            this.radGioiTinh.AutoSize = true;
            this.radGioiTinh.Location = new System.Drawing.Point(51, 109);
            this.radGioiTinh.Name = "radGioiTinh";
            this.radGioiTinh.Size = new System.Drawing.Size(69, 17);
            this.radGioiTinh.TabIndex = 0;
            this.radGioiTinh.TabStop = true;
            this.radGioiTinh.Text = "Giới Tính";
            this.radGioiTinh.UseVisualStyleBackColor = true;
            // 
            // radMaSV
            // 
            this.radMaSV.AutoSize = true;
            this.radMaSV.Location = new System.Drawing.Point(51, 28);
            this.radMaSV.Name = "radMaSV";
            this.radMaSV.Size = new System.Drawing.Size(54, 17);
            this.radMaSV.TabIndex = 0;
            this.radMaSV.TabStop = true;
            this.radMaSV.Text = "MaSV";
            this.radMaSV.UseVisualStyleBackColor = true;
            // 
            // radTruong
            // 
            this.radTruong.AutoSize = true;
            this.radTruong.Location = new System.Drawing.Point(285, 70);
            this.radTruong.Name = "radTruong";
            this.radTruong.Size = new System.Drawing.Size(59, 17);
            this.radTruong.TabIndex = 0;
            this.radTruong.TabStop = true;
            this.radTruong.Text = "Trường";
            this.radTruong.UseVisualStyleBackColor = true;
            // 
            // radLop
            // 
            this.radLop.AutoSize = true;
            this.radLop.Location = new System.Drawing.Point(285, 28);
            this.radLop.Name = "radLop";
            this.radLop.Size = new System.Drawing.Size(43, 17);
            this.radLop.TabIndex = 0;
            this.radLop.TabStop = true;
            this.radLop.Text = "Lớp";
            this.radLop.UseVisualStyleBackColor = true;
            // 
            // radQueQuan
            // 
            this.radQueQuan.AutoSize = true;
            this.radQueQuan.Location = new System.Drawing.Point(285, 109);
            this.radQueQuan.Name = "radQueQuan";
            this.radQueQuan.Size = new System.Drawing.Size(74, 17);
            this.radQueQuan.TabIndex = 0;
            this.radQueQuan.TabStop = true;
            this.radQueQuan.Text = "Quê Quán";
            this.radQueQuan.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(190, 159);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(71, 34);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaSV1
            // 
            this.txtMaSV1.Location = new System.Drawing.Point(111, 25);
            this.txtMaSV1.Name = "txtMaSV1";
            this.txtMaSV1.Size = new System.Drawing.Size(98, 20);
            this.txtMaSV1.TabIndex = 2;
            // 
            // txtLop1
            // 
            this.txtLop1.Location = new System.Drawing.Point(334, 28);
            this.txtLop1.Name = "txtLop1";
            this.txtLop1.Size = new System.Drawing.Size(98, 20);
            this.txtLop1.TabIndex = 2;
            // 
            // txtQueQuan1
            // 
            this.txtQueQuan1.Location = new System.Drawing.Point(365, 106);
            this.txtQueQuan1.Name = "txtQueQuan1";
            this.txtQueQuan1.Size = new System.Drawing.Size(98, 20);
            this.txtQueQuan1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 67);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // cbGioiTinh1
            // 
            this.cbGioiTinh1.FormattingEnabled = true;
            this.cbGioiTinh1.Location = new System.Drawing.Point(131, 109);
            this.cbGioiTinh1.Name = "cbGioiTinh1";
            this.cbGioiTinh1.Size = new System.Drawing.Size(121, 21);
            this.cbGioiTinh1.TabIndex = 4;
            // 
            // cbTruong1
            // 
            this.cbTruong1.FormattingEnabled = true;
            this.cbTruong1.Location = new System.Drawing.Point(350, 70);
            this.cbTruong1.Name = "cbTruong1";
            this.cbTruong1.Size = new System.Drawing.Size(121, 21);
            this.cbTruong1.TabIndex = 4;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã Sv";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Họ tên";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ngày sinh";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Giới tính";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Lớp";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Trường";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Quê Quán";
            this.Column14.Name = "Column14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.btnSua.ResumeLayout(false);
            this.btnSua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.Panel btnSua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.ComboBox cbTruong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dataGridViewTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radQueQuan;
        private System.Windows.Forms.RadioButton radGioiTinh;
        private System.Windows.Forms.RadioButton radLop;
        private System.Windows.Forms.RadioButton radMaSV;
        private System.Windows.Forms.RadioButton radTruong;
        private System.Windows.Forms.RadioButton radNgaySinh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.ComboBox cbTruong1;
        private System.Windows.Forms.ComboBox cbGioiTinh1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtQueQuan1;
        private System.Windows.Forms.TextBox txtLop1;
        private System.Windows.Forms.TextBox txtMaSV1;
    }
}


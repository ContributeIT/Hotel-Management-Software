namespace Quản_Lý_Khách_Sạn
{
    partial class PhieuThuePhong
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDauThue = new System.Windows.Forms.DateTimePicker();
            this.btnThue = new System.Windows.Forms.Button();
            this.txtDonGiaThue = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbbTenPhong = new System.Windows.Forms.ComboBox();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.cbbLoaiKhach = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv1_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1_TenKhachThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1_LoaiKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1_CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.GroupBox1.Controls.Add(this.dtpNgayBatDauThue);
            this.GroupBox1.Controls.Add(this.btnThue);
            this.GroupBox1.Controls.Add(this.txtDonGiaThue);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.cbbTenPhong);
            this.GroupBox1.Controls.Add(this.cbbLoaiPhong);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(337, 221);
            this.GroupBox1.TabIndex = 33;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Room information";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(132, 147);
            this.dtpNgayKetThuc.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKetThuc.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(194, 20);
            this.dtpNgayKetThuc.TabIndex = 4;
            // 
            // dtpNgayBatDauThue
            // 
            this.dtpNgayBatDauThue.Location = new System.Drawing.Point(132, 123);
            this.dtpNgayBatDauThue.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBatDauThue.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBatDauThue.Name = "dtpNgayBatDauThue";
            this.dtpNgayBatDauThue.Size = new System.Drawing.Size(194, 20);
            this.dtpNgayBatDauThue.TabIndex = 3;
            this.dtpNgayBatDauThue.ValueChanged += new System.EventHandler(this.dtpNgayBatDauThue_ValueChanged);
            // 
            // btnThue
            // 
            this.btnThue.Location = new System.Drawing.Point(251, 192);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(75, 23);
            this.btnThue.TabIndex = 5;
            this.btnThue.Text = "Rent";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // txtDonGiaThue
            // 
            this.txtDonGiaThue.Location = new System.Drawing.Point(132, 81);
            this.txtDonGiaThue.Name = "txtDonGiaThue";
            this.txtDonGiaThue.Size = new System.Drawing.Size(194, 20);
            this.txtDonGiaThue.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 13);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "PRICE RENT";
            // 
            // cbbTenPhong
            // 
            this.cbbTenPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenPhong.FormattingEnabled = true;
            this.cbbTenPhong.Location = new System.Drawing.Point(132, 47);
            this.cbbTenPhong.Name = "cbbTenPhong";
            this.cbbTenPhong.Size = new System.Drawing.Size(194, 21);
            this.cbbTenPhong.TabIndex = 1;
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(132, 13);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(194, 21);
            this.cbbLoaiPhong.TabIndex = 0;
            this.cbbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiPhong_SelectedIndexChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 16);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(71, 13);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "ROOM TYPE";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(6, 50);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(74, 13);
            this.Label10.TabIndex = 28;
            this.Label10.Text = "ROOM NAME";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 129);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(121, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "RENTAL START DATE";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 153);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(74, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "FINISH DATE";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnXong);
            this.GroupBox2.Controls.Add(this.btnXoa);
            this.GroupBox2.Controls.Add(this.btnSua);
            this.GroupBox2.Controls.Add(this.btnThem);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.label9);
            this.GroupBox2.Controls.Add(this.txtDiaChi);
            this.GroupBox2.Controls.Add(this.txtCMND);
            this.GroupBox2.Controls.Add(this.txtTenKhach);
            this.GroupBox2.Controls.Add(this.cbbLoaiKhach);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Location = new System.Drawing.Point(355, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(325, 221);
            this.GroupBox2.TabIndex = 34;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Customer information";
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(248, 192);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(70, 23);
            this.btnXong.TabIndex = 7;
            this.btnXong.Text = "Done";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(143, 192);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(76, 192);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Edit";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(9, 192);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Add";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 16);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(104, 13);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "CUSTOMER INFOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "CUSTOMER TYPE";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(113, 109);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(205, 62);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(114, 77);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(205, 20);
            this.txtCMND.TabIndex = 2;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(113, 13);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(205, 20);
            this.txtTenKhach.TabIndex = 0;
            // 
            // cbbLoaiKhach
            // 
            this.cbbLoaiKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiKhach.FormattingEnabled = true;
            this.cbbLoaiKhach.Location = new System.Drawing.Point(113, 45);
            this.cbbLoaiKhach.Name = "cbbLoaiKhach";
            this.cbbLoaiKhach.Size = new System.Drawing.Size(205, 21);
            this.cbbLoaiKhach.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 81);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(90, 13);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "IDENTITY CARD";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 112);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(59, 13);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "ADDRESS";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv1_STT,
            this.dgv1_TenKhachThue,
            this.dgv1_LoaiKhach,
            this.dgv1_CMND,
            this.dgv1_DiaChi});
            this.dgv1.Location = new System.Drawing.Point(12, 239);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(668, 127);
            this.dgv1.TabIndex = 35;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_RowEnter);
            // 
            // dgv1_STT
            // 
            this.dgv1_STT.FillWeight = 126.9036F;
            this.dgv1_STT.HeaderText = "STT";
            this.dgv1_STT.Name = "dgv1_STT";
            this.dgv1_STT.ReadOnly = true;
            // 
            // dgv1_TenKhachThue
            // 
            this.dgv1_TenKhachThue.FillWeight = 93.27411F;
            this.dgv1_TenKhachThue.HeaderText = "Tên khách thuê";
            this.dgv1_TenKhachThue.Name = "dgv1_TenKhachThue";
            this.dgv1_TenKhachThue.ReadOnly = true;
            // 
            // dgv1_LoaiKhach
            // 
            this.dgv1_LoaiKhach.FillWeight = 93.27411F;
            this.dgv1_LoaiKhach.HeaderText = "Loại khách";
            this.dgv1_LoaiKhach.Name = "dgv1_LoaiKhach";
            this.dgv1_LoaiKhach.ReadOnly = true;
            // 
            // dgv1_CMND
            // 
            this.dgv1_CMND.FillWeight = 93.27411F;
            this.dgv1_CMND.HeaderText = "CMND";
            this.dgv1_CMND.Name = "dgv1_CMND";
            this.dgv1_CMND.ReadOnly = true;
            // 
            // dgv1_DiaChi
            // 
            this.dgv1_DiaChi.FillWeight = 93.27411F;
            this.dgv1_DiaChi.HeaderText = "Địa chỉ";
            this.dgv1_DiaChi.Name = "dgv1_DiaChi";
            this.dgv1_DiaChi.ReadOnly = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(518, 372);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 20);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // PhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 404);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "PhieuThuePhong";
            this.Text = "Create votes room rental";
            this.Load += new System.EventHandler(this.PhieuThuePhong_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        internal System.Windows.Forms.DateTimePicker dtpNgayBatDauThue;
        internal System.Windows.Forms.Button btnThue;
        internal System.Windows.Forms.TextBox txtDonGiaThue;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbbTenPhong;
        internal System.Windows.Forms.ComboBox cbbLoaiPhong;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnXong;
        internal System.Windows.Forms.Button btnXoa;
        internal System.Windows.Forms.Button btnSua;
        internal System.Windows.Forms.Button btnThem;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtDiaChi;
        internal System.Windows.Forms.TextBox txtCMND;
        internal System.Windows.Forms.TextBox txtTenKhach;
        internal System.Windows.Forms.ComboBox cbbLoaiKhach;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DataGridView dgv1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgv1_STT;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgv1_TenKhachThue;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgv1_LoaiKhach;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgv1_CMND;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgv1_DiaChi;
        internal System.Windows.Forms.Button btnThoat;
    }
}
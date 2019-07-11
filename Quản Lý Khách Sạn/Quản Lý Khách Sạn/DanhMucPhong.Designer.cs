namespace Quản_Lý_Khách_Sạn
{
    partial class DanhMucPhong
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
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDanhMucPhong = new System.Windows.Forms.DataGridView();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cbbMaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(158, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(195, 25);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ROOM CATALOG";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(434, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(332, 186);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(230, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDanhMucPhong
            // 
            this.dgvDanhMucPhong.AllowUserToAddRows = false;
            this.dgvDanhMucPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucPhong.Location = new System.Drawing.Point(12, 226);
            this.dgvDanhMucPhong.Name = "dgvDanhMucPhong";
            this.dgvDanhMucPhong.ReadOnly = true;
            this.dgvDanhMucPhong.Size = new System.Drawing.Size(512, 153);
            this.dgvDanhMucPhong.TabIndex = 26;
            this.dgvDanhMucPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMucPhong_CellClick);
            this.dgvDanhMucPhong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDanhMucPhong_KeyDown);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(286, 52);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 13);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "UNIT PRICE";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Control;
            this.txtDonGia.Location = new System.Drawing.Point(360, 49);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(135, 20);
            this.txtDonGia.TabIndex = 24;
            // 
            // cbbMaLoaiPhong
            // 
            this.cbbMaLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaLoaiPhong.FormattingEnabled = true;
            this.cbbMaLoaiPhong.Location = new System.Drawing.Point(127, 49);
            this.cbbMaLoaiPhong.Name = "cbbMaLoaiPhong";
            this.cbbMaLoaiPhong.Size = new System.Drawing.Size(153, 21);
            this.cbbMaLoaiPhong.TabIndex = 1;
            this.cbbMaLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbbMaLoaiPhong_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 79);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(37, 13);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "NOTE";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(127, 79);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(368, 54);
            this.txtGhiChu.TabIndex = 2;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(127, 19);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(368, 20);
            this.txtTenPhong.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 52);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(104, 13);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "ROOM TYPE CODE";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 13);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "ROOM NAME";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.txtTenPhong);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.cbbMaLoaiPhong);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 143);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // DanhMucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDanhMucPhong);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Label1);
            this.Name = "DanhMucPhong";
            this.Text = "Create room catalog";
            this.Load += new System.EventHandler(this.DanhMucPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.DataGridView dgvDanhMucPhong;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtDonGia;
        internal System.Windows.Forms.ComboBox cbbMaLoaiPhong;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtGhiChu;
        internal System.Windows.Forms.TextBox txtTenPhong;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
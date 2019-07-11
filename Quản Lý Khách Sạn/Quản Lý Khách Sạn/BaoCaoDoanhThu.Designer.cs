namespace Quản_Lý_Khách_Sạn
{
    partial class BaoCaoDoanhThu
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
            this.lblTDT2 = new System.Windows.Forms.Label();
            this.lblTDT = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.dtpThangBaoCao = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTDT2
            // 
            this.lblTDT2.AutoSize = true;
            this.lblTDT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTDT2.Location = new System.Drawing.Point(443, 331);
            this.lblTDT2.Name = "lblTDT2";
            this.lblTDT2.Size = new System.Drawing.Size(31, 20);
            this.lblTDT2.TabIndex = 22;
            this.lblTDT2.Text = "0,0";
            this.lblTDT2.Visible = false;
            // 
            // lblTDT
            // 
            this.lblTDT.AutoSize = true;
            this.lblTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTDT.Location = new System.Drawing.Point(302, 331);
            this.lblTDT.Name = "lblTDT";
            this.lblTDT.Size = new System.Drawing.Size(108, 20);
            this.lblTDT.TabIndex = 21;
            this.lblTDT.Text = "Revenue total";
            this.lblTDT.Visible = false;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(17, 114);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.Size = new System.Drawing.Size(581, 205);
            this.dgvBaoCao.TabIndex = 20;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(523, 29);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 58);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(312, 36);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(118, 23);
            this.btnBaoCao.TabIndex = 18;
            this.btnBaoCao.Text = "View report";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(140, 56);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(111, 21);
            this.cbbLoaiPhong.TabIndex = 17;
            // 
            // dtpThangBaoCao
            // 
            this.dtpThangBaoCao.CustomFormat = "MM/yyyy";
            this.dtpThangBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangBaoCao.Location = new System.Drawing.Point(140, 22);
            this.dtpThangBaoCao.Name = "dtpThangBaoCao";
            this.dtpThangBaoCao.Size = new System.Drawing.Size(111, 23);
            this.dtpThangBaoCao.TabIndex = 16;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(49, 59);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Room type";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(72, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Month";
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 368);
            this.Controls.Add(this.lblTDT2);
            this.Controls.Add(this.lblTDT);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.cbbLoaiPhong);
            this.Controls.Add(this.dtpThangBaoCao);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "BaoCaoDoanhThu";
            this.Text = "Revenue report";
            this.Load += new System.EventHandler(this.BaoCaoDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblTDT2;
        internal System.Windows.Forms.Label lblTDT;
        internal System.Windows.Forms.DataGridView dgvBaoCao;
        internal System.Windows.Forms.Button btnThoat;
        internal System.Windows.Forms.Button btnBaoCao;
        internal System.Windows.Forms.ComboBox cbbLoaiPhong;
        internal System.Windows.Forms.DateTimePicker dtpThangBaoCao;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}
namespace Quản_Lý_Khách_Sạn
{
    partial class TimKiemPhong
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
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(336, 23);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(242, 20);
            this.txtTenPhong.TabIndex = 1;
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(251, 91);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(117, 23);
            this.btnTimLai.TabIndex = 3;
            this.btnTimLai.Text = "Find";
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(491, 91);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(105, 91);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(117, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 120);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(587, 205);
            this.dgv1.TabIndex = 17;
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(78, 23);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(144, 21);
            this.cbbLoaiPhong.TabIndex = 0;
            this.cbbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiPhong_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(271, 26);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 13);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Room name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 13);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Room type";
            // 
            // TimKiemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 337);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.btnTimLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cbbLoaiPhong);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Name = "TimKiemPhong";
            this.Text = "Room search";
            this.Load += new System.EventHandler(this.TimKiemPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtTenPhong;
        internal System.Windows.Forms.Button btnTimLai;
        internal System.Windows.Forms.Button btnThoat;
        internal System.Windows.Forms.Button btnTimKiem;
        internal System.Windows.Forms.DataGridView dgv1;
        internal System.Windows.Forms.ComboBox cbbLoaiPhong;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
    }
}
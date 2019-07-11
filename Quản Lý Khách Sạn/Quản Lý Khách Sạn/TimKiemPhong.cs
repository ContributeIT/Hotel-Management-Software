using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Khách_Sạn
{
    public partial class TimKiemPhong : Form
    {
        private TABLE Table = new TABLE();
        public TimKiemPhong()
        {
            InitializeComponent();
        }

        private void TimKiemPhong_Load(object sender, EventArgs e)
        {
            try
            {
                Table.cbb_DataLoad(cbbLoaiPhong, "LOAIPHONG", "MaLoaiPhong", "TenLoaiPhong", "", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cbbLoaiPhong.SelectedIndex = cbbLoaiPhong.Items.Count - 1;
            }
        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTenPhong.Text = "";
            //txtTenPhong.Enabled = false;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable result = Table.Read("SELECT phong.tenphong AS 'Tên phòng', loaiphong.tenloaiphong As 'Loại phòng', loaiphong.dongia AS 'Đơn giá', phong.ghichu AS 'Ghi chú' FROM phong INNER JOIN loaiphong ON phong.maloaiphong = loaiphong.maloaiphong" +
                                            " WHERE INSTR(phong.tenphong, '" + txtTenPhong.Text + "') > 0 AND INSTR(loaiphong.maloaiphong, '" + cbbLoaiPhong.SelectedValue.ToString() + "') > 0");
            dgv1.DataSource = result;
        }
        private void btnTimLai_Click(object sender, EventArgs e)
        {
            cbbLoaiPhong.SelectedIndex = cbbLoaiPhong.Items.Count - 1;
            txtTenPhong.Text = "";

            cbbLoaiPhong.Enabled = true;
            txtTenPhong.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

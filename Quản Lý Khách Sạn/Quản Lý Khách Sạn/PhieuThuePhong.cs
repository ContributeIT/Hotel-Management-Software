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
    public partial class PhieuThuePhong : Form
    {
        private bool ChuaLuu = false;
        public PhieuThuePhong()
        {
            InitializeComponent();
        }
        private TABLE Table = new TABLE();
        private void PhieuThuePhong_Load(object sender, EventArgs e)
        {
            GroupBox1.Enabled = true;
            GroupBox2.Enabled = false;
            txtDonGiaThue.Enabled = false;

            dgv1.Columns[0].Width = 30;
            dgv1.Columns[1].Width = 100;
            dgv1.Columns[2].Width = 100;
            dgv1.Columns[3].Width = 100;
            dgv1.Columns[4].Width = 300;

            //Load dữ liệu vào combobox
            try
            {
                Table.cbb_DataLoad(cbbLoaiPhong, "LOAIPHONG", "MaLoaiPhong", "TenLoaiPhong");
                Table.cbb_DataLoad(cbbLoaiKhach, "LOAIKHACH", "MaLoaiKhach", "TenLoaiKhach");
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

            dtpNgayBatDauThue.MinDate = System.DateTime.Now;
            dtpNgayBatDauThue.MaxDate = dtpNgayBatDauThue.MinDate.AddYears(1);  //Giới hạn lại 1 năm
            
            dtpNgayBatDauThue_ValueChanged(sender, e);
        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Table.cbb_DataLoad(cbbTenPhong, "PHONG", "MaPhong", "TenPhong", "where MaLoaiPhong = '" + cbbLoaiPhong.SelectedValue.ToString() + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            DataTable bangLoaiPhong = Table.Read("Select * from LOAIPHONG");
            foreach (DataRow row in bangLoaiPhong.Rows)
            {
                if (cbbLoaiPhong.SelectedValue.Equals(row["MaLoaiPhong"]))
                {
                    txtDonGiaThue.Text = row["DonGia"].ToString();
                }
            }
        }
        private void btnThue_Click(object sender, EventArgs e)
        {
            ChuaLuu = true;
            if (MessageBox.Show("Select this room?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GroupBox1.Enabled = false;
                GroupBox2.Enabled = true;
                BoxesReadOnly(true);
            }
        }
        private void dtpNgayBatDauThue_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayKetThuc.MinDate = dtpNgayBatDauThue.Value;
            dtpNgayKetThuc.MaxDate = dtpNgayKetThuc.MinDate.AddYears(2);
            //Cho thuê phong tối đa là 2 năm hoy
        }
        private bool NhapHopLe()
        {
            if (txtTenKhach.Text == "" || txtCMND.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Please enter full information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            // (thêm kiểm tra CMND nếu được)

            return true;
        }
        private void BoxesReadOnly(bool b)
        {
            txtTenKhach.ReadOnly = b;
            txtCMND.ReadOnly = b;
            txtDiaChi.ReadOnly = b;
            cbbLoaiKhach.Enabled = !b;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Add")
            {
                DataTable soKhachToiDa = Table.Read("Select SoKhachToiDa from THAMSO");
                if ((dgv1.Rows.Count < int.Parse(soKhachToiDa.Rows[0][0].ToString())))
                {
                    btnThem.Text = "Save";
                    btnXong.Text = "Cancel";
                    BoxesReadOnly(false);
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Maximun customer of one room " + dgv1.Rows.Count.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (NhapHopLe())
                {
                    dgv1.Rows.Add(new string[] {
			    "",
			    txtTenKhach.Text,
			    cbbLoaiKhach.Text,
			    txtCMND.Text,
			    txtDiaChi.Text
		        }); dgv1.Select();

                    btnThem.Text = "Add";
                    btnXong.Text = "Done";
                    BoxesReadOnly(true);
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnXong.Enabled = true;

                    txtTenKhach.Clear();
                    txtCMND.Clear();
                    txtDiaChi.Clear();
                    cbbLoaiKhach.SelectedIndex = 0;
                }
                else
                {
                    return;
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Edit")
            {
                btnSua.Text = "Save";
                btnXong.Text = "Cancel";
                BoxesReadOnly(false);
                btnThem.Enabled = false;
                btnXoa.Enabled = false;

                txtTenKhach.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                txtCMND.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dgv1.CurrentRow.Cells[4].Value.ToString();

                int index = 0;
                index = cbbLoaiKhach.FindString(dgv1.CurrentRow.Cells[2].Value.ToString());
                cbbLoaiKhach.SelectedIndex = index;

                dgv1.Enabled = false;
            }
            else
            {
                if (NhapHopLe())
                {
                    dgv1.CurrentRow.Cells[1].Value = txtTenKhach.Text;
                    dgv1.CurrentRow.Cells[2].Value = cbbLoaiKhach.Text;
                    dgv1.CurrentRow.Cells[3].Value = txtCMND.Text;
                    dgv1.CurrentRow.Cells[4].Value = txtDiaChi.Text;
                    //dgv1.Select()      

                    btnSua.Text = "Edit";
                    btnXong.Text = "Done";
                    BoxesReadOnly(true);
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;

                    txtTenKhach.Clear();
                    txtCMND.Clear();
                    txtDiaChi.Clear();
                    cbbLoaiKhach.SelectedIndex = 0;

                    dgv1.Enabled = true;
                }
                else
                {
                    return;
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgv1.Enabled = false;
            if( MessageBox.Show("Remove customer " + dgv1.CurrentRow.Cells[1].Value.ToString() + "?", "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index);
                dgv1.Select();
            }
            dgv1.Enabled = true;
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (btnXong.Text == "Done")
            {
                ChuaLuu = false;
                if (dgv1.Rows.Count > 0)
                {
                    Them_PhieuThuePhong();
                }
                GroupBox1.Enabled = true;
                GroupBox2.Enabled = false;
                dgv1.Rows.Clear();
            }
            else
            {
                BoxesReadOnly(true);

                txtTenKhach.Clear();
                txtCMND.Clear();
                txtDiaChi.Clear();

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                btnThem.Text = "Add";
                btnSua.Text = "Edit";
                btnXong.Text = "Done";

                dgv1.Enabled = true;
            }
        }
        private void Them_PhieuThuePhong()
        {
            DataTable bangPhieuThue = Table.Read("select * from PHIEUTHUEPHONG");
            DataRow PhieuThue = bangPhieuThue.NewRow();

            // Tạo khóa chính cho phiếu thuê mới
            string maPhieuThue = "pt";
            string str = "";
            int iNum = 0;
            do
            {
                str = maPhieuThue + iNum.ToString("0000");
                int I = 0;
                for (int i = 0; i <= bangPhieuThue.Rows.Count - 1; i++)
                {
                    if ((str.Trim() == bangPhieuThue.Rows[i].ItemArray[0].ToString().Trim()))
                    {
                        I += 1;
                    }
                }
                if ((I == 0))
                {
                    PhieuThue["MaPhieuThue"] = str.Trim();
                }
                iNum += 1;
            } while ((PhieuThue["MaPhieuThue"].Equals(DBNull.Value)));

            PhieuThue["NgayBatDauThue"] = dtpNgayBatDauThue.Value.Date;
            PhieuThue["NgayKetThuc"] = dtpNgayKetThuc.Value.Date;
            PhieuThue["DonGiaThue"] = txtDonGiaThue.Text;
            PhieuThue["SoNgayThue"] = dtpNgayKetThuc.Value.Subtract(dtpNgayBatDauThue.Value).Days;
            PhieuThue["SoLuongKhach"] = dgv1.Rows.Count;
            PhieuThue["ThanhTien"] = (Convert.ToInt32(txtDonGiaThue.Text) * dtpNgayKetThuc.Value.Subtract(dtpNgayBatDauThue.Value).Days).ToString();
            PhieuThue["MaPhong"] = cbbTenPhong.SelectedValue;

            bangPhieuThue.Rows.Add(PhieuThue);
            Table.Write(bangPhieuThue, "PHIEUTHUEPHONG");

            //   Thêm Chi tiết phiếu thuê
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                Them_ChiTietPhieuThue(PhieuThue["MaPhieuThue"].ToString(), row);
            }
        }
        private void Them_ChiTietPhieuThue(string MaPhieuThue, DataGridViewRow data)
        {
            DataTable bangChiTietPhieuThue = Table.Read("select * from CHITIETPHIEUTHUE");
            DataRow ChiTietPhieuThue = bangChiTietPhieuThue.NewRow();

            // Tạo khóa chính cho phiếu thuê mới
            string maChiTietPhieuThue = "ctpt";
            string str = "";
            int iNum = 0;
            do
            {
                str = maChiTietPhieuThue + iNum.ToString("00000");
                int I = 0;
                for (int i = 0; i <= bangChiTietPhieuThue.Rows.Count - 1; i++)
                {
                    if ((str.Trim() == bangChiTietPhieuThue.Rows[i].ItemArray[0].ToString().Trim()))
                    {
                        I += 1;
                    }
                }
                if ((I == 0))
                {
                    ChiTietPhieuThue["MaChiTietPhieuThue"] = str.Trim();
                }
                iNum += 1;
            } while ((ChiTietPhieuThue["MaChiTietPhieuThue"].Equals(DBNull.Value)));

            ChiTietPhieuThue["TenKhachThue"] = data.Cells[1].Value;
            ChiTietPhieuThue["CMND"] = data.Cells[3].Value;
            ChiTietPhieuThue["DiaChi"] = data.Cells[4].Value;
            ChiTietPhieuThue["MaPhieuThue"] = MaPhieuThue;

            int index = 0;
            index = cbbLoaiKhach.FindString(data.Cells[2].Value.ToString());
            cbbLoaiKhach.SelectedIndex = index;
            ChiTietPhieuThue["MaLoaiKhach"] = cbbLoaiKhach.SelectedValue;

            bangChiTietPhieuThue.Rows.Add(ChiTietPhieuThue);
            Table.Write(bangChiTietPhieuThue, "CHITIETPHIEUTHUE");
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }
        private void dgv1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i <= dgv1.Rows.Count - 1; i++)
            {
                dgv1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (ChuaLuu)
            {
                if (MessageBox.Show("Customer information has not been saved\nExit without saving?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
                this.Close();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

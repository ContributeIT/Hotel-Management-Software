using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Quản_Lý_Khách_Sạn
{
    public partial class DanhMucPhong : Form
    {
        public TABLE Table = new TABLE();
        public string queryDanhMuc = "SELECT PHONG.TenPhong, PHONG.MaLoaiPhong, LOAIPHONG.DonGia, PHONG.GhiChu, PHONG.MaPhong FROM PHONG INNER JOIN LOAIPHONG ON PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong  order by phong.tenphong;";
        public DanhMucPhong()
        {
            InitializeComponent();         
        }
        public void dgvDanhMucPhong_Show() // Show queryDanhMuc vào cái datagridview
        {
            try
            {
                dgvDanhMucPhong.DataSource = Table.Read(queryDanhMuc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvDanhMucPhong.Columns["MaPhong"].Visible = false;
        }
        private void DanhMucPhong_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;

            DataTable bangLoaiPhong = new DataTable();
            try
            {
                bangLoaiPhong = Table.Read("Select * from LOAIPHONG");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cbbMaLoaiPhong.DataSource = bangLoaiPhong;
                cbbMaLoaiPhong.ValueMember = "MaLoaiPhong";
                cbbMaLoaiPhong.DisplayMember = "MaLoaiPhong";

                txtDonGia.Text = bangLoaiPhong.Rows[0].ItemArray[2].ToString();
            }
            
            dgvDanhMucPhong_Show();
            dgvDanhMucPhong_CellClick(sender, e);   // tránh tình trạng DataGridView.CurrentRow = NULL
        }
        private void XoaPhong()
        {
            dgvDanhMucPhong.Enabled = false;
            if (MessageBox.Show("Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "delete from PHONG where MaPhong = '" + dgvDanhMucPhong.CurrentRow.Cells["MaPhong"].Value.ToString() + "'";
                OleDbConnection cn = new OleDbConnection();
                cn.ConnectionString ="Provider=Microsoft.Jet.OLEDB.4.0;Data Source= QuanLyKhachSan.mdb";
                cn.Open();
                using (OleDbCommand cmd = new OleDbCommand(delete, cn))
                {
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
            dgvDanhMucPhong.Enabled = true;
        }
        private void dgvDanhMucPhong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                XoaPhong();
                dgvDanhMucPhong_Show();
                dgvDanhMucPhong_CellClick(sender, e);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            XoaPhong();
            dgvDanhMucPhong_Show();
            dgvDanhMucPhong_CellClick(sender, e);
        }
        private void cbbMaLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable bangLoaiPhong = Table.Read("select * From LOAIPHONG");
            foreach (DataRow row in bangLoaiPhong.Rows)
            {
                if (cbbMaLoaiPhong.SelectedValue.Equals(row["MaLoaiPhong"]))
                {
                    txtDonGia.Text = row["DonGia"].ToString();
                }
            }
        }
        private bool NhapHopLe()
        {
            if (txtTenPhong.Text.Trim() == "")
            {
                MessageBox.Show("Please enter full information!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        private bool ChuaLuu = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                ChuaLuu = true;
                btnAdd.Text = "Save";

                txtTenPhong.Text = "";
                txtGhiChu.Text = "";

                groupBox1.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                if (NhapHopLe())
                {
                    DataTable BangPHONG = Table.Read("Select * from PHONG");
                    DataRow Phong = BangPHONG.NewRow();

                    // Primary key (MaPhong) tự thêm vào khi tạo dòng mới
                    string maPhong = "p";
                    string str = "";
                    int iNum = 0;
                    do
                    {
                        str = maPhong + iNum.ToString("000");
                        int I = 0;
                        for (int i = 0; i <= BangPHONG.Rows.Count - 1; i++)
                        {
                            if ((str.Trim() == BangPHONG.Rows[i].ItemArray[0].ToString().Trim()))
                            {
                                I += 1;
                            }
                        }
                        if ((I == 0))
                        {
                            Phong["MaPhong"] = str.Trim();
                        }
                        iNum += 1;
                    } while ((Phong["MaPhong"].Equals(DBNull.Value)));
                    //
                    Phong["TenPhong"] = txtTenPhong.Text.Trim();
                    Phong["MaLoaiPhong"] = cbbMaLoaiPhong.SelectedValue;
                    Phong["GhiChu"] = txtGhiChu.Text.Trim();
                    // Vấn đề là nó chỉ thay đổi database trong \bin\Debug chứ ko thay đổi database gốc
                    // sau khi chạy lại thì cái gốc lại copy đè vào \bin\Debug nên mất hết cơ

                    BangPHONG.Rows.Add(Phong);
                    Table.Write(BangPHONG, "PHONG");

                    dgvDanhMucPhong_Show();
                    //
                    ChuaLuu = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                    btnAdd.Text = "Add";
                    groupBox1.Enabled = false;

                    txtTenPhong.Clear();
                    txtGhiChu.Clear();

                    dgvDanhMucPhong_CellClick(sender, e);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                ChuaLuu = true;
                btnEdit.Text = "Save";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                groupBox1.Enabled = true;
            }
            else
            {
                if (NhapHopLe())
                {
                    DataTable BangPHONG =  Table.Read("update PHONG set TenPhong = '" + txtTenPhong.Text.Trim() + "', GhiChu = '" + txtGhiChu.Text.Trim() + "', MaLoaiPhong = '" + cbbMaLoaiPhong.SelectedValue + "' where MaPhong = '" + dgvDanhMucPhong.CurrentRow.Cells["MaPhong"].Value.ToString() + "';");
                    Table.Write(BangPHONG, "PHONG");

                    dgvDanhMucPhong_Show();
                    //
                    ChuaLuu = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;

                    btnEdit.Text = "Edit";
                    groupBox1.Enabled = false;

                    txtTenPhong.Clear();
                    txtGhiChu.Clear();

                    dgvDanhMucPhong_CellClick(sender, e);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (ChuaLuu)    // chưa lưu thông tin khách hàng
            {
                if (MessageBox.Show("Customer information has not been saved\n\tExit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
                this.Close();
        }
        private void dgvDanhMucPhong_CellClick(object sender, EventArgs e)
        {
            if ((dgvDanhMucPhong.CurrentRow != null))
            {
                txtTenPhong.Text = dgvDanhMucPhong.CurrentRow.Cells[0].Value.ToString();
                txtDonGia.Text = dgvDanhMucPhong.CurrentRow.Cells[2].Value.ToString();
                txtGhiChu.Text = dgvDanhMucPhong.CurrentRow.Cells[3].Value.ToString();
                int index = 0;
                index = cbbMaLoaiPhong.FindString(dgvDanhMucPhong.CurrentRow.Cells[1].Value.ToString());
                cbbMaLoaiPhong.SelectedIndex = index;
            }
        }
    }
}

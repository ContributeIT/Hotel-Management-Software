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
    public partial class BaoCaoDoanhThu : Form
    {
        private TABLE Table = new TABLE();
        private DataTable DoanhThu = new DataTable();
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            Table.cbb_DataLoad(cbbLoaiPhong, "LOAIPHONG", "MaLoaiPhong", "TenLoaiPhong");
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DoanhThu.Clear();
            double tongDoanhThu = 0;
            string query = "";
            int month = dtpThangBaoCao.Value.Month;
            try
            {
                query = "SELECT PHONG.TenPhong, CHITIETPHIEUTHUE.TenKhachThue, LOAIKHACH.TenLoaiKhach, LOAIPHONG.DonGia, LOAIKHACH.HeSoKhachHang, PHIEUTHUEPHONG.NgayBatDauThue, PHIEUTHUEPHONG.NgayKetThuc" +
                        " FROM PHONG, CHITIETPHIEUTHUE, LOAIKHACH, LOAIPHONG, PHIEUTHUEPHONG" +
                        " WHERE PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong AND CHITIETPHIEUTHUE.MaPhieuThue = PHIEUTHUEPHONG.MaPhieuThue AND CHITIETPHIEUTHUE.MaLoaiKhach = LOAIKHACH.MaLoaiKhach AND PHIEUTHUEPHONG.MaPhong = PHONG.MaPhong" +
                        " AND LOAIPHONG.MaLoaiPhong = '" + cbbLoaiPhong.SelectedValue.ToString() + "'" + " AND (MONTH(PHIEUTHUEPHONG.NgayBatDauThue) = " + month.ToString() + " OR MONTH(PHIEUTHUEPHONG.NgayKetThuc) = " + month.ToString() + ")";
                DoanhThu = Table.Read(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvBaoCao.DataSource = DoanhThu;
            }

            int stt = 0;

            DataColumn cl = new DataColumn("DoanhThu");
            if ((DoanhThu.Columns.Contains("DoanhThu") == false))
            {
                DoanhThu.Columns.Add(cl);
            }

            foreach (DataRow row in DoanhThu.Rows)
            {
                TimeSpan songay = Convert.ToDateTime(row["NgayKetThuc"]) - Convert.ToDateTime(row["NgayBatDauThue"]);
                row["DoanhThu"] = songay.Days * Convert.ToInt32(row["DonGia"]) * Convert.ToInt32(row["HeSoKhachHang"]);
                tongDoanhThu += Convert.ToInt32(row["DoanhThu"]);
            }
            lblTDT.Visible = true;
            lblTDT2.Visible = true;
            lblTDT2.Text = tongDoanhThu.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

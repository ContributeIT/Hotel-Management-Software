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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMucPhong form = new DanhMucPhong();
            form.ShowDialog();
        }

        private void btnPhieuThue_Click(object sender, EventArgs e)
        {
            PhieuThuePhong form = new PhieuThuePhong();
            form.ShowDialog();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemPhong form = new TimKiemPhong();
            form.ShowDialog();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu form = new BaoCaoDoanhThu();
            form.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

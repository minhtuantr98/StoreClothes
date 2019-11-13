using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanQuanAoNam
{
    public partial class InPhieuNhapHang : Form
    {
        public InPhieuNhapHang()
        {
            InitializeComponent();
        }

        private void txtNgayNhap_TextChanged(object sender, EventArgs e)
        {

        }
        private void HienThi_Luoi(string sql)
        {
            DataTable tblKH;
            tblKH = ThucThiSql.DocBang(sql);
            dataGridView1.DataSource = tblKH;
            dataGridView1.Columns[0].HeaderText = "Mã Mặt Hàng";
            dataGridView1.Columns[1].HeaderText = "Tên Mặt Hàng";
            dataGridView1.Columns[2].HeaderText = "Đơn Giá";
            dataGridView1.Columns[3].HeaderText = "Số Lượng";
            dataGridView1.Columns[4].HeaderText = "Nhà Cung Cấp";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblKH.Dispose();
        }
        private void InPhieuNhapHang_Load(object sender, EventArgs e)
        {
            string sql = "Select MatHang.MaMH,TenMH,DonGia,MatHang.SL,MaNCC from (PhieuNhap join ChiTietPN on PhieuNhap.MaPN = ChiTietPN.MaPN) join MatHang on MatHang.MaMH=ChiTietPN.MaMH where  ChiTietPN.MaPN ='"+txtMaPhieu.Text+"'";
            HienThi_Luoi(sql);
        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

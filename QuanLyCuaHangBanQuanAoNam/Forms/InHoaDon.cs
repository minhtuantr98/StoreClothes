using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanQuanAoNam.Forms
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        private void HienThi_Luoi(string sql)
        {
            DataTable tblKH;
            tblKH = ThucThiSql.DocBang(sql);
            dataGridView1.DataSource = tblKH;
            dataGridView1.Columns[0].HeaderText = "Mã Hàng Hóa";
            dataGridView1.Columns[1].HeaderText = "Tên Hàng Hóa";
            dataGridView1.Columns[2].HeaderText = "Kích Cỡ";
            dataGridView1.Columns[3].HeaderText = "Màu Sắc";
            dataGridView1.Columns[4].HeaderText = "Đơn Giá";
            dataGridView1.Columns[5].HeaderText = "Số Lượng";


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblKH.Dispose();
        }
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            string sql = "Select ChiTietHD.MaHH,TenMH,KichCo,MauSac,MatHang.DonGia,ChiTietHD.SL From (MatHang join HangHoa on MatHang.MaMH = HangHoa.MaMH) join ChiTietHD on ChiTietHD.MaHH = HangHoa.MaHH where ChiTietHD.MaHD='"+txtMaPhieu.Text+"'";
            HienThi_Luoi(sql);
        }
    }
}

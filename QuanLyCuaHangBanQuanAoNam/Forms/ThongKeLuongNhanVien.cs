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
    public partial class ThongKeLuongNhanVien : Form
    {
        public ThongKeLuongNhanVien()
        {
            InitializeComponent();
        }

        private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Thang = cbxMonth.Text;
            string year = cbxYear.Text;
            int luong = 3000000;
            int bonus = 3000;

            string sql = "Select HoTen,'" + luong + "'+SUM(ChiTietHD.SL)*'"+bonus+"',SUM(ChiTietHD.SL) as SoLuongBan From (HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD)join NhanVien on NhanVien.MaNV = HoaDon.MaNV where  DATEPART(MONTH,CAST(NgayLap as date))='" + Thang + "' and  DATEPART(YEAR,CAST(NgayLap as date))='" + year + "' group by HoTen";
            HienThi_Luoi(sql);
        }

        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
  
                string Thang = cbxMonth.Text;
                string year = cbxYear.Text;
                int luong = 3000000;
            int bonus = 3000;
            string sql = "Select HoTen,'"+luong+ "'+SUM(ChiTietHD.SL)*'" + bonus + "',SUM(ChiTietHD.SL) as SoLuongBan From (HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD)join NhanVien on NhanVien.MaNV = HoaDon.MaNV where  DATEPART(MONTH,CAST(NgayLap as date))='" + Thang + "' and  DATEPART(YEAR,CAST(NgayLap as date))='" + year + "' group by HoTen";
                    HienThi_Luoi(sql);
              
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void HienThi_Luoi(string sql)
        {
            DataTable tblKH;
            tblKH = ThucThiSql.DocBang(sql);
            dataGridView1.DataSource = tblKH;
            dataGridView1.Columns[0].HeaderText = "Nhân Viên";
            dataGridView1.Columns[1].HeaderText = "Lương";
            dataGridView1.Columns[2].HeaderText = "Số sản phẩm bán được";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblKH.Dispose();
        }
        private void ThongKeLuongNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}

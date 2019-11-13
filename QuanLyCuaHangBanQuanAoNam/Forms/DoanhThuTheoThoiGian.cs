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
	public partial class DoanhThuTheoThoiGian : Form
	{
		public DoanhThuTheoThoiGian()
		{
			InitializeComponent();
		}
		private void HienThi_Luoi(string sql)
		{
			DataTable tblKH;
			tblKH = ThucThiSql.DocBang(sql);
			dataGridView1.DataSource = tblKH;
			dataGridView1.Columns[0].HeaderText = "Năm-Tháng";
			dataGridView1.Columns[1].HeaderText = "Doanh Thu";
			dataGridView1.Columns[2].HeaderText = "Số lượng bán";
			//dataGridView1.Columns[3].HeaderText = "Số lượng bán";

			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
			tblKH.Dispose();
		}
		

		private void cbxMonth_SelectedValueChanged(object sender, EventArgs e)
		{
			string Thang = cbxMonth.Text;
			string year = cbxYear.Text;
			if (Thang == "null")
			{
				string sql = "Select N'Năm'+ '" + year + "',SUM(ChiTietHD.SL*DonGia),SUM(ChiTietHD.SL) as SoLuongBan From ((HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD) join HangHoa on HangHoa.MaHH = ChiTietHD.MaHH) join MatHang on MatHang.MaMH = HangHoa.MaMH where  DATEPART(YEAR,CAST(NgayLap as date))=" + year;
				HienThi_Luoi(sql);
			}
			else
			{
				string sql = "Select N'Tháng'+ '" + Thang + "' + N'Năm'+ '" + year + "',SUM(ChiTietHD.SL*DonGia),SUM(ChiTietHD.SL) as SoLuongBan From ((HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD) join HangHoa on HangHoa.MaHH = ChiTietHD.MaHH) join MatHang on MatHang.MaMH = HangHoa.MaMH where DATEPART(MONTH,CAST(NgayLap as date))=" + Thang;
				HienThi_Luoi(sql);
			}
		}	

		private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
		{
				
		}

		private void DoanhThuTheoThoiGian_Load(object sender, EventArgs e)
		{
			string Year = cbxYear.Text;
			string sql = "Select N'Năm' + '"+ Year +"',SUM(ChiTietHD.SL*DonGia),SUM(ChiTietHD.SL) as SoLuongBan From ((HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD) join HangHoa on HangHoa.MaHH = ChiTietHD.MaHH) join MatHang on MatHang.MaMH = HangHoa.MaMH  where  DATEPART(YEAR,CAST(NgayLap as date))=" + Year;
			HienThi_Luoi(sql);
		}

		private void cbxYear_SelectedValueChanged(object sender, EventArgs e)
		{
			string Thang = cbxMonth.Text;
			string Year = cbxYear.Text;
			if (Thang == "null")
			{
				string sql = "Select N'Năm' + '" + Year + "',SUM(ChiTietHD.SL*DonGia),SUM(ChiTietHD.SL) as SoLuongBan From ((HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD) join HangHoa on HangHoa.MaHH = ChiTietHD.MaHH) join MatHang on MatHang.MaMH = HangHoa.MaMH  where  DATEPART(YEAR,CAST(NgayLap as date))=" + Year;
				HienThi_Luoi(sql);

			}
			else
			{
				string sql = "Select N'Tháng'+ '" + Thang + "' + N'Năm'+ '"+ Year + "',SUM(ChiTietHD.SL*DonGia),SUM(ChiTietHD.SL) as SoLuongBan From ((HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD) join HangHoa on HangHoa.MaHH = ChiTietHD.MaHH) join MatHang on MatHang.MaMH = HangHoa.MaMH where DATEPART(MONTH,CAST(NgayLap as date))='" + Thang + "' and  DATEPART(YEAR,CAST(NgayLap as date))=" + Year;
				HienThi_Luoi(sql);
			}
		}
	}
}

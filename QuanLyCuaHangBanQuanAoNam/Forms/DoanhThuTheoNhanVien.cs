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
	public partial class DoanhThuTheoNhanVien : Form
	{
		public DoanhThuTheoNhanVien()
		{
			InitializeComponent();
		}
		private void HienThi_Luoi(string sql)
		{
			DataTable tblKH;
			tblKH = ThucThiSql.DocBang(sql);
			dataGridView1.DataSource = tblKH;
			dataGridView1.Columns[0].HeaderText = "Nhân Viên";
			dataGridView1.Columns[1].HeaderText = "Thời gian";
			dataGridView1.Columns[2].HeaderText = "Doanh Thu";
			dataGridView1.Columns[3].HeaderText = "Số sản phẩm bán";

			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
			tblKH.Dispose();
		}
		private void DoanhThuTheoNhanVien_Load(object sender, EventArgs e)
		{
			string sql = "select MaNV from NhanVien";
			DataTable MaNV;
			MaNV = ThucThiSql.DocBang(sql);
			cbxMaNV.DataSource = MaNV;
			cbxMaNV.DisplayMember = "MaNV";
			cbxMaNV.ValueMember = "MaNV";
		}



		private void cbxMaNV_SelectionChangeCommitted(object sender, EventArgs e)
		{
			string time = "Từ Trước Đến Giờ";
			string sql;
			sql = "select HoTen,N'"+time+"',SUM(ChiTietHD.SL*DonGia),SUM(ChiTietHD.SL) as SoLuongBan From (((HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD) join HangHoa on HangHoa.MaHH = ChiTietHD.MaHH) join MatHang on MatHang.MaMH = HangHoa.MaMH )join NhanVien on NhanVien.MaNV = HoaDon.MaNV where NhanVien.MaNV = '" + cbxMaNV.SelectedValue+ "' group by HoTen ";
			HienThi_Luoi(sql);
			//,'Từ trước đến giờ',SUM(SL * DonGia),SUM(SL) as SoLuongBan From (HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD))joinNhanVien on NhanVien.MaNV = HoaDon.MaNV
		}

		private void cbxMonth_SelectionChangeCommitted(object sender, EventArgs e)
		{
		
		}

		private void cbxYear_SelectionChangeCommitted(object sender, EventArgs e)
		{
			
		}

		private void cbxMaNV_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			string NV = cbxMaNV.Text;
			if (NV is null)
			{
				MessageBox.Show("Bạn phải nhập mã nhân viên trước", "Thông báo");
				cbxMaNV.Focus();
				return;
			}
			else
			{
				string Thang = cbxMonth.Text;
				string year = cbxYear.Text;
				if (Thang == "null")
				{
					string sql = "Select HoTen, N'Năm' + '" + year + "',SUM(ChiTietHD.SL*DonGia),SUM(ChiTietHD.SL) as SoLuongBan From (((HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD) join HangHoa on HangHoa.MaHH = ChiTietHD.MaHH) join MatHang on MatHang.MaMH = HangHoa.MaMH )join NhanVien on NhanVien.MaNV = HoaDon.MaNV where  DATEPART(YEAR,CAST(NgayLap as date))='" + year + "' group by HoTen";
					HienThi_Luoi(sql);
				}
				else
				{
					string sql = "Select HoTen, N'Tháng' + '" + Thang + "' + N'Năm'+ '" + year + "',SUM(ChiTietHD.SL*DonGia),SUM(ChiTietHD.SL) as SoLuongBan From (((HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD) join HangHoa on HangHoa.MaHH = ChiTietHD.MaHH) join MatHang on MatHang.MaMH = HangHoa.MaMH )join NhanVien on NhanVien.MaNV = HoaDon.MaNV where  DATEPART(MONTH,CAST(NgayLap as date))='" + Thang + "' and  DATEPART(YEAR,CAST(NgayLap as date))='" + year + "' group by HoTen";
					HienThi_Luoi(sql);
				}
			}
		}

		private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			string NV = cbxMaNV.Text;
			if (NV == "null")
			{
				MessageBox.Show("Bạn phải nhập mã nhân viên trước", "Thông báo");
				cbxMaNV.Focus();
				return;
			}
			else
			{
				string Thang = cbxMonth.Text;
				string Year = cbxYear.Text;
				if (Thang == "null")
				{
					string sql = "Select HoTen, N'Năm '+' " + Year + "',SUM(ChiTietHD.SL*DonGia),SUM(ChiTietHD.SL) as SoLuongBan From (((HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD) join HangHoa on HangHoa.MaHH = ChiTietHD.MaHH) join MatHang on MatHang.MaMH = HangHoa.MaMH )join NhanVien on NhanVien.MaNV = HoaDon.MaNV where  DATEPART(YEAR,CAST(NgayLap as date))='" + Year + "' group by HoTen";
					HienThi_Luoi(sql);
				}
				else
				{
					string sql = "Select HoTen, N'Tháng '+' " + Thang + "' +N'Năm '+' " + Year + "',SUM(ChiTietHD.SL*DonGia),SUM(ChiTietHD.SL) as SoLuongBan From (((HoaDon join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD) join HangHoa on HangHoa.MaHH = ChiTietHD.MaHH) join MatHang on MatHang.MaMH = HangHoa.MaMH )join NhanVien on NhanVien.MaNV = HoaDon.MaNV where DATEPART(MONTH,CAST(NgayLap as date))='" + Thang + "' and  DATEPART(YEAR,CAST(NgayLap as date))='" + Year + "' group by HoTen";
					HienThi_Luoi(sql);
				}
			}
		}
	}
}

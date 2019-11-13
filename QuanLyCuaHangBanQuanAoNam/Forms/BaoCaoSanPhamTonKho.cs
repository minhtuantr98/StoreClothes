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
	public partial class BaoCaoSanPhamTonKho : Form
	{
		public BaoCaoSanPhamTonKho()
		{
			InitializeComponent();
		}
		private void HienThi_Luoi(string sql)
		{
	
			DataTable tblKH;
			tblKH = ThucThiSql.DocBang(sql);
			dataGridView1.DataSource = tblKH;
			dataGridView1.Columns[0].HeaderText = "Mã Mặt Hàng";
			dataGridView1.Columns[1].HeaderText = "Tên Mặt Hàng";
			dataGridView1.Columns[3].HeaderText = "Ngày nhập về";
			dataGridView1.Columns[3].HeaderText = "Ngày tồn";
			//dataGridView1.Columns[3].HeaderText = "Số lượng bán";

			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
			tblKH.Dispose();
		}

		private void txtThangTon_MouseEnter(object sender, EventArgs e)
		{
	
			//string sql;
			//sql = "select MatHang.MaMH,TenMH,NgayLap from (PhieuNhap join ChiTietPN on PhieuNhap.MaPN = ChiTietPN.MaPN ) join MatHang on MatHang.MaMH = ChiTietPN.MaMH where DATEPART(YEAR,CAST(GETDATE() AS DATE))- DATEPART(MONTH,CAST(NgayLap as date)) > N'" + txtThangTon.Text+"'  ";
			//HienThi_Luoi(sql);
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
		
			string sql;
			sql = "select MatHang.MaMH,TenMH,NgayLap,DATEDIFF(DAY,CAST(NgayLap AS DATE),CAST(GETDATE() as date)) from (PhieuNhap join ChiTietPN on PhieuNhap.MaPN = ChiTietPN.MaPN ) join MatHang on MatHang.MaMH = ChiTietPN.MaMH where DATEPART(MONTH,CAST(GETDATE() AS DATE))- DATEPART(MONTH,CAST(NgayLap as date)) >= N'" + txtThangTon.Text + "'  ";
			HienThi_Luoi(sql);
		}
	}
}

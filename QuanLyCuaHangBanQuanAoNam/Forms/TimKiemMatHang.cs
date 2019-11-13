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
	public partial class TimKiemMatHang : Form
	{
		public TimKiemMatHang()
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
			dataGridView1.Columns[2].HeaderText = "Màu Sắc";
			dataGridView1.Columns[3].HeaderText = "Kích Cỡ";
			dataGridView1.Columns[4].HeaderText = "Số Lượng Còn Lại";
			dataGridView1.Columns[5].HeaderText = "Đơn Giá";

			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
			tblKH.Dispose();

		}

		private void TimKiemMatHang_Load(object sender, EventArgs e)
		{
			DataTable mh;
			string sql = "Select MaHH from HangHoa";
			mh = ThucThiSql.DocBang(sql);
			cbxMaMH.DataSource = mh;
			cbxMaMH.ValueMember = "MaHH";
			cbxMaMH.DisplayMember = "MaHH";

			sql = "Select MaHH,TenMH,MauSac,KichCo,HangHoa.SLConLai,DonGia from MatHang join HangHoa on MatHang.MaMH = HangHoa.MaMH";
			HienThi_Luoi(sql);
		}

		private void txtTenHang_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (cbxMaMH.SelectedValue is null)
			{
				string sql = "Select MaHH,TenMH,MauSac,KichCo,HangHoa.SLConLai,DonGia from MatHang join HangHoa on MatHang.MaMH = HangHoa.MaMH where TenMH Like N'%" + txtTenHang.Text + "%' ";
				HienThi_Luoi(sql);
			}
			else
			{
				string sql = "Select MaHH,TenMH,MauSac,KichCo,HangHoa.SLConLai,DonGia from MatHang join HangHoa on MatHang.MaMH = HangHoa.MaMH where MaHH=N'" + cbxMaMH.SelectedValue + "' and TenMH Like N'%" + txtTenHang.Text + "%' ";
				HienThi_Luoi(sql);
			}
		}

		private void cbxMaMH_SelectionChangeCommitted(object sender, EventArgs e)
		{
			string sql = "Select MaHH,TenMH,MauSac,KichCo,HangHoa.SLConLai,DonGia from MatHang join HangHoa on MatHang.MaMH = HangHoa.MaMH where MaHH=N'"+cbxMaMH.SelectedValue+"' ";
			HienThi_Luoi(sql);
		}
	}
}

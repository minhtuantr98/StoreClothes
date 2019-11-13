using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHangBanQuanAoNam
{
	public partial class ThemNhaCungCap : Form
	{
		public ThemNhaCungCap()
		{
			InitializeComponent();
		}


		private void btnLuu_Click(object sender, EventArgs e)
		{
			string sql;
			if (txtMa.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Mã Nhà Cung Cấp","Thông báo");
				txtMa.Focus();
				return;
				
			}
			if(txtTen.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Tên Nhà Cung Cấp", "Thông báo");
				txtTen.Focus();
				return;

			}
			if(txtSdt.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền SĐT Nhà Cung Cấp", "Thông báo");
				txtSdt.Focus();
				return;

			}
			sql = "Select MaNCC From NCC where MaNCC = N'" + txtMa.Text.Trim() + "'";
			DataTable tblNCC = ThucThiSql.DocBang(sql);
			if (tblNCC.Rows.Count > 0)
			{
				MessageBox.Show("Mã Nhà Cung Cấp này đã có , bạn phải nhập mã khác", "Thông báo");
				txtMa.Focus();
				txtMa.Text = "";
				return;
			}
			else
			{			
				sql = "Insert into NCC(MaNCC,TenNCC,Sdt) VALUES(N'" + txtMa.Text + "',N'" + txtTen.Text + "',N'" + txtSdt.Text + "')";
				ThucThiSql.CapNhatDuLieu(sql);
				MessageBox.Show("Bạn Thêm Thành Công","Success");
				this.Close();
			}
		}

		private void ThemNhaCungCap_Activated(object sender, EventArgs e)
		{

		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ThemNhaCungCap_Load(object sender, EventArgs e)
		{

		}
	}
}

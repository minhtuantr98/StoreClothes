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
	public partial class UpdateNhaCungCap : Form
	{
		public UpdateNhaCungCap()
		{
			InitializeComponent();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			string sql;
			if (txtTen.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Tên Nhà Cung Cấp", "Thông báo");
				txtMa.Focus();
				return;
			}
			if (txtSdt.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền SĐT Nhà Cung Cấp", "Thông báo");
				txtMa.Focus();
				return;
			}	
				sql = "UPDATE NCC Set TenNCC =N'" + txtTen.Text + "',Sdt = N'" + txtSdt.Text + "' where MaNCC = N'"+txtMa.Text+"'";
				ThucThiSql.CapNhatDuLieu(sql);
				this.Close();	
		}

		private void UpdateNhaCungCap_Load(object sender, EventArgs e)
		{
			txtMa.Enabled = false;
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

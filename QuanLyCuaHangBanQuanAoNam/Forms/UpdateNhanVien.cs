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
	public partial class UpdateNhanVien : Form
	{
		public UpdateNhanVien()
		{
			InitializeComponent();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			string sql;
			if (txtName.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Tên Nhà Nhân Viên", "Thông báo");
				txtName.Focus();
				return;
			}
			if (txtDiaChi.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Địa Chỉ Nhân Viên", "Thông báo");
				txtDiaChi.Focus();
				return;
			}
			if (txtSDT.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền SĐT Nhân Viên", "Thông báo");
				txtSDT.Focus();
				return;
			}
			if (txtGioiTinh.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Giới Tính Nhân Viên", "Thông báo");
				txtGioiTinh.Focus();
				return;
			}
			if (txtCMT.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Địa Chỉ Nhân Viên", "Thông báo");
				txtCMT.Focus();
				return;
			}
			sql = "UPDATE NhanVien Set HoTen =N'" + txtName.Text + "',DiaChi = N'" + txtDiaChi.Text + "',Sdt =N'"+txtSDT.Text+"',GioiTinh=N'"+txtGioiTinh.Text+"',CMND=N'"+txtCMT.Text+"' where MaNV = N'" + txtMa.Text + "'";
			ThucThiSql.CapNhatDuLieu(sql);
			this.Close();
		}

		private void UpdateNhanVien_Load(object sender, EventArgs e)
		{
			txtMa.Enabled = false;
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

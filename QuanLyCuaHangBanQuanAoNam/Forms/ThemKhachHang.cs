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
	public partial class ThemKhachHang : Form
	{
		public ThemKhachHang()
		{
			InitializeComponent();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string sql;
			if (txtMaKH.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Mã Khách Hàng", "Thông báo");
				txtMaKH.Focus();
				return;
			}
			if (txtHoTen.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Tên Khách Hàng", "Thông báo");
				txtHoTen.Focus();
				return;
			}
			if (txtDiaChi.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Mã Khách Hàng", "Thông báo");
				txtDiaChi.Focus();
				return;
			}
			if (txtSDT.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Mã Khách Hàng", "Thông báo");
				txtSDT.Focus();
				return;
			}
			if (txtDiem.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Mã Khách Hàng", "Thông báo");
				txtDiem.Focus();
				return;
			}
			if (date.Value == null)
			{
				MessageBox.Show("Bạn Chưa Điền Ngày Sinh Khách Hàng", "Thông báo");
				date.Focus();
				return;
			}
			sql = "Select MaKH From KhachHang where MaKH = N'" + txtMaKH.Text.Trim() + "'";
			DataTable tblKH = ThucThiSql.DocBang(sql);
			if (tblKH.Rows.Count > 0)
			{
				MessageBox.Show("Mã Khách Hàng này đã có , bạn phải nhập mã khác", "Thông báo");
				txtMaKH.Focus();
				txtMaKH.Text = "";
				return;
			}
			else
			{
				sql = "Insert into KhachHang(MaKH,HoTen,NgaySinh,DiaChi,Sdt,DiemTich) VALUES(N'" + txtMaKH.Text + "',N'" + txtTen.Text + "',N'" + date.Value + "',N'" + txtDiaChi.Text + "',N'" + txtSDT.Text + "',N'" + txtDiem.Text + "')";
				ThucThiSql.CapNhatDuLieu(sql);
				MessageBox.Show("Bạn Thêm Thành Công", "Success");
				this.Close();
			}
		}

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

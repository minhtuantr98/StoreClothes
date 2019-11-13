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
	public partial class ThemNhanVien : Form
	{
		public ThemNhanVien()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string sql;
			if (txtMaNV.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Mã Nhân Viên", "Thông báo");
				txtMaNV.Focus();
				return;

			}
			if (txtTen.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Tên Nhà Nhân Viên", "Thông báo");
				txtTen.Focus();
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
			sql = "Select MaNV From NhanVien where MaNV = N'" + txtMaNV.Text.Trim() + "'";
			DataTable tblNCC = ThucThiSql.DocBang(sql);
			if (tblNCC.Rows.Count > 0)
			{
				MessageBox.Show("Mã Nhân Viên này đã có , bạn phải nhập mã khác", "Thông báo");
				txtMaNV.Focus();
				txtMaNV.Text = "";
				return;
			}
			else
			{
				sql = "Insert into NhanVien(MaNV,HoTen,DiaChi,Sdt,GioiTinh,CMND) VALUES(N'" + txtMaNV.Text + "',N'" + txtTen.Text + "',N'" + txtDiaChi.Text + "',N'" + txtSDT.Text + "',N'" + txtGioiTinh.Text + "',N'" + txtCMT.Text + "')";
				ThucThiSql.CapNhatDuLieu(sql);
				MessageBox.Show("Bạn Thêm Thành Công", "Success");
				this.Close();
			}
		}

		private void ThemNhanVien_Load(object sender, EventArgs e)
		{

		}

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

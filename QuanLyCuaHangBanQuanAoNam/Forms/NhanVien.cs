using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanQuanAoNam.Forms
{
	public partial class NhanVien : Form
	{
		public NhanVien()
		{
			InitializeComponent();
		}
		private void HienThi_Luoi()
		{

			DataTable tblKH;
			string sql = "select * from NhanVien";
			tblKH = ThucThiSql.DocBang(sql);
			dataGridView1.DataSource = tblKH;
			dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
			dataGridView1.Columns[1].HeaderText = "Tên Nhân Viên";
			dataGridView1.Columns[2].HeaderText = "Địa Chỉ";
			dataGridView1.Columns[3].HeaderText = "SĐT";
			dataGridView1.Columns[4].HeaderText = "Giới Tính";
			dataGridView1.Columns[5].HeaderText = "CMND";

			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
			tblKH.Dispose(); 

		}
		private void NhanVien_Load(object sender, EventArgs e)
		{
			HienThi_Luoi();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			ThemNhanVien f = new ThemNhanVien();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo");
				return;
			}
			UpdateNhanVien f = new UpdateNhanVien();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.txtMa.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
			f.txtName.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
			f.txtDiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
			f.txtSDT.Text = dataGridView1.CurrentRow.Cells["Sdt"].Value.ToString();
			f.txtGioiTinh.Text = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
			f.txtCMT.Text = dataGridView1.CurrentRow.Cells["CMND"].Value.ToString();
			f.Show();
			
		}

		private void NhanVien_Activated(object sender, EventArgs e)
		{
			HienThi_Luoi();
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string sql;
			if (dataGridView1.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo");
				return;
			}

			if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				sql = "Delete NhanVien where MaNV =N'" + dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString() + "'";
				ThucThiSql.CapNhatDuLieu(sql);
				HienThi_Luoi();
			}
		}
	}
}

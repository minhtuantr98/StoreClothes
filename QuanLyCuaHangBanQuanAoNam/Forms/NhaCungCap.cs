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
	public partial class NhaCungCap : Form
	{
		public NhaCungCap()
		{
			InitializeComponent();
		}
		private void HienThi_Luoi()
		{

			DataTable tblKH;
			string sql = "select * from NCC";
			tblKH = ThucThiSql.DocBang(sql);
			dataGridView1.DataSource = tblKH;
			dataGridView1.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
			dataGridView1.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
			dataGridView1.Columns[2].HeaderText = "SĐT";


			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
			tblKH.Dispose();

		}
		private void NhaCungCap_Load(object sender, EventArgs e)
		{
			HienThi_Luoi();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			ThemNhaCungCap f = new ThemNhaCungCap();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void NhaCungCap_Activated(object sender, EventArgs e)
		{
			HienThi_Luoi();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if(dataGridView1.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo");
				return;
			}
			UpdateNhaCungCap f = new UpdateNhaCungCap();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.txtMa.Text = dataGridView1.CurrentRow.Cells["MaNCC"].Value.ToString();
			f.txtTen.Text = dataGridView1.CurrentRow.Cells["TenNCC"].Value.ToString();
			f.txtSdt.Text = dataGridView1.CurrentRow.Cells["Sdt"].Value.ToString();
			f.Show();
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

			if(MessageBox.Show("Bạn có muốn xóa không?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
					sql = "Delete NCC where MaNCC =N'" + dataGridView1.CurrentRow.Cells["MaNCC"].Value.ToString() + "'";
					ThucThiSql.CapNhatDuLieu(sql);
					HienThi_Luoi();
			}

		}
	}
}

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
	public partial class ThemChiTietHang : Form
	{
		public ThemChiTietHang()
		{
			InitializeComponent();
		}

		private void ThemChiTietHang_Load(object sender, EventArgs e)
		{
			txtMaMH.Enabled = false;
			txtSL.Enabled = false;
			txtTenMH.Enabled = false;
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string sql;
			if (dataGridView1.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo");
				return;
			}
			// cách 1 bản ghi
			//sql = "insert into MatHang Values('" + dataGridView1.CurrentRow.Cells[0].Value + "',N'" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[2].Value + "','" + dataGridView1.CurrentRow.Cells[3].Value + "','" + dataGridView1.CurrentRow.Cells[4].Value + "')";
			//ThucThiSql.CapNhatDuLieu(sql);
			for (int i = 0; i < dataGridView1.RowCount - 1; i++)
			{
             
				sql = "insert into HangHoa Values('" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "',N'" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "',N'" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + txtMaMH.Text + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "') ";
				ThucThiSql.CapNhatDuLieu(sql);
                
		
			}
			MessageBox.Show("Bạn đã thêm thành công", "Thông Báo");
		}
	}
}

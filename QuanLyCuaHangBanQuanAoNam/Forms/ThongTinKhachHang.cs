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
	public partial class btmTim : Form
	{
		public btmTim()
		{
			InitializeComponent();
		}
		private void HienThi_Luoi(string sql)
		{

			DataTable tblKH;
			tblKH = ThucThiSql.DocBang(sql);
			dataGridView1.DataSource = tblKH;
			dataGridView1.Columns[0].HeaderText = "Mã Khách Hàng";
			dataGridView1.Columns[1].HeaderText = "Tên Khách Hàng";
			dataGridView1.Columns[2].HeaderText = "Ngày Sinh";
			dataGridView1.Columns[3].HeaderText = "Địa Chỉ";
			dataGridView1.Columns[4].HeaderText = "SĐT";
			dataGridView1.Columns[5].HeaderText = "Điểm Tích";

			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
			tblKH.Dispose();

		}
		private void ThongTinKhachHang_Load(object sender, EventArgs e)
		{
			string sql = "Select * from KhachHang";
			HienThi_Luoi(sql);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string sdt = txtSDT.Text;
			string sql = "select * from KhachHang where SDT Like N'%" + sdt + "%' ";
			HienThi_Luoi(sql);
		}
	}
}

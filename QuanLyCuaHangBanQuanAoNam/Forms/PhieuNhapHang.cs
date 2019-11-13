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
	public partial class PhieuNhapHang : Form
	{
		public PhieuNhapHang()
		{
			InitializeComponent();
		}

		private void PhieuNhapHang_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'shopThoiTrang2DataSet10.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter2.Fill(this.shopThoiTrang2DataSet10.NCC);
            // TODO: This line of code loads data into the 'shopThoiTrang2DataSet3.NCC' table. You can move, or remove it, as needed.

            string date = DateTime.Now.ToString("yyyy/M/dd ");
			txtNgayNhap.Text = date;
			// TODO: This line of code loads data into the 'shopThoiTrang2DataSet2.NCC' table. You can move, or remove it, as needed.
			
			// TODO: This line of code loads data into the 'shopThoiTrang2DataSet1.MatHang' table. You can move, or remove it, as needed.
			//this.matHangTableAdapter.Fill(this.shopThoiTrang2DataSet1.MatHang);
			string sql = "select MaNV from NhanVien";
			DataTable MaNV;
			MaNV = ThucThiSql.DocBang(sql);
			cbxMaNV.DataSource = MaNV;
			cbxMaNV.DisplayMember = "HoTen";
			cbxMaNV.ValueMember = "MaNV";

		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
            bool re;
            String lenh = "select * from PhieuNhap where MaPN ='" + txtMaPhieu.Text + "'";
            re = XuLy.Login(lenh);

            if (cbxMaNV.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Mã Nhân Viên", "Thông báo");
				cbxMaNV.Focus();
				return;
			}
			if (txtMaPhieu.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Mã Phiếu", "Thông báo");
				txtMaPhieu.Focus();
				return;
			}
            if (re)
            {
                MessageBox.Show("Bạn đã nhập trùng mã phiếu nhập ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;

            }
            string sql = "insert into PhieuNhap Values(N'" + txtMaPhieu.Text + "',N'" + txtNgayNhap.Text + "',N'" + cbxMaNV.Text + "')";
			ThucThiSql.CapNhatDuLieu(sql);
			// cách 1 bản ghi
			//sql = "insert into MatHang Values('" + dataGridView1.CurrentRow.Cells[0].Value + "',N'" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[2].Value + "','" + dataGridView1.CurrentRow.Cells[3].Value + "','" + dataGridView1.CurrentRow.Cells[4].Value + "')";
			//ThucThiSql.CapNhatDuLieu(sql);
			for (int i = 0; i < dataGridView1.RowCount -1; i++)
			{
              //  sql = "insert into MatHang Values('" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "',N'" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "') ";

                bool re1;
                String lenh1 = "select * from MatHang where MaMH ='" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'";
                re1 = XuLy.Login(lenh1);
                if (re1)
                {
                    MessageBox.Show("Bạn đã nhập trùng mã mặt hàng, tại hàng thứ "+ (i+1), "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtMaPhieu.Focus();
                    return;
                }
                 sql = "insert into MatHang Values('" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "',N'" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "') ";


                ThucThiSql.CapNhatDuLieu(sql);
				int tien = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
				int sl = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
				int tong = tien * sl;
				dataGridView1.Rows[i].Cells[5].Value = tong;
				sql = "insert into ChiTietPN Values(N'" + txtMaPhieu.Text + "','" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "')";
				ThucThiSql.CapNhatDuLieu(sql);
			}
			MessageBox.Show("Bạn đã thêm thành công", "Thông Báo");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo");
				return;
			}
			else if (dataGridView1.CurrentRow.Cells[0].Value is null)
			{
				MessageBox.Show("Trỏ đúng đến mặt hàng cần nhập!", "Thông báo");
                return;
			} 
			ThemChiTietHang f = new ThemChiTietHang();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.txtMaMH.Text = dataGridView1.CurrentRow.Cells["MaMH"].Value.ToString();
			f.txtTenMH.Text = dataGridView1.CurrentRow.Cells["TenMH"].Value.ToString();
			f.txtSL.Text = dataGridView1.CurrentRow.Cells["SL"].Value.ToString();
			f.Show();
		}

		private void cbxMaNV_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
		{
			int tien = 0;
			int sl = 0;
			int tong = 0;

			for (int i = 0; i < dataGridView1.RowCount - 1; i++)
			{


				tien += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
				sl += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
				tong += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString()) * Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());

			}
			txtSL.Text = sl.ToString();
			txtTien.Text = tong.ToString();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            InPhieuNhapHang f = new InPhieuNhapHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.txtMaPhieu.Text = txtMaPhieu.Text;
            f.txtMaNV.Text = cbxMaNV.Text;
            f.txtNgayNhap.Text = txtNgayNhap.Text;
            f.txtTien.Text = txtTien.Text;
            f.txtMaNV.Enabled = false;
            f.txtMaPhieu.Enabled = false;
            f.txtNgayNhap.Enabled = false;
            f.txtTien.Enabled = false;
            f.Show();
        }
    }
}

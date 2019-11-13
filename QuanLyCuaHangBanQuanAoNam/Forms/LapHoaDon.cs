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
	public partial class LapHoaDon : Form
	{
		public LapHoaDon()
		{
			InitializeComponent();
		}

		private void btnThemKH_Click(object sender, EventArgs e)
		{
			ThemKhachHang f = new ThemKhachHang();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void LapHoaDon_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'shopThoiTrang2DataSet9.HangHoa' table. You can move, or remove it, as needed.
			


			string date = DateTime.Now.ToString("yyyy/M/dd ");
			txtNgayNhap.Text = date;
			txtUudai.Text = "0";
			string sql = "select * from NhanVien";
			DataTable MaNV;
			MaNV = ThucThiSql.DocBang(sql);
			cbxMaNV.DataSource = MaNV;
			cbxMaNV.DisplayMember = "HoTen";
			cbxMaNV.ValueMember = "MaNV";
			
		}

	

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string sql;

            bool re;
            String lenh = "select * from HoaDon where MaHD ='" + txtMaPhieu.Text + "'";
            re = XuLy.Login(lenh);

            if (txtMaPhieu.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Mã Hóa Đơn", "Thông báo");
				cbxMaNV.Focus();
				return;
			}
			if (txtKhach.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền SDT Khách", "Thông báo");
				txtKhach.Focus();
				return;
			}
			if (cbxMaNV.Text.Trim().Length == 0)
			{
				MessageBox.Show("Bạn Chưa Điền Mã Nhân Viên", "Thông báo");
				cbxMaNV.Focus();
				return;
			}

            if (re)
            {
                MessageBox.Show("Bạn đã nhập trùng mã hóa đơn ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;

            }

            sql = "Select MaKH from KhachHang where SDT =N'" + txtKhach.Text + "' ";
			DataTable kh = ThucThiSql.DocBang(sql);
			string txt = kh.Rows[0][0].ToString();
			int total = Convert.ToInt32(txtTong.Text);
            sql = "Select DiemTich from KhachHang where MaKH =N'" + txt + "'";
            DataTable diem2 = ThucThiSql.DocBang(sql);
            int diem3 = Convert.ToInt32(diem2.Rows[0][0].ToString());
            if(diem3 == 8 )
            {
                MessageBox.Show("Lần sau bạn sẽ được khuyến mãi?", "Thông Báo");
            }
            if (total >= 500000)
			{
				sql = "Update KhachHang Set DiemTich=DiemTich+'" + 1 + "' where MaKH =N'" + txt + "'";
				ThucThiSql.CapNhatDuLieu(sql);
				sql = "Select DiemTich from KhachHang where MaKH =N'" + txt + "'";
				DataTable diem = ThucThiSql.DocBang(sql);
				int diem1 = Convert.ToInt32(diem.Rows[0][0].ToString());
				if (diem1 == 10)
				{
					if (MessageBox.Show("Bạn có muốn dùng ưu đãi thẻ không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						int tong = Convert.ToInt32(txtTong.Text);
						tong = (tong / 100) * 80;
						txtTong.Text = Convert.ToString(tong);
						txtUudai.Text = "20";
						int tongtien = Convert.ToInt32(txtTong.Text);
						tongtien = (tongtien / 100) * 80;
						txtTong.Text = Convert.ToString(tong);
                        sql = "update KhachHang set DiemTich = '"+0+"'where Sdt = '"+txtKhach.Text+"' ";
					}
				}
			}
			sql = "insert into HoaDon Values(N'" + txtMaPhieu.Text + "',N'" + txtNgayNhap.Text + "',N'" + txtUudai.Text + "',N'" + cbxMaNV.SelectedValue + "',N'" + txt + "')";
			ThucThiSql.CapNhatDuLieu(sql);
		
			for (int i = 0; i < dataGridView1.RowCount - 1; i++)
			{
				if(dataGridView1.CurrentCell.Value is null)
				{
					MessageBox.Show("Ban vui long chon len ");
					return;
				}
                sql = "Select SLConLai From HangHoa where MaHH ='" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'";
                DataTable sl1 = ThucThiSql.DocBang(sql);

                int a = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());
                int b = Convert.ToInt32(sl1.Rows[0][0].ToString());
                if (a > b)
                {
                    MessageBox.Show("Số lượng còn lại không đủ");
                    return;
                }

                int tien = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
				int sl = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());
				int tong = tien * sl;
				dataGridView1.Rows[i].Cells[6].Value = tong;
				sql = "insert into ChiTietHD Values(N'" + txtMaPhieu.Text + "','" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[6].Value.ToString() + "')";
				ThucThiSql.CapNhatDuLieu(sql);

				sql = "Update HangHoa Set SLConLai=SLConLai-'" + dataGridView1.Rows[i].Cells[5].Value + "' where MaHH =N'" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'";
				ThucThiSql.CapNhatDuLieu(sql);
				sql = "Select MaMH from HangHoa where MaHH ='" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'";
				DataTable mh = ThucThiSql.DocBang(sql);
				string mh1 = mh.Rows[0][0].ToString();
				sql = "Update MatHang Set SLConLai = (Select Sum(SLConLai) from HangHoa where MaMH=N'" + mh1 + "')";
			}
			MessageBox.Show("Lập Thành công");
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}



		private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (dataGridView1.CurrentRow.Cells[0].Value is null)
			{
				return;
			}
			else
			{
				string sql;
				sql = "Select TenMH,KichCo,MauSac,DonGia From MatHang join HangHoa on MatHang.MaMH = HangHoa.MaMH where MaHH=N'" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
				DataTable hd = ThucThiSql.DocBang(sql);
				dataGridView1.CurrentRow.Cells[1].Value = hd.Rows[0][0].ToString();
				dataGridView1.CurrentRow.Cells[2].Value = hd.Rows[0][1].ToString();
				dataGridView1.CurrentRow.Cells[3].Value = hd.Rows[0][2].ToString();
				dataGridView1.CurrentRow.Cells[4].Value = Convert.ToInt32(hd.Rows[0][3]);
			}
		}

		private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void txtTong_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtTong_Click(object sender, EventArgs e)
		{
			int tien = 0;
			int sl = 0;
			int tong = 0;

			for (int i = 0; i < dataGridView1.RowCount - 1; i++)
			{


				tien += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
				sl += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());
				tong += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString()) * Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());

			}
			txtTong.Text = tong.ToString();
		}

        private void btnIn_Click(object sender, EventArgs e)
        {
            Forms.InHoaDon f = new Forms.InHoaDon();
            f.txtMaPhieu.Text = txtMaPhieu.Text;
            f.txtNgayNhap.Text = txtNgayNhap.Text;
            f.txtNguoiLap.Text = cbxMaNV.Text;
            f.txtKhach.Text = txtKhach.Text;
            f.txtUudai.Text = txtUudai.Text;
            f.txtTien.Text = txtTong.Text;
            f.txtKhach.Enabled = false;
            f.txtMaPhieu.Enabled = false;
            f.txtNgayNhap.Enabled = false;
            f.txtNguoiLap.Enabled = false;
            f.txtTien.Enabled = false;
            f.txtUudai.Enabled = false;
     
            f.Show();
        }
    }
}

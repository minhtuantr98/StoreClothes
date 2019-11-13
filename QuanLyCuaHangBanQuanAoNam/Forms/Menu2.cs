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
	public partial class Menu2 : Form
	{
		public Menu2()
		{
			InitializeComponent();
		}

		private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
		{
		
			NhaCungCap f = new NhaCungCap();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Forms.NhanVien f = new Forms.NhanVien(); 
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Forms.btmTim f = new Forms.btmTim();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void doanhSốTheoThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DoanhThuTheoThoiGian f = new DoanhThuTheoThoiGian();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void doanhSốTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DoanhThuTheoNhanVien f = new DoanhThuTheoNhanVien();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LapHoaDon f = new LapHoaDon();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void thốngKêMặtHàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BaoCaoSanPhamTonKho f = new BaoCaoSanPhamTonKho();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PhieuNhapHang f = new PhieuNhapHang();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

		private void tìmKiếmMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TimKiemMatHang f = new TimKiemMatHang();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Show();
		}

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private String doiNgay(String name)
        {
            String ngay = "";
            switch(name)
            {
                case "Monday":
                    ngay = "Thứ hai";
                    break;
                case "Tuesday":
                    ngay = "Thứ ba";
                    break;
                case "Wednesday":
                    ngay = "Thứ tư";
                    break;
                case "Thursday":
                    ngay = "Thứ năm";
                    break;
                case "Friday":
                    ngay = "Thứ sáu";
                    break;
                case "Saturday":
                    ngay = "Thứ bảy";
                    break;
                default:
                    ngay = "Chủ nhật";
                    break;
            }
            return ngay;
        }

        private void Menu2_Load(object sender, EventArgs e)
        {
            labelNgay.Text = doiNgay(DateTime.Now.DayOfWeek.ToString()) + ", " +
                DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" +
                DateTime.Now.Year.ToString();
     
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.Hour.ToString() + " : " +
                DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }

        private void thốngKêLươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeLuongNhanVien f = new ThongKeLuongNhanVien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}

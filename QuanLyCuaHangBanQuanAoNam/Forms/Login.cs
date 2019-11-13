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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			String tk = txtID.Text;
			String mk = txtPass.Text;
			bool re;
            String lenh = "select * from NHANVIEN where MaNV = '" + tk + "' AND Sdt = '" + mk + "' and Quyen='member'";
            re = XuLy.Login(lenh);


			if (re)
			{
                
				Menu2 f = new Menu2();
                f.Show();
                f.nhânViênToolStripMenuItem.Enabled = false;
                f.báoCáoThốngKêToolStripMenuItem.Enabled = false;
                
                //close
                Visible = false;
			}
            else
            {
                String lenh1 = "select * from NHANVIEN where MaNV = '" + tk + "' AND Sdt = '" + mk + "' and Quyen='admin'";
                re = XuLy.Login(lenh1);
                if (re)
                {
                    Menu2 f = new Menu2();
                    f.Show();
                    //close
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    txtID.Focus();
                }
            }
		}

		

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}

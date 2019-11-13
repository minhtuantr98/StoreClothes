using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCuaHangBanQuanAoNam
{
	class XuLy
	{
		public static SqlConnection conn;
		public static SqlCommand cmd;
		public static DataTable dt;
		public static SqlDataAdapter da;
		//public static string lenh = "Data Source=TRANBAOKHANH;Initial Catalog=QLSHIPPER;Integrated Security=True";
		public static string lenh = @"Data Source=DESKTOP-NPP6EVA\SQLEXPRESS;Initial Catalog=ShopThoiTrang2;Integrated Security=True";
		public static DataTable TaoBang(String sql)
		{
			conn = new SqlConnection(lenh);
			conn.Open();
			da = new SqlDataAdapter(sql, conn);
			dt = new DataTable();
			da.Fill(dt);
			conn.Close();
			return dt;
		}

		public static int ExecuteNonQuery(String sql)
		{
			int re = 0;
			try
			{
				conn = new SqlConnection(lenh);
				conn.Open();
				cmd = new SqlCommand(sql, conn);
				re = cmd.ExecuteNonQuery();
				conn.Close();
			}
			catch (Exception ex)
			{

			}
			return re;
		}

		public static bool Login(String sql)
		{
			bool re = false;
			try
			{
				conn = new SqlConnection(lenh);
				conn.Open();
				SqlCommand cmd = new SqlCommand(sql, conn);
				SqlDataReader dta = cmd.ExecuteReader();
				if (dta.Read() == true)
				{
					re = true;
				}
				conn.Close();
			}
			catch
			{

			}
			return re;
		}
	}
}

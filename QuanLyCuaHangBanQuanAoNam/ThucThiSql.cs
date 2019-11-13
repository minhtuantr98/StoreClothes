using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangBanQuanAoNam
{
	class ThucThiSql
	{
		public static SqlConnection conn;
		public static string connString = @"Data Source=DESKTOP-NPP6EVA\SQLEXPRESS;Initial Catalog=ShopThoiTrang2;Integrated Security=True";
		
		public static void KetNoiCSDL()
		{
			conn = new SqlConnection();
			conn.ConnectionString = connString;
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
		}
		public static void DongKetNoiCSDL()
		{
			if(conn.State != ConnectionState.Closed)
			{
				conn.Close();
				conn.Dispose();
				conn = null;
			}
		}
		public static void CapNhatDuLieu(string sql)
		{
			KetNoiCSDL();
			SqlCommand sqlcommand = new SqlCommand();
			sqlcommand.Connection = conn;
			sqlcommand.CommandText = sql;
			sqlcommand.ExecuteNonQuery();
			DongKetNoiCSDL();
		}
		public static DataTable DocBang(String sql)
		{
			DataTable dt = new DataTable();
			SqlDataAdapter Mydata = new SqlDataAdapter();
			Mydata.SelectCommand = new SqlCommand();
			KetNoiCSDL();
			Mydata.SelectCommand.Connection = conn;
			Mydata.SelectCommand.CommandText = sql;
			Mydata.Fill(dt);
			DongKetNoiCSDL();
			return dt;
		}
	}
}

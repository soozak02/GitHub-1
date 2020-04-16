using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
	class ADBEngine
	{
		private static Lazy<ADBEngine> _lazy = new Lazy<ADBEngine>(() => new ADBEngine());
		public static ADBEngine Instance { get { return _lazy.Value; } }
		private SQLiteConnection conn;
		public ADBEngine()
		{

		}
		public void Init()
		{
			try
			{
				conn = new SQLiteConnection(@"Data Source=data.db");

				fc_ConOpen();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public bool fc_ConOpen()
		{
			try
			{
				if (conn.State != ConnectionState.Open)
					conn.Open();
			}
			catch (Exception ex)
			{
				Console.WriteLine("<ADBEngine> - fc_ConOpen " + ex.Message);
				return false;
			}

			if (conn.State != ConnectionState.Open)
			{
				Console.WriteLine("<ADBEngine> - fc_ConOpen " + "디비접속안됨");
				return false;
			}
			else
				return true;
		}
		public void Dispose()
		{
			if (conn != null)
			{
				if (ConnectionState.Closed != conn.State)
					conn.Close();
				conn.Dispose();
				conn = null;
			}
		}
		public DataTable fc_SqlDataAdapterQuery(string sQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				SQLiteDataAdapter adt = new SQLiteDataAdapter(sQuery, conn);
				adt.Fill(dt);
			}
			catch (Exception ex)
			{
				Console.WriteLine("<ADBEngine> - fc_SqlDataAdapterQuery " + sQuery + " - " + ex.Message);
			}

			return dt;
		}

		public int ExecuteNoneQuery(string sQuery)
		{
			int nRtn = -1;
			SQLiteCommand cmd = new SQLiteCommand(sQuery, conn)
			{
				CommandType = CommandType.Text
			};
			try
			{
				nRtn = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("<ADBEngine> - ExecuteNoneQuery" + sQuery + " - " + ex.Message);
				throw;
			}
			finally
			{
				cmd.Dispose();
			}

			return nRtn;
		}
	}
}

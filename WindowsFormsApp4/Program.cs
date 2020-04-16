using AxKHOpenAPILib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Entity.info;

namespace WindowsFormsApp4
{
	static class Program
	{
		public static AxKHOpenAPI API;
		public static List<stockInfo> stockList = new List<stockInfo>();
		/// <summary>
		/// 해당 애플리케이션의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ADBEngine.Instance.Init();
			ADBEngine.Instance.fc_ConOpen();
			Application.Run(new Form1());
		}
	}
}

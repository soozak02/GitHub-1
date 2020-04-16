using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Entity.info
{
	public class stockInfo
	{
		public string stockCode { get; set; }
		public string stockName { get; set; }

		public stockInfo(string code, string name)
		{
			this.stockCode = code;
			this.stockName = name;
		}
	}
}

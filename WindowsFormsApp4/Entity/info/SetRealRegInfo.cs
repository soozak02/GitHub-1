using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Entity.info;

namespace WindowsFormsApp4.Entity.info
{
	public class SetRealRegInfo
	{
		public stockInfo stock { get; set; } = null;
		public string strFidList { get; set; } = "9001;10;15;20";

		public SetRealRegInfo(stockInfo code)
		{
			stock = code;
		}
		public SetRealRegInfo(stockInfo code, string FidList)
		{
			stock = code;
			strFidList = FidList;
		}
	}
}

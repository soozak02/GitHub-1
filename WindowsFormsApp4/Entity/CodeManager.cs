using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Entity.info;

namespace WindowsFormsApp4.Entity
{
	public class CodeManager
	{
		private static Lazy<CodeManager> _lazy = new Lazy<CodeManager>(() => new CodeManager());
		public static CodeManager Instance { get { return _lazy.Value; } }

		private List<stockInfo> stockList = new List<stockInfo>();
		public CodeManager()
		{
			string stockCode = Program.API.GetCodeListByMarket(null);
			string[] stockCodeArray = stockCode.Split(';');
			for (int i = 0; i < stockCodeArray.Length; i++)
			{
				stockList.Add(new stockInfo(stockCodeArray[i], Program.API.GetMasterCodeName(stockCodeArray[i])));
			}
		}
		public List<stockInfo> All()
		{		
			return stockList;
		}
		
		public List<string> AllName()
		{
			List<string> r = new List<string>();
			foreach(stockInfo s in stockList)
			{
				r.Add(s.stockName);
			}
			return r;
		}

		public stockInfo GetNameFromInfo(string stockName)
		{
			int index = stockList.FindIndex(o => o.stockName == stockName);
			
			return stockList[index];
		}
		public stockInfo GetCodeFromInfo(string stockCode)
		{
			int index = stockList.FindIndex(o => o.stockCode == stockCode);

			return stockList[index];
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Entity.info;

namespace WindowsFormsApp4.Entity
{
	public class strMonitorManager
	{
		public string MonitorNumber = "0000";
		private List<SetRealRegInfo> setRealRegInfos = new List<SetRealRegInfo>(200);

		public strMonitorManager(string _MonitorNumber)
		{
			MonitorNumber = _MonitorNumber;
		}

		/// <summary>
		/// 해당 모니터의 등록된 종목을 가지고온다.
		/// </summary>
		public int Count()
		{
			return setRealRegInfos.Count();
		}
		public List<stockInfo> GetStockCodeList()
		{
			List<stockInfo> StockCodeList = new List<stockInfo>();

			for (int i = 0; i < setRealRegInfos.Count; i++)
			{
				StockCodeList.Add(setRealRegInfos[i].stock);
			}

			return StockCodeList;
		}
		public void Add(stockInfo stock, string optType, string strFidList = null)
		{
			SetRealRegInfo setRealReg;
			if (String.IsNullOrEmpty(strFidList))
			{
				setRealReg = new SetRealRegInfo(stock);
			}
			else
			{
				setRealReg = new SetRealRegInfo(stock, strFidList);
			}

			setRealRegInfos.Add(setRealReg);
			Program.API.SetRealReg(MonitorNumber, setRealReg.stock.stockCode, setRealReg.strFidList, optType);
		}
		public void Add(List<stockInfo> stock, string optType, string strFidList = null)
		{
			string aaa = String.Join(";", stock.AsEnumerable().Select(x => x.stockCode));

			SetRealRegInfo setRealReg;
			for(int i=0; i<stock.Count; i++)
			{
				if (String.IsNullOrEmpty(strFidList))
				{
					setRealReg = new SetRealRegInfo(stock[i]);
				}
				else
				{
					setRealReg = new SetRealRegInfo(stock[i], strFidList);
				}
				setRealRegInfos.Add(setRealReg);
			}
			
			Program.API.SetRealReg(MonitorNumber, aaa, setRealRegInfos[0].strFidList, optType);
		}

		public int Delete(string Code)
		{
			int iRet = setRealRegInfos.FindIndex(x => x.stock.stockCode == Code);
			if (iRet < 0)
			{
				return 1;
			}
			setRealRegInfos.RemoveAt(iRet);
			Program.API.SetRealRemove(MonitorNumber, Code);
			return 0;
		}
		public void AllDelete()
		{
			setRealRegInfos.Clear();
		}
	}
}

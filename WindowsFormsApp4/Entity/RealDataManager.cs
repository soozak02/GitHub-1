using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp4.Entity.info;

namespace WindowsFormsApp4.Entity
{
	public class RealDataManager
	{
		private const int MonitorMaxCount = 1000;			//임의 최대 모니터 갯수 값
		private static Lazy<RealDataManager> _lazy = new Lazy<RealDataManager>(() => new RealDataManager());
		public static RealDataManager Instance { get { return _lazy.Value; } }

		private List<stockInfo> _stocks = new List<stockInfo>();

		private string sRealType = "0";
		private List<strMonitorManager> setRealRegs = new List<strMonitorManager>(MonitorMaxCount);

		public RealDataManager()
		{
			for (int i = 0; i < MonitorMaxCount; i++)
			{
				setRealRegs.Add(new strMonitorManager((i + 1).ToString("D4")));
			}
		}

		public ResultInfo Add(string Name)
		{
			ResultInfo result = new ResultInfo
			{
				Code = 0,
				Msg = "더 이상 등록 될 수 없습니다."
			};

			int i = 0;
			bool bRegiCheck = false;
			int Monitor = 0;
			int FirstCheck = 0;
			for (i = 0; i < setRealRegs.Count; i++)
			{
				int cnt = setRealRegs[i].Count();
				if (bRegiCheck == false && cnt <= 200)
				{
					Monitor = i;
					bRegiCheck = true;
				}
				if (cnt == 0)
				{
					FirstCheck++;
				}
			}

			if (i == MonitorMaxCount-1 && bRegiCheck == false)             // 모니터갯수 20개 모두 200개의 종목 꽉 찼을 때
			{
				return result;
			}

			if (FirstCheck != MonitorMaxCount-1)
			{
				sRealType = "1";
			}

			stockInfo stock = CodeManager.Instance.GetNameFromInfo(Name);

			setRealRegs[Monitor].Add(stock, sRealType);

			string sMonitor = (Monitor + 1).ToString("D4");
			result.Code = 1;
			result.Msg = sMonitor + "에 등록 되었습니다.";

			return result;
		}

		public void Delete(string Name)
		{
			stockInfo stock = CodeManager.Instance.GetNameFromInfo(Name);

			for (int i = 0; i < setRealRegs.Count; i++)
			{
				if (setRealRegs[i].Delete(stock.stockCode) == 0)
				{
					break;
				}
			}
			int FirstCheck = 0;

			for (int i = 0; i < setRealRegs.Count; i++)
			{
				if (setRealRegs[i].Count() == 0)
				{
					FirstCheck++;
				}
			}

			if (FirstCheck != MonitorMaxCount - 1)
			{
				sRealType = "0";
			}
		}

		public void AddAll()
		{
			this.DelAll();
			List<stockInfo> stock = CodeManager.Instance.All();

			int count = stock.Count / 100;
			int count_a = stock.Count % 100;
			if (count_a > 0)
			{
				count++;
			}
			int FirstCheck = 0;
			for (int i = 0; i < setRealRegs.Count; i++)
			{
				int cnt = setRealRegs[i].Count();
				if (cnt == 0)
				{
					FirstCheck++;
				}
			}

			if (FirstCheck != MonitorMaxCount - 1)
			{
				sRealType = "1";
			}
			int j = 0;
			bool 모니터데이터증가 = false;
			for (int i = 0; i < count; i++)
			{
				if (200 - setRealRegs[j].Count() == 100)        // 등록가능 갯수가 100개 남아있다면 다음 모니터에 등록할 준비를 한다.
				{
					모니터데이터증가 = true;
				}
				List<stockInfo> a = stock.AsEnumerable().Skip(100 * i).Take(100).ToList();

				setRealRegs[j].Add(a, sRealType);

				if (모니터데이터증가 == true)
				{
					j++;
				}
			}
		}
		public void DelAll()
		{
			Program.API.SetRealRemove("ALL", "ALL");
			sRealType = "0";

			for (int i = 0; i < setRealRegs.Count; i++)
			{
				setRealRegs[i].AllDelete();
			}
		}

		public List<stockInfo> GetAddList()
		{
			List<stockInfo> stockInfos = new List<stockInfo>();

			for (int i = 0; i < setRealRegs.Count; i++)
			{
				List<stockInfo> getstockInfos = setRealRegs[i].GetStockCodeList();
				stockInfos.AddRange(getstockInfos);
			}

			return stockInfos;
		}
	}
}

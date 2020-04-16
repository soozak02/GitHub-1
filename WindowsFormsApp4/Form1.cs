using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp4.Entity;
using WindowsFormsApp4.Entity.info;

namespace WindowsFormsApp4
{
	public delegate void DataGridSelect1(string[] item);
	public delegate void DataGridSelect2(string[] item);
	public partial class Form1 : Form
	{
		private readonly string sDateTime = DateTime.Now.ToString("yyyyMMdd");
		private string SelectName = null;
		DataGridSelect1 ds1;
		DataGridSelect2 ds2;
		public Form1()
		{
			InitializeComponent();
			Program.API = axKHOpenAPI1;
			axKHOpenAPI1.OnReceiveRealData += onReceiveRealData;
			//axKHOpenAPI1.SetInputValue("종목코드", "094800");
			//axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000");

			base.SetVisibleCore(true);
			Program.API.CommConnect();
			Program.API.OnEventConnect += onEventConnect;
			// dataGridView1.DataSource = ADBEngine.Instance.fc_SqlDataAdapterQuery("select *from LiveTable");

			ContextMenuStrip mnu = new ContextMenuStrip();
			ToolStripMenuItem mnuDelete = new ToolStripMenuItem("삭제");
			ToolStripMenuItem mnuLiveData = new ToolStripMenuItem("실시간데이터보기");
			ToolStripMenuItem mnuLiveDataCancel = new ToolStripMenuItem("실시간데이터취소하기");
			mnuDelete.Click += new EventHandler(mnuDelete_Click);
			mnuLiveData.Click += new EventHandler(mnuLiveData_Click);
			mnuLiveDataCancel.Click += new EventHandler(mnuLiveDataCancel_Click);
			mnu.Items.AddRange(new ToolStripItem[] { mnuDelete, mnuLiveData, mnuLiveDataCancel });
			dataGridView2.ContextMenuStrip = mnu;

			ds1 = SelecteDataGrid1;
			ds2 = SelecteDataGrid2;
		}

		public void onEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
		{
			CodeList.DataSource = CodeManager.Instance.AllName();
		}
		public void onReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
		{
			if (e.sRealType == "주식체결")
			{
				#region FID
				//[20] = 체결시간
				//[10] = 현재가
				//[11] = 전일대비
				//[12] = 등락율
				//[27] = (최우선) 매도호가
				//[28] = (최우선)매수호가
				//[15] = 거래량
				//[13] = 누적거래량
				//[14] = 누적거래대금
				//[16] = 시가
				//[17] = 고가
				//[18] = 저가
				//[25] = 전일대비기호
				//[26] = 전일거래량대비(계약, 주)
				//[29] = 거래대금증감
				//[30] = 전일거래량대비(비율)
				//[31] = 거래회전율
				//[32] = 거래비용
				//[228] = 체결강도
				//[311] = 시가총액(억)
				//[290] = 장구분
				//[691] = KO접근도
				//[567] = 상한가발생시간
				//[568] = 하한가발생시간
				#endregion

				stockInfo stock = CodeManager.Instance.GetCodeFromInfo(e.sRealKey);
				DateTime stockTime = DateTime.ParseExact(axKHOpenAPI1.GetCommRealData(e.sRealKey, 20), "HHmmss", System.Globalization.CultureInfo.InvariantCulture);         // 체결시간   	
				long stockPrice = long.Parse(axKHOpenAPI1.GetCommRealData(e.sRealKey, 10));             // 현재가
				long volume = long.Parse(axKHOpenAPI1.GetCommRealData(e.sRealKey, 15));                  // 거래량
				StringBuilder sb = new StringBuilder();
				//sb.AppendFormat("{0} ", stockTime.ToString("HH:mm:ss"));
				//sb.AppendFormat("현재가 : {0}, ", String.Format("{0:#,###}", stockPrice));
				//sb.AppendFormat("거래량 : {0}, ", String.Format("{0:#,###}", volume));
				//Console.WriteLine(sb.ToString());
				try
				{
					sb.Clear();
					sb.Append("select * from LiveTable where ");
					sb.AppendFormat("SignTime = '{0}' ", stockTime.ToString("HH:mm:ss"));
					sb.AppendFormat("and SignCode = '{0}' ", e.sRealKey);
					sb.AppendFormat("and SignCodeName = '{0}' ", stock.stockName);

					DataTable dt = ADBEngine.Instance.fc_SqlDataAdapterQuery(sb.ToString());
					int Cnt = 0;
					if (dt != null)
					{
						Cnt = dt.Rows.Count;
						if (Cnt >= 2)            // 2개 이상은 저장안함
							return;
					}

					sb.Clear();
					sb.Append("insert into LiveTable  ");
					sb.Append("(SignTime, SignCode, SignCodeName, SignPrice, SignPriceValue, SignPriceIdx,SignDate) VALUES(");
					sb.AppendFormat("'{0}', ", stockTime.ToString("HH:mm:ss"));
					sb.AppendFormat("'{0}', ", e.sRealKey);
					sb.AppendFormat("'{0}', ", stock.stockName);
					sb.AppendFormat("'{0}', ", String.Format("{0:#,###}", stockPrice));
					sb.AppendFormat("'{0}', ", String.Format("{0:#,###}", volume));
					sb.AppendFormat("{0}, ", Cnt);
					sb.AppendFormat("'{0}') ", sDateTime);

					ADBEngine.Instance.ExecuteNoneQuery(sb.ToString());
					List<string> Data = new List<string>();
					string[] row = new string[] { stockTime.ToString("HH:mm:ss") , e.sRealKey, stock.stockName, String.Format("{0:#,###}", stockPrice), String.Format("{0:#,###}", volume) };
					
					ds1(row);
					if (String.IsNullOrEmpty(SelectName))
					{
						return;
					}
					if (SelectName != stock.stockName)
						return;
					row = new string[] { stockTime.ToString("HH:mm:ss"), e.sRealKey, stock.stockName, String.Format("{0:#,###}", stockPrice), String.Format("{0:#,###}", volume) };
					
					ds2(row);
				}
				catch (Exception ex)
				{
					Console.WriteLine("DB 관련 에러 남");
				}
			}
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			ResultInfo result = RealDataManager.Instance.Add(tB_Search.Text);
			MessageBox.Show(result.Msg);

			if (result.Code == 0)
			{
				return;
			}
			var source = new BindingSource();
			source.DataSource = RealDataManager.Instance.GetAddList();
			dataGridView2.DataSource = source;
		}

		private void CodeList_SelectedIndexChanged(object sender, EventArgs e)
		{
			tB_Search.Text = ((ListBox)sender).SelectedItem as string;
		}

		private void AddAll_Click(object sender, EventArgs e)
		{
			RealDataManager.Instance.AddAll();
			var source = new BindingSource();
			source.DataSource = RealDataManager.Instance.GetAddList();
			dataGridView2.DataSource = source;
		}

		private void DeleteAll_Click(object sender, EventArgs e)
		{
			RealDataManager.Instance.DelAll();
			var source = new BindingSource();
			source.DataSource = RealDataManager.Instance.GetAddList();
			dataGridView2.DataSource = source;
		}


		private void mnuDelete_Click(object sender, EventArgs e)
		{
			DataGridViewRow aa = this.dataGridView2.CurrentRow;
			string name = aa.Cells[1].Value as string;
			if (String.IsNullOrEmpty(name))
			{
				return;
			}

			if (SelectName == name)
			{
				SelectName = null;
				lb_SelectName.Text = "현재 선택된 종목 : " + SelectName;
			}

			RealDataManager.Instance.Delete(name);
			var source = new BindingSource();
			source.DataSource = RealDataManager.Instance.GetAddList();
			dataGridView2.DataSource = source;
		}

		private void mnuLiveData_Click(object sender, EventArgs e)
		{
			DataGridViewRow aa = this.dataGridView2.CurrentRow;
			string name = aa.Cells[1].Value as string;

			SelectName = name;
			lb_SelectName.Text = "현재 선택된 종목 : " + SelectName;
		}

		private void mnuLiveDataCancel_Click(object sender, EventArgs e)
		{
			DataGridViewRow aa = this.dataGridView2.CurrentRow;
			string name = aa.Cells[1].Value as string;

			if (name != SelectName)
			{
				MessageBox.Show("현재 지정된 종목이 아닙니다.");
				return;
			}

			SelectName = null;
			lb_SelectName.Text = "현재 선택된 종목 : " + SelectName;
		}

		private void SelecteDataGrid1(string[] item)
		{
			this.Invoke(new EventHandler(delegate
			{
				dataGridView1.Rows.Add(item);
				dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
				Application.DoEvents();
			}));
		}
		private void SelecteDataGrid2(string[] item)
		{
			this.BeginInvoke(new EventHandler(delegate
			{
				dataGridView3.Rows.Add(item);
				dataGridView3.FirstDisplayedScrollingRowIndex = dataGridView3.Rows.Count - 1;
				Application.DoEvents();
			}));
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			ADBEngine.Instance.Dispose();
		}
	}
}

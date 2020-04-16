namespace WindowsFormsApp4
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
			this.StrategyGenerategroupBox = new System.Windows.Forms.GroupBox();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lb_SelectName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Searching = new System.Windows.Forms.Button();
			this.tB_Search = new System.Windows.Forms.TextBox();
			this.DeleteAll = new System.Windows.Forms.Button();
			this.AddAll = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.CodeList = new System.Windows.Forms.ListBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
			this.StrategyGenerategroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// axKHOpenAPI1
			// 
			this.axKHOpenAPI1.Enabled = true;
			this.axKHOpenAPI1.Location = new System.Drawing.Point(1897, 949);
			this.axKHOpenAPI1.Name = "axKHOpenAPI1";
			this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
			this.axKHOpenAPI1.Size = new System.Drawing.Size(58, 19);
			this.axKHOpenAPI1.TabIndex = 0;
			// 
			// StrategyGenerategroupBox
			// 
			this.StrategyGenerategroupBox.Controls.Add(this.dataGridView3);
			this.StrategyGenerategroupBox.Controls.Add(this.lb_SelectName);
			this.StrategyGenerategroupBox.Controls.Add(this.label3);
			this.StrategyGenerategroupBox.Controls.Add(this.label2);
			this.StrategyGenerategroupBox.Controls.Add(this.label1);
			this.StrategyGenerategroupBox.Controls.Add(this.dataGridView2);
			this.StrategyGenerategroupBox.Controls.Add(this.dataGridView1);
			this.StrategyGenerategroupBox.Controls.Add(this.Searching);
			this.StrategyGenerategroupBox.Controls.Add(this.tB_Search);
			this.StrategyGenerategroupBox.Controls.Add(this.DeleteAll);
			this.StrategyGenerategroupBox.Controls.Add(this.AddAll);
			this.StrategyGenerategroupBox.Controls.Add(this.btn_add);
			this.StrategyGenerategroupBox.Controls.Add(this.CodeList);
			this.StrategyGenerategroupBox.Location = new System.Drawing.Point(12, 12);
			this.StrategyGenerategroupBox.Name = "StrategyGenerategroupBox";
			this.StrategyGenerategroupBox.Size = new System.Drawing.Size(1283, 612);
			this.StrategyGenerategroupBox.TabIndex = 2;
			this.StrategyGenerategroupBox.TabStop = false;
			this.StrategyGenerategroupBox.Text = "전략생성";
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.dataGridView3.Location = new System.Drawing.Point(559, 392);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.RowTemplate.Height = 23;
			this.dataGridView3.Size = new System.Drawing.Size(711, 211);
			this.dataGridView3.TabIndex = 11;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "데이터도착시각";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 200;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "종목코드";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "종목이름";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "거래가";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "거래량";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// lb_SelectName
			// 
			this.lb_SelectName.AutoSize = true;
			this.lb_SelectName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_SelectName.Location = new System.Drawing.Point(728, 368);
			this.lb_SelectName.Name = "lb_SelectName";
			this.lb_SelectName.Size = new System.Drawing.Size(121, 12);
			this.lb_SelectName.TabIndex = 10;
			this.lb_SelectName.Text = "현재 선택된 종목 : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(559, 368);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "선택된 종목 데이터";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(557, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "실시간 데이터";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(307, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "추가 종목 리스트";
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dataGridView2.Location = new System.Drawing.Point(307, 47);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 23;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(246, 556);
			this.dataGridView2.TabIndex = 8;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "stockCode";
			this.Column1.HeaderText = "종목코드";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "stockName";
			this.Column2.HeaderText = "종목이름";
			this.Column2.Name = "Column2";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			this.dataGridView1.Location = new System.Drawing.Point(559, 47);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(711, 295);
			this.dataGridView1.TabIndex = 8;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "데이터도착시각";
			this.Column3.Name = "Column3";
			this.Column3.Width = 200;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "종목코드";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "종목이름";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "거래가";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "거래량";
			this.Column7.Name = "Column7";
			// 
			// Searching
			// 
			this.Searching.Location = new System.Drawing.Point(226, 20);
			this.Searching.Name = "Searching";
			this.Searching.Size = new System.Drawing.Size(74, 21);
			this.Searching.TabIndex = 7;
			this.Searching.Text = "Searching";
			this.Searching.UseVisualStyleBackColor = true;
			// 
			// tB_Search
			// 
			this.tB_Search.Location = new System.Drawing.Point(6, 20);
			this.tB_Search.Name = "tB_Search";
			this.tB_Search.Size = new System.Drawing.Size(213, 21);
			this.tB_Search.TabIndex = 4;
			// 
			// DeleteAll
			// 
			this.DeleteAll.Location = new System.Drawing.Point(227, 529);
			this.DeleteAll.Name = "DeleteAll";
			this.DeleteAll.Size = new System.Drawing.Size(75, 72);
			this.DeleteAll.TabIndex = 1;
			this.DeleteAll.Text = "All Delete";
			this.DeleteAll.UseVisualStyleBackColor = true;
			this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
			// 
			// AddAll
			// 
			this.AddAll.Location = new System.Drawing.Point(226, 451);
			this.AddAll.Name = "AddAll";
			this.AddAll.Size = new System.Drawing.Size(75, 72);
			this.AddAll.TabIndex = 1;
			this.AddAll.Text = "All ADD";
			this.AddAll.UseVisualStyleBackColor = true;
			this.AddAll.Click += new System.EventHandler(this.AddAll_Click);
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(225, 47);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(75, 72);
			this.btn_add.TabIndex = 1;
			this.btn_add.Text = "Add";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// CodeList
			// 
			this.CodeList.BackColor = System.Drawing.SystemColors.Window;
			this.CodeList.FormattingEnabled = true;
			this.CodeList.ItemHeight = 12;
			this.CodeList.Location = new System.Drawing.Point(6, 47);
			this.CodeList.Name = "CodeList";
			this.CodeList.Size = new System.Drawing.Size(213, 556);
			this.CodeList.TabIndex = 0;
			this.CodeList.SelectedIndexChanged += new System.EventHandler(this.CodeList_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1310, 630);
			this.Controls.Add(this.StrategyGenerategroupBox);
			this.Controls.Add(this.axKHOpenAPI1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
			this.StrategyGenerategroupBox.ResumeLayout(false);
			this.StrategyGenerategroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
		private System.Windows.Forms.GroupBox StrategyGenerategroupBox;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.ListBox CodeList;
		private System.Windows.Forms.TextBox tB_Search;
		private System.Windows.Forms.Button Searching;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button DeleteAll;
		private System.Windows.Forms.Button AddAll;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lb_SelectName;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
	}
}


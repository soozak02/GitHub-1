using System;
using AxKHOpenAPILib;

namespace WindowsFormsApp4.Core
{
	public class API
	{
		private static Lazy<API> _lazy = new Lazy<API>(() => new API());
		public static API Instance { get { return _lazy.Value; } }

		public AxKHOpenAPI Kium;
		public API()
		{
			Kium = new AxKHOpenAPI();
			((System.ComponentModel.ISupportInitialize)(this.Kium)).BeginInit();
		}
	}
}

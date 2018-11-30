using SubmailCore.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmailCore.Lib
{
	public class InternationalSmsXSend : SendBase
	{
		public const string TO = "to";
		public const string PROJECT = "project";
		public const string VARS = "vars";

		public InternationalSmsXSend(IAppConfig appConfig) : base(appConfig)
		{
		}

		protected override ISender GetSender()
		{
			return new InternationalSms(_appConfig);
		}

		public void AddTo(string address)
		{
			this.AddWithComma(TO, address);
		}

		public void SetProject(string project)
		{
			this._dataPair.Add(PROJECT, project);
		}

		public void AddVar(string key, string val)
		{
			this.AddWithJson(VARS, key, val);
		}

		public string XSend(out string returnMessage)
		{
			return this.GetSender().XSend(_dataPair, out returnMessage);
		}
	}
}
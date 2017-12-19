using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
	public class InternationalSmsSend : SendBase
	{
		public const string TO = "to";
		public const string CONTENT = "content";

		public InternationalSmsSend(IAppConfig appConfig) : base(appConfig)
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

		public void AddContent(string content)
		{
			this.AddWithComma(CONTENT, content);
		}



		public string Send(out string returnMessage)
		{
			return this.GetSender().Send(_dataPair, out returnMessage);
		}
	}
}

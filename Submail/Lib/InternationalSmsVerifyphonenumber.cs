using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
	public class InternationalSmsVerifyphonenumber : SendBase
	{
		public const string TO = "to";


		public InternationalSmsVerifyphonenumber(IAppConfig appConfig) : base(appConfig)
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


		public string verify(out string returnMessage)
		{
			return this.GetSender().Post(_dataPair, out returnMessage);
		}
	}
}

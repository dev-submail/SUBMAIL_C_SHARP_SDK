using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	public class InternationalSmsBalanceDemo
	{
		public void balance()
		{
			IAppConfig appConfig = new InternationalSmsConfig("appid", "appkey", SignType.normal);
			InternationalSmsBalance submail = new InternationalSmsBalance(appConfig);
			string returnMessage = string.Empty;
			submail.Balance(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();

		}
	}
}


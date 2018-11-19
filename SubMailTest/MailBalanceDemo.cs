using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	public class MailBalanceDemo
	{
		public void balance()
		{
			IAppConfig appConfig = new MailAppConfig("appid", "appkey", SignType.sha1);
			MailBalance submail = new MailBalance(appConfig);
			string returnMessage = string.Empty;
			submail.Balance(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();

		}
	}
}



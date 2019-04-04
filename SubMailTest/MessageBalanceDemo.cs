using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	public class MessageBalanceDemo
	{
		public void balance()
		{
			IAppConfig appConfig = new MessageConfig("appid", "appkey", SignType.sha1);
			MessageBalance messageBalance= new MessageBalance(appConfig);
			string returnMessage = string.Empty;
			messageBalance.Balance(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();

		}
	}
}



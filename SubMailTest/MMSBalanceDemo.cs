using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	public class MMSBalanceDemo
	{
		public void balance()
		{
			IAppConfig appConfig = new MMSConfig("appid", "appkey", SignType.sha1);
			MMSBalance mmsBalance = new MMSBalance(appConfig);
			string returnMessage = string.Empty;
			mmsBalance.Balance(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();

		}
	}
}



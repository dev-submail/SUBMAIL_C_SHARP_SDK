using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	public class VoiceBalanceDemo
	{
		public void balance()
		{
			IAppConfig appConfig = new VoiceAppConfig("appid", "appkey", SignType.sha1);
			VoiceBalance submail = new VoiceBalance(appConfig);
			string returnMessage = string.Empty;
			submail.Balance(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();

		}
	}
}



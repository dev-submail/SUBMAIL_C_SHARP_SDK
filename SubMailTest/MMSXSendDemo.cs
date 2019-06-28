using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	public class MMSXSendDemo
	{
		public void XSendSms()
		{
			IAppConfig appConfig = new MMSConfig("apppid", "appkey", SignType.normal);
			MMSXSend smsXSend = new MMSXSend(appConfig);
			smsXSend.AddTo("14xxx375616");
			smsXSend.SetProject("w3nla3");
			smsXSend.AddVar("code", "1111333");
			smsXSend.AddVar("minue", "2");
			string returnMessage = string.Empty;
			smsXSend.XSend(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();

		}
	}
}


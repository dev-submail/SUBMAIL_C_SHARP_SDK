using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	public class InternationalSmsXSendDemo
	{
		public void XSendSms()
		{
			IAppConfig appConfig = new InternationalSmsConfig("apppid", "appkey", SignType.normal);
			InternationalSmsXSend smsXSend = new InternationalSmsXSend(appConfig);
			smsXSend.AddTo("+14375375616");
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


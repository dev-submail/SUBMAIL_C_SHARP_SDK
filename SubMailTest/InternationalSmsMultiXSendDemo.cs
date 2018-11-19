using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	public class InternationalSmsMultiXSendDemo
	{
		public void SendMultiSms()
		{
			IAppConfig appConfig = new InternationalSmsConfig("apppid", "appkey", SignType.normal);
			InternationalSmsMultiXSend smsMultiXSend = new InternationalSmsMultiXSend(appConfig);
			smsMultiXSend.SetProject("w3nla3");

			Dictionary<string, string> vars = new Dictionary<string, string>();
			vars.Add("code", "11122233");
			vars.Add("minue", "18");
			smsMultiXSend.SetMulti(new List<MultiMessageItem>() {
				new MultiMessageItem() { to="+14375375616",vars=vars},
				new MultiMessageItem() { to="+17828203943", vars = vars}
			});

			string returnMessage = string.Empty;
			smsMultiXSend.MultiXSend(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();
		}
	}
}

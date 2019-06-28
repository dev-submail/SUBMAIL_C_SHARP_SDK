using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	public class MMSMultiXSendDemo
	{
		public void SendMultiSms()
		{
			IAppConfig appConfig = new MMSConfig("apppid", "appkey", SignType.normal);
			MMSMultiXSend smsMultiXSend = new MMSMultiXSend(appConfig);
			smsMultiXSend.SetProject("wxxxa3");

			Dictionary<string, string> vars = new Dictionary<string, string>();
			vars.Add("code", "11122233");
			vars.Add("minue", "18");
			smsMultiXSend.SetMulti(new List<MultiMessageItem>() {
				new MultiMessageItem() { to="1437xxxx616",vars=vars},
				new MultiMessageItem() { to="1782xxxx943", vars = vars}
			});

			string returnMessage = string.Empty;
			smsMultiXSend.MultiXSend(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();
		}
	}
}

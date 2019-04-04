using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	public class MessageMultiSendDemo
	{
		public void SendMultiMessage()
		{
			IAppConfig appConfig = new MessageConfig("appid", "appkey", SignType.sha1);
			MessageMultiSend messageMultiSend = new MessageMultiSend(appConfig);
			messageMultiSend.SetContent("【SUBMAIL】您的验证码是1234");
			messageMultiSend.AddTag("we235");
			Dictionary<string, string> vars1 = new Dictionary<string, string>();
			vars1.Add("code", "33344");
			vars1.Add("time", "20");

			Dictionary<string, string> vars2 = new Dictionary<string, string>();
			vars2.Add("code", "555");
			vars2.Add("time", "18");

			messageMultiSend.SetMulti(new List<MultiMessageItem>() {
				new MultiMessageItem() { to="1760xxxx149",vars=vars1},
				new MultiMessageItem() { to="1822xxxx949", vars = vars1}
			});

			string returnMessage = string.Empty;
			messageMultiSend.MultiSend(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();

		}
	}
}



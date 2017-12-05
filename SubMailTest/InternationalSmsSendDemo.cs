using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	class InternationalSmsSendDemo
	{
		public void SendSms()
		{
			IAppConfig appConfig = new InternationalSmsConfig("apppid", "appkey", SignType.normal);
			InternationalSmsSend internationalSmsSend = new InternationalSmsSend(appConfig);
			internationalSmsSend.AddTo("+14375375616");
			internationalSmsSend.AddContent("【SUBMAIL】你好，你的验证码是：38385");
			string returnMessage = string.Empty;
			internationalSmsSend.Send(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();
		}
	}
}











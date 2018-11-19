using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
	class InternationalSmsVerifyphonenumberDemo
	{
		public void verify()
		{
			IAppConfig appConfig = new InternationalSmsConfig("appid", "appkey", SignType.normal);
			InternationalSmsVerifyphonenumber submail = new InternationalSmsVerifyphonenumber(appConfig);
			submail.AddTo("+85264522656");
			string returnMessage = string.Empty;
			submail.verify(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();
		}
	}
}

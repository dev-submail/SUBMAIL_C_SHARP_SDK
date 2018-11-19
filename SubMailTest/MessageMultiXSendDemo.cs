using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class MessageMultiXSendDemo
    {
        public void SendMultiMessage()
        {
			IAppConfig appConfig = new MessageConfig("appid", "appkey", SignType.sha1);
            MessageMultiXSend messageMultiSend = new MessageMultiXSend(appConfig);
            messageMultiSend.SetProject("w3nla3");
			messageMultiSend.AddTag("we235");
            Dictionary<string, string> vars1 = new Dictionary<string, string>();
			vars1.Add("code", "33344");
            vars1.Add("minue","18");
            messageMultiSend.SetMulti(new List<MultiMessageItem>() {
                new MultiMessageItem() { to="176xxxx5149",vars=vars1},
                new MultiMessageItem() { to="133xxxx5482", vars = vars1}
            });

            string returnMessage = string.Empty;
			messageMultiSend.MultiXSend(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();
              
            }
    }
}

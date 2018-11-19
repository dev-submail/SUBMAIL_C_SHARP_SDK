using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class VoiceMultiXSendDemo
    {
        public void SendMultiMessage()
        {
            IAppConfig appConfig = new VoiceAppConfig("apppid", "appkey");
            VoiceMultiXSend voiceMultiXSend = new VoiceMultiXSend(appConfig);
            voiceMultiXSend.SetProject("WZlIv3");

            Dictionary<string, string> vars = new Dictionary<string, string>();
            vars.Add("place", "上海");
            vars.Add("name", "xx");

            Dictionary<string, string> vars2 = new Dictionary<string, string>();
            vars2.Add("place", "北京");
            vars2.Add("name", "xx");

            voiceMultiXSend.SetMulti(new List<MultiMessageItem>() {
                new MultiMessageItem() { to="176xxxx5149", vars = vars},
                new MultiMessageItem() { to="133xxxx55482", vars = vars2},
            });

			string returnMessage = string.Empty;
			voiceMultiXSend.MultiXSend(out returnMessage);
            Console.WriteLine(returnMessage);
            Console.ReadKey();
         
        }
    }
}

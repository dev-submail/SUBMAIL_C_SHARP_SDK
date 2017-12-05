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
            vars.Add("name", "张杨");

            Dictionary<string, string> vars2 = new Dictionary<string, string>();
            vars2.Add("place", "北京");
            vars2.Add("name", "老江");

            voiceMultiXSend.SetMulti(new List<MultiMessageItem>() {
                new MultiMessageItem() { to="176025149", vars = vars},
                new MultiMessageItem() { to="13355482", vars = vars2},
            });

			string returnMessage = string.Empty;
			voiceMultiXSend.MultiXSend(out returnMessage);
            Console.WriteLine(returnMessage);
            Console.ReadKey();
         
        }
    }
}

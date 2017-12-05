using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class VoiceXSendDemo
    {
        public void XSendVoice()
        {
            IAppConfig appConfig = new VoiceAppConfig("apppid", "appkey");
            VoiceXSend voiceXSend = new VoiceXSend(appConfig);
            voiceXSend.AddTo("176115149");
            voiceXSend.SetProject("WZlIv3");
            voiceXSend.AddVar("name", "张杨");
            voiceXSend.AddVar("place", "江湖大道");
			string returnMessage = string.Empty;
			voiceXSend.XSend(out returnMessage);
            Console.WriteLine(returnMessage);
            Console.ReadKey();
           
        }
    }
}

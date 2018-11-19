using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    class VoiceSendDemo
    {
        public void SendVoice()
        {
            IAppConfig appConfig = new VoiceAppConfig("appid", "appkey");
            VoiceSend voiceSend = new VoiceSend(appConfig);
            voiceSend.AddTo("1760xxx149");
			voiceSend.AddContent("欢迎来到江苏，welcome to jiangsu");
			string returnMessage = string.Empty;
			voiceSend.Send(out returnMessage);
            Console.WriteLine(returnMessage);
			Console.ReadKey();
        }
    }
}

using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    class VoiceVerifyDemo
    {
        public void SendVoiceVerify()
        {
            IAppConfig appConfig = new VoiceAppConfig("apppid", "appkey");
            VoiceVerify voiceVerify = new VoiceVerify(appConfig);
            voiceVerify.AddTo("176015149");
            voiceVerify.SetCode("38381438");
			string returnMessage = string.Empty;
			voiceVerify.Verify(out returnMessage);
            Console.WriteLine(returnMessage);
			Console.ReadKey();
        }
    }
}

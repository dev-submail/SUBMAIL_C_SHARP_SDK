using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    class MessageSendDemo
    {
        public void SendMessage()
        {
			IAppConfig appConfig = new MessageConfig("appid", "appkey",SignType.md5);
            MessageSend messageSend = new MessageSend(appConfig);
            messageSend.AddTo("17602115149");
            messageSend.AddContent("【SUBMAIL】你好，你的验证码是：11112");
			messageSend.AddTag("111111112");
			string returnMessage = string.Empty;
			messageSend.Send(out returnMessage);
			Console.WriteLine(returnMessage);
			Console.ReadKey();
        }
    }
}

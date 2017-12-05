using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class MessageSendXDemo
    {
        public void XSendMessage()
        {
			IAppConfig appConfig = new MessageConfig("apppid", "appkey",SignType.normal);
            MessageXSend messageXSend = new MessageXSend(appConfig);
            messageXSend.AddTo("17602115149");
			messageXSend.AddTag("11123");
            messageXSend.SetProject("w3nla3");
            messageXSend.AddVar("code", "19999");
            messageXSend.AddVar("minue", "33");
		
            string returnMessage = string.Empty;
			messageXSend.XSend(out returnMessage);
            Console.WriteLine(returnMessage);
			Console.ReadKey();
        }
    }
}

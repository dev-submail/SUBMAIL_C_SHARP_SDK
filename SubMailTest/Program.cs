using Submail;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    class Program
    {
        static void Main(string[] args)
        {
			//AddressBookMailDemo bookMail = new AddressBookMailDemo();
			//bookMail.Subscribe();

			 //MailSendDemo mailSendDemo = new MailSendDemo();
			 //mailSendDemo.SendMail();

			//MessageLogDemo messageLogDemo = new MessageLogDemo();
			//messageLogDemo.messageLog();

			//MessageSendDemo messageSendDemo = new MessageSendDemo();
			//messageSendDemo.SendMessage();

			//MessageSendXDemo messageSendXDemo = new MessageSendXDemo();
			//messageSendXDemo.XSendMessage();

			//MessageMultiXSendDemo messageMultiXSendDemo = new MessageMultiXSendDemo();
			//messageMultiXSendDemo.SendMultiMessage();

			//MessageTemplateDemo mtd = new MessageTemplateDemo();
			//mtd.MessageTemplate();

			VoiceSendDemo voiceSendDemo = new VoiceSendDemo();
			voiceSendDemo.SendVoice();

			//VoiceVerifyDemo voiceVerifyDemo = new VoiceVerifyDemo();
			//voiceVerifyDemo.SendVoiceVerify();

			//VoiceXSendDemo voiceXSendDemo = new VoiceXSendDemo();
			//voiceXSendDemo.XSendVoice();

			//VoiceMultiXSendDemo voiceMultiXSendDemo = new VoiceMultiXSendDemo();
			//voiceMultiXSendDemo.SendMultiMessage();

			//InternationalSmsSendDemo internationalSmsSendDemo = new InternationalSmsSendDemo();
			//internationalSmsSendDemo.SendSms();


			//InternationalSmsXSendDemo smsXsend = new InternationalSmsXSendDemo();
			//smsXsend.XSendSms();

			//InternationalSmsMultiXSendDemo smsMultiXSendDemo = new InternationalSmsMultiXSendDemo();
			//smsMultiXSendDemo.SendMultiSms();


        }
    }
}

using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class MailSendDemo
    {
        public void SendMail()
        {
            IAppConfig mailConfig = new MailAppConfig("apppid", "appkey",SignType.sha1);
            MailSend submail = new MailSend(mailConfig);
            submail.AddTo("zgl88161104@163.com", "joe");
            submail.AddCc("leo@submail.cn", "leo");
            submail.AddBcc("leo@submail.cn", "leo");
            submail.SetSender("leo@inside.submail.me", "leo");
            submail.SetReply("service@submail.cn");
            submail.SetSubject("发送历史与明细");
            submail.SetText("发送历史与明细");
            //submail.AddAttachment(@"C:\attachment.txt");
			string resultMessage = string.Empty;
			submail.Send(out resultMessage);
            Console.WriteLine(resultMessage);

            
        }
    }
}

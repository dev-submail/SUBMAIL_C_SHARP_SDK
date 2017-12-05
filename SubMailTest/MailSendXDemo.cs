using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class MailSendXDemo
    {
        public void SendMail()
        {
            IAppConfig mailConfig = new MailAppConfig("apppid", "appkey");
            MailXSend submail = new MailXSend(mailConfig);
            submail.AddTo("zgl88161104@163.com", "joe");
            submail.SetSender("leo@inside.submail.me", "leo");
            submail.SetProject("7pfhZ3");
            
            submail.AddHeaders("X-Accept", "zh-cn");
            submail.AddHeaders("X-Mailer", "leo App");
            string resultMessge = string.Empty;
			submail.XSend(out resultMessge);
                Console.WriteLine(resultMessge);
            
        }
    }
}

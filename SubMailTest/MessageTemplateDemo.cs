using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    class MessageTemplateDemo
    {
        public void MessageTemplate()
        {
            
          IAppConfig appConfig = new MessageConfig("apppid", "appkey", SignType.normal);
            MessageTemplate messageTemplate = new MessageTemplate(appConfig);

            //get
            //messageTemplate.AddTemplateId("w3nla3");
            //string returnMessage = string.Empty;
            //returnMessage = messageTemplate.Get(out returnMessage);
            //Console.WriteLine("接口返回消息：" + returnMessage);
            //Console.ReadKey();

            //put
            //messageTemplate.PutTemplateId("9qvwv2");
            //messageTemplate.PutSmsTitle("上海赛邮");
            //messageTemplate.PutSmsContent("你好，你的验证码是：11122233");
            //messageTemplate.PutSmSSignature("【SUBMAIL】");
            //string returnMessage = string.Empty;
            //returnMessage = messageTemplate.Put(out returnMessage);
            //Console.WriteLine("接口返回消息：" + returnMessage);
            //Console.ReadKey();


            //del
            //messageTemplate.delTemplateId("9qvwv2");
            //string returnMessage = string.Empty;
            //returnMessage = messageTemplate.Delete(out returnMessage);
            //Console.WriteLine("接口返回消息：" + returnMessage);
            //Console.ReadKey();

            //post
            messageTemplate.PostSmsTitle("上海赛邮");
            messageTemplate.PostSmsContent("你好，你的验证码是：110114");
            messageTemplate.PostSmSSignature("【SUBMAIL】");
            string returnMessage = string.Empty;
            returnMessage = messageTemplate.Post(out returnMessage);
            Console.WriteLine("接口返回消息：" + returnMessage);
            Console.ReadKey();




        }
    }
}

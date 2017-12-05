using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class MessageTemplate : SendBase
    {
        public const string TEMPLATE_ID = "template_id";
        public const string SMS_TITLE = "sms_title";
        public const string SMS_SIGNTURE = "sms_signature";
        public const string SMS_CONTENT = "sms_content";

        public MessageTemplate(IAppConfig appConfig) : base(appConfig)
        {
        }

    
        //get
        public void AddTemplateId(string template_id)
        {
            this.AddWithComma(TEMPLATE_ID, template_id);
        }

        //put
        public void PutTemplateId(string template_id)
        {
            this.AddWithComma(TEMPLATE_ID, template_id);
        }

        public void PutSmsTitle(string sms_title)
        {
            this.AddWithComma(SMS_TITLE, sms_title);
        }

        public void PutSmSSignature(string sms_signature)
        {
            this.AddWithComma(SMS_SIGNTURE, sms_signature);
        }

        public void PutSmsContent(string sms_content)
        {
            this.AddWithComma(SMS_CONTENT, sms_content);
        }

        //del
        public void delTemplateId(string template_id)
        {
            this.AddWithComma(TEMPLATE_ID, template_id);
        }

        //post
        public void PostSmsTitle(string sms_title)
        {
            this.AddWithComma(SMS_TITLE, sms_title);
        }

        public void PostSmSSignature(string sms_signature)
        {
            this.AddWithComma(SMS_SIGNTURE, sms_signature);
        }

        public void PostSmsContent(string sms_content)
        {
            this.AddWithComma(SMS_CONTENT, sms_content);
        }






        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        //get
        public string  Get(out string returnMessage)
        {
            return this.GetSender().Get(_dataPair, out returnMessage);
        }
        //put
        public string Put(out string returnMessage)
        {
            return this.GetSender().Put(_dataPair, out returnMessage);
        }
        //del
        public string Delete(out string returnMessage)
        {
            return this.GetSender().Delete(_dataPair, out returnMessage);
        }
        //post
        public string Post(out string returnMessage)
        {
            return this.GetSender().Post(_dataPair, out returnMessage);
        }


    }
}

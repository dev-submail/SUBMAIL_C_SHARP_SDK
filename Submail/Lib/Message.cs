using Submail.AppConfig;
using Submail.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Submail.Lib
{
    public class Message : ISender
    {
        private const string API_SEND = "http://api.submail.cn/message/send.json";
        private const string API_XSEND = "http://api.submail.cn/message/xsend.json";
        private const string API_MULTIXSEND = "http://api.submail.cn/message/multixsend.json";
        private const string API_SUBSCRIBE = "http://api.submail.cn/addressbook/message/subscribe.json";
        private const string API_UNSUBSCRIBE = "http://api.submail.cn/addressbook/message/unsubscribe.json";
        private const string API_LOG = "http://api.mysubmail.com/log/message.json";
        private const string API_TEMPLATE = "https://api.mysubmail.com/message/template.json";


        private IAppConfig _appConfig;
        private HttpWebHelper _httpWebHelper;

        public Message(IAppConfig appConfig)
        {
            this._appConfig = appConfig;
            this._httpWebHelper = new HttpWebHelper(_appConfig);
        }

        public string Send(Dictionary<string, object> data, out string returnMessage)
        {
            string retrunJsonResult = _httpWebHelper.HttpPost(API_SEND, data);
            returnMessage = retrunJsonResult;
            return retrunJsonResult;
        }

        public string XSend(Dictionary<string, object> data, out string returnMessage)
        {
            string retrunJsonResult = _httpWebHelper.HttpPost(API_XSEND, data);
            returnMessage = retrunJsonResult;
            return retrunJsonResult;
        }

        public string Subscribe(Dictionary<string, object> data, out string returnMessage)
        {
            string retrunJsonResult = _httpWebHelper.HttpPost(API_SUBSCRIBE, data);
            returnMessage = retrunJsonResult;
            return retrunJsonResult;
        }

        public string UnSubscribe(Dictionary<string, object> data, out string returnMessage)
        {
            string retrunJsonResult = _httpWebHelper.HttpPost(API_UNSUBSCRIBE, data);
            returnMessage = retrunJsonResult;
            return retrunJsonResult;
        }

        public string MultiXSend(Dictionary<string, object> data, out string returnMessage)
        {
            string returnJsonResult = _httpWebHelper.HttpPost(API_MULTIXSEND, data);
            returnMessage = returnJsonResult;
            return returnJsonResult;
        }

        public string VoiceVerify(Dictionary<string, object> data, out string returnMessage)
        {
            throw new NotImplementedException();
        }

        public string  Log(Dictionary<string, object> data, out string returnMessage)
        {
            string returnJsonResult = _httpWebHelper.HttpPost(API_LOG, data);
            returnMessage = returnJsonResult;
            return  returnJsonResult;
        }

        public string Get(Dictionary<string, object> data, out string returnMessage)
        {
           
            string returnJsonResult = _httpWebHelper.GetTemplate(API_TEMPLATE, data);
            returnMessage = returnJsonResult;
            return returnJsonResult;
        }

        public string Put(Dictionary<string, object> data, out string returnMessage)
        {
            string returnJsonResult = _httpWebHelper.PutTemplate(API_TEMPLATE, data);
            returnMessage = returnJsonResult;
            return returnJsonResult;
        }

        public string Delete(Dictionary<string, object> data, out string returnMessage)
        {
            string returnJsonResult = _httpWebHelper.DelTemplate(API_TEMPLATE, data);
            returnMessage = returnJsonResult;
            return returnJsonResult;
        }

        public string Post(Dictionary<string, object> data, out string returnMessage)
        {
            string returnJsonResult = _httpWebHelper.HttpPost(API_TEMPLATE, data);
            returnMessage = returnJsonResult;
            return returnJsonResult;
        }
    }
}

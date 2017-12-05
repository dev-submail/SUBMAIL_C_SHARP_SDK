using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class MessageSend : SendBase
    {
        public const string TO = "to";
        public const string CONTENT = "content";
		public const string TAG = "tag";
		public const string OTHER= "other";


        public MessageSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public void AddTo(string address)
        {
            this.AddWithComma(TO, address);
        }

        public void AddContent(string content)
        {
            this.AddWithComma(CONTENT, content);
        }

		 public void AddTag(string val)
		{
			this.AddWithJson(OTHER, TAG, val);
		}


		public string Send(out string returnMessage)
        {
            return this.GetSender().Send(_dataPair, out returnMessage);
        }
    }
}

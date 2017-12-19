using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class VoiceSend : SendBase
    {
        public const string TO = "to";
        public const string CONTENT = "content";

        public VoiceSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Voice(_appConfig);
        }

        public void AddTo(string address)
        {
            this.AddWithComma(TO, address);
        }

        public void AddContent(string content)
        {
            this.AddWithComma(CONTENT, content);
        }



        public string Send(out string returnMessage)
        {
            return this.GetSender().Send(_dataPair, out returnMessage);
        }
    }
}
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class VoiceMultiXSend : SendBase
    {
        public const string PROJECT = "project";
        public const string MULTI = "multi";

        public VoiceMultiXSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Voice(_appConfig);
        }

        public void SetProject(string project)
        {
            this._dataPair.Add(PROJECT, project);
        }

        public void SetMulti(List<MultiMessageItem> multiItems)
        {
            this._dataPair.Add(MULTI, JsonConvert.SerializeObject(multiItems));
        }

        public string MultiXSend(out string returnMessage)
        {
            return this.GetSender().MultiXSend(_dataPair, out returnMessage);
        }
    }

    
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SubmailCore.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmailCore.Lib
{
    public class MessageMultiXSend : SendBase
    {
        public const string PROJECT = "project";
        public const string MULTI = "multi";
		public const string TAG = "tag";
		public const string OTHER = "other";
      
        public MessageMultiXSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public void SetProject(string project)
        {
            this._dataPair.Add(PROJECT, project);
        }

        public void SetMulti(List<MultiMessageItem> multiItems)
        {
            this._dataPair.Add(MULTI, JsonConvert.SerializeObject(multiItems));
        }

		public void AddTag(string val)
		{
			this.AddWithJson(OTHER, TAG, val);
		}

        public string MultiXSend(out string returnMessage)
        {
            return this.GetSender().MultiXSend(_dataPair, out returnMessage);
        }
    }

    public class MultiMessageItem
    {
        public MultiMessageItem()
        {
            vars = new Dictionary<string, string>();
        }

        public string to { get; set; }

        public Dictionary<string, string> vars { get; set; }
    }
}

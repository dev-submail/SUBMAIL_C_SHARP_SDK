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
	public class MessageMultiSend : SendBase
	{
		public const string CONTENT = "content";
		public const string MULTI = "multi";
		public const string TAG = "tag";
		public const string OTHER = "other";

		public MessageMultiSend(IAppConfig appConfig) : base(appConfig)
		{
		}

		protected override ISender GetSender()
		{
			return new Message(_appConfig);
		}

		public void SetContent(string content)
		{
			this._dataPair.Add(CONTENT, content);
		}

		public void SetMulti(List<MultiMessageItem> multiItems)
		{
			this._dataPair.Add(MULTI, JsonConvert.SerializeObject(multiItems));
		}

		public void AddTag(string val)
		{
			this.AddWithJson(OTHER, TAG, val);
		}

		public string MultiSend(out string returnMessage)
		{
			return this.GetSender().MultiSend(_dataPair, out returnMessage);
		}
	}

}

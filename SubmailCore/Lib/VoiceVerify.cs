using SubmailCore.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmailCore.Lib
{
	public class VoiceVerify : SendBase
	{
		public const string TO = "to";
		public const string CODE = "code";

          public VoiceVerify(IAppConfig appConfig) : base(appConfig){
          }

		public void AddTo(string address)
		{
			this._dataPair.Add(TO, address);
		}

		public void SetCode(string code)
		{
			this._dataPair.Add(CODE, code);
		}

		protected override ISender GetSender()
		{
			 return new Voice(_appConfig);
		}

		public string  Verify(out string returnMessage)
		{
			return this.GetSender().VoiceVerify(_dataPair, out returnMessage);
		}
	}
}

using SubmailCore.AppConfig;
using SubmailCore.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubmailCore.Lib
{
	public class Voice : ISender
	{
		private const string API_SEND = "http://api.submail.cn/voice/send.json";
		private const string API_XSEND = "http://api.submail.cn/voice/xsend.json";
		private const string API_MULTIXSEND = "http://api.submail.cn/voice/multixsend.json";
		private const string API_VOICEVERIFY = "http://api.submail.cn/voice/verify.json";
		private const string API_BALANCE = "http://api.mysubmail.com/balance/voice.json";

		private IAppConfig _appConfig;
		private HttpWebHelper _httpWebHelper;

		public Voice(IAppConfig appConfig)
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

		public string MultiXSend(Dictionary<string, object> data, out string returnMessage)
		{
			string returnJsonResult = _httpWebHelper.HttpPost(API_MULTIXSEND, data);
			returnMessage = returnJsonResult;
			return returnJsonResult;
		}

		public string VoiceVerify(Dictionary<string, object> data, out string returnMessage)
		{
			string returnJsonResult = _httpWebHelper.HttpPost(API_VOICEVERIFY, data);
			returnMessage = returnJsonResult;
			return returnJsonResult;
		}

		public string MultiSend(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Balance(Dictionary<string, object> data, out string returnMessage)
		{
			string returnJsonResult = _httpWebHelper.HttpPost(API_BALANCE, data);
			returnMessage = returnJsonResult;
			return returnJsonResult;
		}


		public string Subscribe(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string UnSubscribe(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Log(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Get(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Put(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Delete(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Post(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}
	}
}

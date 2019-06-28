using Submail.AppConfig;
using Submail.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Submail.Lib
{
	public class MMS : ISender
	{
		private const string API_XSEND = "http://api.mysubmail.com/mms/xsend.json";
		private const string API_MULTIXSEND = "https://api.mysubmail.com/mms/multixsend.json";
		private const string API_TEMPLATE = "https://api.mysubmail.com/mms/template.xml";
		private const string API_BALANCE = "http://api.mysubmail.com/balance/mms.json";



		private IAppConfig _appConfig;
		private HttpWebHelper _httpWebHelper;

		public MMS(IAppConfig appConfig)
		{
			this._appConfig = appConfig;
			this._httpWebHelper = new HttpWebHelper(_appConfig);
		}

		public string Send(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
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



		public string Balance(Dictionary<string, object> data, out string returnMessage)
		{
			string returnJsonResult = _httpWebHelper.HttpPost(API_BALANCE, data);
			returnMessage = returnJsonResult;
			return returnJsonResult;
		}

		public string MultiSend(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Subscribe(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string UnSubscribe(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string VoiceVerify(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
		}

		public string Log(Dictionary<string, object> data, out string returnMessage)
		{
			throw new NotImplementedException();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using Submail.AppConfig;
using System.IO;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Submail.Utility
{
    public class HttpWebHelper
    {
        private const string APPID = "appid";
        private const string TIMESTAMP = "timestamp";
        private const string SIGN_TYPE = "sign_type";
        private const string SIGNATURE = "signature";
        private const string API_TIMESTAMP = "http://api.submail.cn/service/timestamp.json";
		private const string OTHER = "other";

        private IAppConfig _appConfig;
        public HttpWebHelper(IAppConfig appConfig)
        {
            this._appConfig = appConfig;
        }

        public string GetTimeStamp()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = httpClient.GetAsync(API_TIMESTAMP).Result)
                {
                    string jsonResult = response.Content.ReadAsStringAsync().Result;
                    Dictionary<string, string> jsonMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonResult);
                    if (jsonMap.ContainsKey(TIMESTAMP))
                    {
                        return jsonMap[TIMESTAMP];
                    }
                }
            }

            return null;
        }


        public string HttpPost(string httpUrl, Dictionary<string, object> dataPair)
        {
			
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("charset", "UTF-8");
                using (MultipartFormDataContent multipart = Build(dataPair))
                {
                    using (HttpResponseMessage response = httpClient.PostAsync(httpUrl, multipart).Result)
                    {
                        return response.Content.ReadAsStringAsync().Result;
                    }
                }
               
            }
        }

        public string GetTemplate(string httpUrl, Dictionary<string, object> dataPair)
        {
            string timeStamp = this.GetTimeStamp();
            dataPair.Add(APPID, _appConfig.AppId);
            dataPair.Add(SIGNATURE, _appConfig.AppKey);
            dataPair.Add(TIMESTAMP, timeStamp);
            dataPair.Add(SIGN_TYPE, "normal");
            string urlGet = httpUrl + "?";
            foreach (string key in dataPair.Keys)
            {
                string value = dataPair[key] as string;
                if (value != null)
                {
                    urlGet += key + "=" + value+ "&";
                    continue;
                }
            }
            urlGet = urlGet.Substring(0, urlGet.Length - 1);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("charset", "UTF-8");
              
                    using (HttpResponseMessage response = httpClient.GetAsync(urlGet).Result)
                    {
                        return response.Content.ReadAsStringAsync().Result;
                    }
              
            }
            }


        public string PutTemplate(string httpUrl, Dictionary<string, object> dataPair)
        {
            List<KeyValuePair<String, String>> paramList = new List<KeyValuePair<String, String>>();
            string timeStamp = this.GetTimeStamp();
            dataPair.Add(APPID, _appConfig.AppId);
            dataPair.Add(SIGNATURE, _appConfig.AppKey);
            dataPair.Add(TIMESTAMP, timeStamp);
            dataPair.Add(SIGN_TYPE, "normal");
            Console.WriteLine(dataPair);
            foreach (string key in dataPair.Keys)
            {
                string value = dataPair[key] as string;
                if (value != null)
                {
                    paramList.Add(new KeyValuePair<string, string>(key, value));
                    continue;
                }
            }
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("charset", "UTF-8");

                using (HttpResponseMessage response = httpClient.PutAsync(httpUrl, new FormUrlEncodedContent(paramList)).Result)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
               
            }
        }


        public string DelTemplate(string httpUrl, Dictionary<string, object> dataPair)
        {
            string timeStamp = this.GetTimeStamp();
            dataPair.Add(APPID, _appConfig.AppId);
            dataPair.Add(SIGNATURE, _appConfig.AppKey);
            dataPair.Add(TIMESTAMP, timeStamp);
            dataPair.Add(SIGN_TYPE, "normal");
            string urlDel ="";
            foreach (string key in dataPair.Keys)
            {
                string value = dataPair[key] as string;
                if (value != null)
                {
                    urlDel += key + "=" + value + "&";
                    continue;
                }
            }
            urlDel = urlDel.Substring(0, urlDel.Length - 1);
            HttpRequestMessage requestMessage = new HttpRequestMessage();
            requestMessage.Method = HttpMethod.Delete;
            requestMessage.RequestUri = new Uri(httpUrl);
            HttpContent httpContent = new StringContent(urlDel);
            requestMessage.Content =httpContent;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("charset", "UTF-8");
                using (HttpResponseMessage response = httpClient.SendAsync(requestMessage).Result)
                {

                    return response.Content.ReadAsStringAsync().Result;
                }
                
            }
        }


        private MultipartFormDataContent Build(Dictionary<string, object> dataPair)
        {
			string timeStamp = this.GetTimeStamp();
			MultipartFormDataContent multipart = new MultipartFormDataContent();
			try
			{
				string json = dataPair[OTHER] as string;
				Dictionary<string, string> jsonMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
				foreach (string key in jsonMap.Keys)
				{
					string value = jsonMap[key] as string;
					if (value != null)
					{
						multipart.Add(new StringContent(value), key);

						continue;
					}
				}
				dataPair.Remove(OTHER);
			}
			catch
			{
				

			}
			dataPair.Add(APPID, _appConfig.AppId);
			dataPair.Add(TIMESTAMP, timeStamp);
			dataPair.Add(SIGN_TYPE, _appConfig.SignType.ToString());
			SignatureHelper sigHelper = new SignatureHelper(_appConfig);
			string formatData = RequestHelper.FormatRequest(dataPair);
			multipart.Add(new StringContent(sigHelper.GetSignature(formatData)), SIGNATURE);

			foreach (string key in dataPair.Keys)
			{
				string value = dataPair[key] as string;
				if (value != null)
				{
					multipart.Add(new StringContent(value), key);
					continue;
				}
				FileInfo file = dataPair[key] as FileInfo;
				if (file != null)
				{
					var fileContent = new ByteArrayContent(System.IO.File.ReadAllBytes(file.FullName));
					fileContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data");
					fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
					{
						FileName = file.Name,
						Name = key,
					};

					multipart.Add(fileContent);
				}
			}

			return multipart;
        }
    }
}

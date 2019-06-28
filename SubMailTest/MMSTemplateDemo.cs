using Newtonsoft.Json;
using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SubMailTest
{
	class MMSTemplateDemo
	{
		public void MMSTemplate()
		{

			IAppConfig appConfig = new MMSConfig("your_appid", "your_appkey", SignType.normal);
			MMSTemplate mms_template = new MMSTemplate(appConfig);

			//get
			//mms_template.SetTemplateId("w3nla3");
			//string returnMessage = string.Empty;
			//returnMessage = mms_template.Get(out returnMessage);
			//Console.WriteLine("接口返回消息：" + returnMessage);
			//Console.ReadKey();

			//put
			//mms_template.PutTemplateId("FC2o43");
			//mms_template.PutMmsTitle("上海赛邮");
			//mms_template.PutMmsSubject("模板提交测试");
			//Dictionary<string, string> jsonMap = new Dictionary<string, string>();
			//jsonMap.Add("data", FileToBase64Str("/Users/submail/Desktop/xiu.png"));
			//jsonMap.Add("type", "image/png");
			//List<TemplateImageItem> image_list = new List<TemplateImageItem>() {
			//	new TemplateImageItem() { image = jsonMap,text = "这是个测试内容"}
			//};
			//mms_template.PutMmsImageContent(image_list);
			//mms_template.PutMmSSignature("【SUBMAIL2】");
			//string returnMessage = string.Empty;
			//returnMessage = mms_template.Put(out returnMessage);
			//Console.WriteLine("接口返回消息：" + returnMessage);
			//Console.ReadKey();


			//del
			//mms_template.delTemplateId("FC2o43");
			//string returnMessage = string.Empty;
			//returnMessage = mms_template.Delete(out returnMessage);
			//Console.WriteLine("接口返回消息：" + returnMessage);
			//Console.ReadKey();

			//post
			mms_template.PostMmsTitle("上海赛邮");
			mms_template.PostMmSSignature("【SUBMAIL】");
			mms_template.PostMmsSubject("模板提交测试");
			Dictionary<string, string> jsonMap = new Dictionary<string, string>();
			         jsonMap.Add("data", FileToBase64Str("/Users/submail/Desktop/tian.png"));
			Console.WriteLine("接口返回消息：" + FileToBase64Str("/Users/submail/Desktop/tian.png"));

			jsonMap.Add("type", "image/png");
			         List<TemplateImageItem> image_list=  new List<TemplateImageItem>() {
				new TemplateImageItem() { image = jsonMap,text = "这是个测试内容"}
			};
			mms_template.PostMmsImageContent(image_list);
			string returnMessage = string.Empty;
			returnMessage = mms_template.Post(out returnMessage);
			Console.WriteLine("接口返回消息：" + returnMessage);
			Console.ReadKey();

		}






		//FileToBase64Str("/Users/submail/Desktop/tian.png")
		public string FileToBase64Str(string filePath)
		{
			string base64Str = string.Empty;
			try
			{
				using (FileStream filestream = new FileStream(filePath, FileMode.Open))
				{
					byte[] bt = new byte[filestream.Length];

					//调用read读取方法
					filestream.Read(bt, 0, bt.Length);
					base64Str = Convert.ToBase64String(bt);
					filestream.Close();
				}

				return base64Str;
			}
			catch (Exception ex)
			{
				return null;
			}
		}




	}
}


//public void SendMultiSms()
//{
//	IAppConfig appConfig = new MMSConfig("apppid", "appkey", SignType.normal);
//	MMSMultiXSend smsMultiXSend = new MMSMultiXSend(appConfig);
//	smsMultiXSend.SetProject("wxxxa3");

//	Dictionary<string, string> vars = new Dictionary<string, string>();
//	vars.Add("code", "11122233");
//	vars.Add("minue", "18");
//	smsMultiXSend.SetMulti(new List<MultiMessageItem>() {
//				new MultiMessageItem() { to="1437xxxx616",vars=vars},
//				new MultiMessageItem() { to="1782xxxx943", vars = vars}
//			});

//	string returnMessage = string.Empty;
//	smsMultiXSend.MultiXSend(out returnMessage);
//	Console.WriteLine(returnMessage);
//	Console.ReadKey();
//}
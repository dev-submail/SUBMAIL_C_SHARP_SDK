using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Submail.Lib
{
	public class MMSTemplate : SendBase
	{
		public const string TEMPLATE_ID = "template_id";
		public const string MMS_TITLE = "mms_title";
		public const string MMS_SIGNTURE = "mms_signature";
		public const string MMS_CONTENT = "mms_content";
		public const string MMS_SUBJECT = "mms_subject";

		public MMSTemplate(IAppConfig appConfig) : base(appConfig)
		{
		}


		//get
		public void SetTemplateId(string template_id)
		{
			this.AddWithComma(TEMPLATE_ID, template_id);
		}

		//put
		public void PutTemplateId(string template_id)
		{
			this.AddWithComma(TEMPLATE_ID, template_id);
		}

		public void PutMmsTitle(string mms_title)
		{
			this.AddWithComma(MMS_TITLE, mms_title);
		}

		public void PutMmSSignature(string mms_signature)
		{
			this.AddWithComma(MMS_SIGNTURE, mms_signature);
		}
		public void PostMmsImageContent(List<TemplateImageItem> mms_item)
		{
			this.AddWithComma(MMS_CONTENT, JsonConvert.SerializeObject(mms_item));
		}

		public void PostMmsAudioContent(List<TemplateAudioItem> mms_item)
		{
			this.AddWithComma(MMS_CONTENT, JsonConvert.SerializeObject(mms_item));
		}


		public void PutMmsSubject(string mms_subject)
		{
			this.AddWithComma(MMS_SUBJECT, mms_subject);
		}

		//del
		public void delTemplateId(string template_id)
		{
			this.AddWithComma(TEMPLATE_ID, template_id);
		}

		//post
		public void PostMmsTitle(string mms_title)
		{
			this.AddWithComma(MMS_TITLE, mms_title);
		}

		public void PostMmSSignature(string mms_signature)
		{
			this.AddWithComma(MMS_SIGNTURE, mms_signature);
		}

		public void PutMmsImageContent(List<TemplateImageItem> mms_item)
		{
			this.AddWithComma(MMS_CONTENT, JsonConvert.SerializeObject(mms_item));
		}

		public void PutMmsAudioContent(List<TemplateAudioItem> mms_item)
		{
			this.AddWithComma(MMS_CONTENT, JsonConvert.SerializeObject(mms_item));
		}


		public void PostMmsSubject(string mms_subject)
		{
			this.AddWithComma(MMS_SUBJECT, mms_subject);
		}





		protected override ISender GetSender()
		{
			return new MMS(_appConfig);
		}

		//get
		public string Get(out string returnMessage)
		{
			return this.GetSender().Get(_dataPair, out returnMessage);
		}
		//put
		public string Put(out string returnMessage)
		{
			return this.GetSender().Put(_dataPair, out returnMessage);
		}
		//del
		public string Delete(out string returnMessage)
		{
			return this.GetSender().Delete(_dataPair, out returnMessage);
		}
		//post
		public string Post(out string returnMessage)
		{
			return this.GetSender().Post(_dataPair, out returnMessage);
		}


	}


	public class TemplateImageItem
	{
		public TemplateImageItem()
		{
			image = new Dictionary<string, string>();
		}

		public string text { get; set; }

		public Dictionary<string, string> image { get; set; }
	}

}


public class TemplateAudioItem
{
	public TemplateAudioItem()
	{
		audio = new Dictionary<string, string>();
	}

	public string text { get; set; }

	public Dictionary<string, string> audio { get; set; }
}


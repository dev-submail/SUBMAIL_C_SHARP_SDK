using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class MailSend : SendBase
    {
        private const string TO = "to";
        private const string ADDRESSBOOK = "addressbook";
        private const string FROM = "from";
        private const string FROM_NAME = "from_name";
        private const string REPLY = "reply";
        private const string CC = "cc";
        private const string BCC = "bcc";
        private const string SUBJECT = "subject";
        private const string TEXT = "text";
        private const string HTML = "html";
        private const string VARS = "vars";
        private const string LINKS = "links";
        private const string ATTACHMENTS = "attachments";
        private const string HEADERS = "headers";
		private const string TAG = "tag";
		private const string OTHER = "other";

        public MailSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Mail(_appConfig);
        }

        public void AddTo(string address, string name)
        {
            AddWithBracket(TO, name, address);
        }

        public void AddAddressBook(string addAddressBook)
        {
            AddWithComma(ADDRESSBOOK, addAddressBook);
        }

        public void SetSender(string sender, string name)
        {
            this._dataPair.Add(FROM, sender);
            this._dataPair.Add(FROM_NAME, name);
        }

        public void SetReply(string reply)
        {
            this._dataPair.Add(REPLY, reply);
        }

        public void AddCc(string address, string name)
        {
            this.AddWithBracket(CC, name, address);
        }

        public void AddBcc(string address, string name)
        {
            this.AddWithBracket(BCC, name, address);
        }

        public void SetSubject(string subject)
        {
            this._dataPair.Add(SUBJECT, subject);
        }

        public void SetText(string text)
        {
            this._dataPair.Add(TEXT, text);
        }

        public void SetHtml(string html)
        {
            this._dataPair.Add(HTML, html);
        }

        public void AddVar(string key, string val)
        {
            this.AddWithJson(VARS, key, val);
        }

        public void AddLink(string key, string val)
        {
            this.AddWithJson(LINKS, key, val);
        }

        public void AddAttachment(string file)
        {
            this.AddWithIncrease(ATTACHMENTS, new FileInfo(file));
        }

        public void AddHeaders(string key, string val)
        {
            this.AddWithJson(HEADERS, key, val);
        }

		public void AddTag(string val)
		{
			this.AddWithJson(OTHER, TAG, val);
		}



        public string Send(out string returnMessage)
        {
            return GetSender().Send(_dataPair, out returnMessage);
        }
    }
}

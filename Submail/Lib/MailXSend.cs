using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class MailXSend : SendBase
    {
        public const string TO = "to";
        public const string  ADDRESSBOOK = "addressbook";
	    public const string FROM = "from";
	    public const string FROM_NAME = "from_name";
	    public const string REPLY = "reply";
	    public const string CC = "cc";
	    public const string BCC = "bcc";
	    public const string SUBJECT = "subject";
	    public const string PROJECT = "project";
	    public const string VARS = "vars";
	    public const string LINKS = "links";
	    public const string HEADERS = "headers";
		public const string TAG= "tag";
		public const string OTHER = "other";

        public MailXSend(IAppConfig appconfig) : base(appconfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Mail(_appConfig);
        }

        public void AddTo(string address, string name)
        {
            this.AddWithBracket(TO, name, address);
        }

        public void AddAddressBook(string addressbook)
        {
            this.AddWithComma(ADDRESSBOOK, addressbook);
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

        public void SetProject(string project)
        {
            this._dataPair.Add(PROJECT, project);
        }

        public void AddVar(string key, string val)
        {
            this.AddWithJson(VARS, key, val);
        }

        public void AddLink(string key, string val)
        {
            this.AddWithJson(LINKS, key, val);
        }

        public void AddHeaders(string key, string val)
        {
            this.AddWithJson(HEADERS, key, val);
        }

		public void AddTag(string val)
		{
			this.AddWithJson(OTHER, TAG, val);
		}


        public string XSend(out string returnMessage)
        {
            return this.GetSender().XSend(_dataPair, out returnMessage);
        }
    }
}

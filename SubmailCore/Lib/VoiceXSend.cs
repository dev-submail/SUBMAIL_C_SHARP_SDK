using SubmailCore.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmailCore.Lib
{
    public class VoiceXSend : SendBase
    {
        public const string TO = "to";
        public const string PROJECT = "project";
        public const string VARS = "vars";

        public VoiceXSend(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Voice(_appConfig);
        }

        public void AddTo(string address)
        {
            this.AddWithComma(TO, address);
        }

        public void SetProject(string project)
        {
            this._dataPair.Add(PROJECT, project);
        }

        public void AddVar(string key, string val)
        {
            this.AddWithJson(VARS, key, val);
        }

        public string XSend(out string returnMessage)
        {
            return this.GetSender().XSend(_dataPair, out returnMessage);
        }
    }
}

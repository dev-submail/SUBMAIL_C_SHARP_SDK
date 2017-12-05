using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.AppConfig
{
    public class MailAppConfig : IAppConfig
    {
        public MailAppConfig(string appId, string appKey, SignType signType = SignType.normal)
        {
            this._appId = appId;
            this._appKey = appKey;
            this._signType = signType;
        }

        private string _appId;
        public string AppId
        {
            get
            {
                return _appId;
            }
            set
            {
                _appId = value;
            }
        }

        private string _appKey;
        public string AppKey
        {
            get
            {
                return _appKey;
            }
            set
            {
                _appKey = value;
            }
        }

        private SignType _signType;
        public SignType SignType
        {
            get
            {
                return _signType;
            }
            set
            {
                _signType = value;
            }
        }
    }
}

using SubmailCore.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmailCore.Lib
{
    public class AddressBookMessage : SendBase
    {
        private const string ADDRESS = "address";
        private const string TARGET = "target";

        public AddressBookMessage(IAppConfig appConfig) : base(appConfig)
        {
        }       

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public void SetAddress(string address)
        {
            _dataPair.Add(ADDRESS, address);
        }

        public void SetAddressBook(string target)
        {
            _dataPair.Add(TARGET, target);
        }

        public string Subscribe(out string returnMessage)
        {
            return GetSender().Subscribe(_dataPair, out returnMessage);
        }

        public string UnSubscribe(out string returnMessage)
        {
            return GetSender().UnSubscribe(_dataPair, out returnMessage);
        }
    }
}

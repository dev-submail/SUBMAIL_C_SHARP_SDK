using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class AddressBookMessageDemo
    {
        public void Subscribe()
        {
            IAppConfig appConfig = new MessageConfig("apppid", "appkey");
            AddressBookMessage addressBookMessage = new AddressBookMessage(appConfig);           
            addressBookMessage.SetAddress("13756563150");
			string returnMessage = string.Empty;
			addressBookMessage.Subscribe(out returnMessage);
             Console.WriteLine(returnMessage);
          
        }

        public void UnSubscribe()
        {
            IAppConfig appConfig = new MessageConfig("apppid", "appkey");
            AddressBookMessage addressBookMessage = new AddressBookMessage(appConfig); 
			addressBookMessage.SetAddress("13756563150");
			string returnMessage = string.Empty;
			addressBookMessage.UnSubscribe(out returnMessage);
            Console.WriteLine(returnMessage);
           
        }
    }
}

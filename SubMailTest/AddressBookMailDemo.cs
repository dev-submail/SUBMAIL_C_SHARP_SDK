using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    public class AddressBookMailDemo
    {
        public void Subscribe()
        {
            IAppConfig mailConfig = new MailAppConfig("apppid", "appkey");
            AddressBookMail addressBookMail = new AddressBookMail(mailConfig);
            addressBookMail.SetAddress("leo12@submail.cn", "leo");
			addressBookMail.SetAddressBook("61RgC3");
            string outMessage = string.Empty;
			addressBookMail.Subscribe(out outMessage);      
            Console.WriteLine(outMessage);
        
        }

        public void UnSubscribe()
        {
            IAppConfig mailConfig = new MailAppConfig("appid", "appkey");
            AddressBookMail addressBookMail = new AddressBookMail(mailConfig);
            addressBookMail.SetAddress("leo12@submail.cn", "leo");
            string outMessage = string.Empty;

			addressBookMail.UnSubscribe(out outMessage);
			Console.WriteLine(outMessage);
			Console.ReadKey();
            
        }
    }
}

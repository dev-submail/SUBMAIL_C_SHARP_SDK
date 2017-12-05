using Submail.AppConfig;
using Submail.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMailTest
{
    class MessageLogDemo
    {
        public void messageLog()
        {
			IAppConfig appConfig = new MessageConfig("apppid", "appkey",SignType.md5);
            MessageLog messageLog = new MessageLog(appConfig);
            messageLog.AddProject("d5ngn3");
            messageLog.AddStart_data(setUinxTimeStamp(new DateTime(2017, 8, 20, 1, 10, 10)).ToString());
            messageLog.AddEnd_data(setUinxTimeStamp(new DateTime(2017, 12, 1, 1, 10, 10)).ToString());
            string returnMessage = string.Empty;
			messageLog.Log(out returnMessage);
            Console.WriteLine("接受的消息"+returnMessage);
            Console.ReadKey();
      }  


        public long  setUinxTimeStamp(DateTime dateTime)
        {
              DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));       
            long timeStamp = (long)(dateTime - startTime).TotalSeconds; // 相差秒数
            return timeStamp;
     }
                


    }
}

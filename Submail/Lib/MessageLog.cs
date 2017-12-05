using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public class MessageLog : SendBase
    {
        public const string RECIPIENT = "recipient";
        public const string PROJECT = "project";
        public const string RESULT_STATUS = "result_status";
        public const string START_DATE = "start_date";
        public const string END_DATE = "end_date";
        public const string ORDER_BY = "order_by";
        public const string ROWS = "rows";
        public const string OFFSET = "offset";

        public MessageLog(IAppConfig appConfig) : base(appConfig)
        {
        }

        protected override ISender GetSender()
        {
            return new Message(_appConfig);
        }

        public void AddRecipient(string recipient)
        {
            this.AddWithComma(RECIPIENT, recipient);
        }

        public void AddProject(string project)
        {
            this.AddWithComma(PROJECT, project);
        }

        public void AddResult_status(string result_status)
        {
            this.AddWithComma(RESULT_STATUS, result_status);
        }

        public void AddStart_data(string start_data)
        {
            this.AddWithComma(START_DATE, start_data);
        }


        public void AddEnd_data(string end_data)
        {
            this.AddWithComma(END_DATE, end_data);
        }

        public void AddOrder_by(string order_by)
        {
            this.AddWithComma(ORDER_BY, order_by);
        }


        public void AddRows(string rows)
        {
            this.AddWithComma(ROWS, rows);
        }

        public void AddOffset(string offset)
        {
            this.AddWithComma(OFFSET, offset);
        }


        public string Log(out string returnMessage)
        {
            return this.GetSender().Log(_dataPair, out returnMessage);
        }
    }
}

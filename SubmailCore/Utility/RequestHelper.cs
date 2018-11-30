using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmailCore.Utility
{
    public class RequestHelper
    {
        // 将所有提交的参数升序排列：仅单次提交的参数，不包括 signature 字段升序（A-Z）排列
        public static string FormatRequest(Dictionary<string, object> data)
        {
            StringBuilder builder = new StringBuilder();
            var list = data.Keys.ToList();
            list.Sort();

            foreach (string key in list)
            {
                string value = data[key] as string;
                if (value != null)
                {
                    builder.Append(string.Format("{0}={1}&", key,value));

                }
            }

            string formatData = builder.ToString();
            if (formatData.Length > 0)
            {
                return formatData.Substring(0, formatData.Length - 1);
            }

            return null;
        }
    }
}

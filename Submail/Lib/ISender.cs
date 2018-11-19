using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Submail.Lib
{
	public interface ISender
	{
		/**
	     * Send the request data.
	     * @param data {@link HashMap}contains the request data.Such as
	     * <p>
	     * to->xxx@submail.cn
	     * cc->nnn@submail.cn
	     * text->Hello,world!
	     * </p>
	     * @return If send successfully,return true.Error occurs,return false.
	     **/
		string Send(Dictionary<string, object> data, out string returnMessage);

		string XSend(Dictionary<string, object> data, out string returnMessage);

		string MultiXSend(Dictionary<string, object> data, out string returnMessage);

		string MultiSend(Dictionary<string, object> data, out string returnMessage);

		string Subscribe(Dictionary<string, object> data, out string returnMessage);

		string UnSubscribe(Dictionary<string, object> data, out string returnMessage);

		string VoiceVerify(Dictionary<string, object> data, out string returnMessage);

		string Log(Dictionary<string, object> data, out string returnMessage);

		string Get(Dictionary<string, object> data, out string returnMessage);

		string Put(Dictionary<string, object> data, out string returnMessage);

		string Delete(Dictionary<string, object> data, out string returnMessage);

		string Post(Dictionary<string, object> data, out string returnMessage);

        string Balance(Dictionary<string, object> data, out string returnMessage);
	}
}

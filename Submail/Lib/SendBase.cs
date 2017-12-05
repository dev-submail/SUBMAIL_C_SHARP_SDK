using Newtonsoft.Json;
using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
    public abstract class SendBase
    {
        protected SendBase(IAppConfig appconfig)
        {
            _appConfig = appconfig;
        }

        protected abstract ISender GetSender();

        protected IAppConfig _appConfig;

        protected Dictionary<string, object> _dataPair = new Dictionary<string, object>();

        /**
        * Define a adding pattern that data can be added to map one by one
        * but displayed with a string decorated by angle brackets.
        * For Example,
        * <code> 
        * addWithBracket("K", "v11", "v12");
        * addWithBracket("K", "v21", "v22");
        * </code>
        * Then, the map is {"K", "v11<v12>, v21<v22>"}
        * @param key is the map's key
        * @param left 
        * @param right 
        * */
        protected void AddWithBracket(string key, string left, string right)
        {
            AddWithComma(key, string.Format("{0}<{1}>", left, right));
        }

        /**
	    * Define a adding pattern that data can be added to map one by one
	    * but displayed with a string separated by comma.
	    * For Example,
	    * <code> 
	    * addWithComma("K", "v1");
	    * addWithComma("K", "v2");
	    * </code>
	    * Then, the map is {"K", "v1, v2"}
	    * @param key is the map's key
	    * @param value is the adding data
	    * */
        protected void AddWithComma(string key, string value)
        {
            if (string.IsNullOrEmpty(key.Trim()))
            {
                return;
            }

            if (!_dataPair.ContainsKey(key))
            {
                _dataPair.Add(key, value);
            }
            else
            {
                _dataPair[key] = string.Format("{0},{1}", _dataPair[key], value);
            }
        }

        private int _index = 0;
        /**
	     * Put a data with increasing key.
	     * For exmaple,
	     * <code>addWithIncrease("K", "v1");addWithIncrease("K", "v2");
	     * </code>
	     * Then, the map is {"K[0]", v1},{"K[1]", v2}
	     * @param key is the map's key
	     * @param value is the map's value
	     * */
        public void AddWithIncrease(String key, Object value)
        {
            _dataPair.Add(string.Format("{0}[{1}]", key, _index++), value);
        }

        /**	
	     * Define a adding pattern that data can be added to map one by one
	     * but displayed with a json.
	     * For Example,
	     * <code> 
	     * addWithBracket("K", "jk1", "jv1");
	     * addWithBracket("K", "jk2", "jv2");
	     * </code>
	     * Then, the map is {"K",{"jk1":"jv1","jk2":"jv2"}
	     * @param key is the map's key
	     * @param jKey is the key of json 
	     * @param jValue is the value of json 
	     * */
        public void AddWithJson(string key, string jKey, string jValue)
        {
            if (string.IsNullOrEmpty(key.Trim()))
            {
                return;
            }

            Dictionary<string, string> jsonMap = null;
            if (this._dataPair.ContainsKey(key))
            {
                jsonMap = JsonConvert.DeserializeObject<Dictionary<string, string>>((string)this._dataPair[key]);
            }
            else
            {
                jsonMap = new Dictionary<string, string>();
            }

            if (jsonMap != null)
            {
                jsonMap.Add(jKey, jValue);
                this._dataPair[key] = JsonConvert.SerializeObject(jsonMap);

            }
        }
    }
}


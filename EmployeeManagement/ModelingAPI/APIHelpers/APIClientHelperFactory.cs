using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAPI.APIHelpers
{
    public class APIClientHelperFactory : IAPIClientHelperFactory
    {
        private readonly string _apiKey;
        private readonly string _apiurl;

        public APIClientHelperFactory(string apiKey, string apurl)
        {
            _apiKey = apiKey;
            _apiurl = apurl;
        }

        public APIHelper CreateHttpClient()
        {
            return new APIHelper(_apiKey, _apiurl);
        }
    }
}

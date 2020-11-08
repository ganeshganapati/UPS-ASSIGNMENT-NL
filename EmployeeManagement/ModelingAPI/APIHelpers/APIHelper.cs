using DomainModel.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAPI.APIHelpers
{
    public class APIHelper : HttpClient
    {
        private readonly string _apiKey;
        private readonly string _apiurl;

        public APIHelper(string apiKey,string apurl)
        {
            this.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            this.BaseAddress = new Uri(apurl);
            _apiKey = apiKey;
            _apiurl = apurl;
        }
        public async Task<IEnumerable<UsersResponse>> GetAsync<T>(string uri)
        {

            HttpResponseMessage response =  GetAsync($"{uri}?apikey={_apiKey}").GetAwaiter().GetResult();
            var jsonResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

          
            JsonResponses obj1 = JsonConvert.DeserializeObject<JsonResponses>(jsonResponse);
            var nn = obj1.data;
            IEnumerable<UsersResponse> aaa = obj1.data;
            return aaa;
        }

        public async Task<T> DeleteAsync<T>(string uri)
        {
            HttpResponseMessage response = await DeleteAsync($"{uri}?apikey={_apiKey}");
            string jsonResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>
                (
                jsonResponse,
                new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    // $type no longer needs to be first
                    MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead
                }
                );
        }

        public async Task<JsonPostResponse> PPostAsync<T>(string uri,Users users)
        {

            var json = JsonConvert.SerializeObject(users);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response =  PostAsync($"{uri}", data).GetAwaiter().GetResult();
            var jsonResponse = response.Content.ReadAsStringAsync().Result;

            //return JsonConvert.DeserializeObject<T>(jsonResponse);

            JsonPostResponse responsepost = JsonConvert.DeserializeObject<JsonPostResponse>(jsonResponse);
            return responsepost;
        }
    }

}


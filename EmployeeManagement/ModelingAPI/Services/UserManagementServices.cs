using DomainModel.Models;
using DomainModel.Services;
using ModelingAPI.APIHelpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAPI.Services
{
    public class UserManagementServices : IUserServices
    {
        private readonly APIClientHelperFactory _httpClientFactory;
        public UserManagementServices(APIClientHelperFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<bool> Delete(int id)
        {
            using (APIHelper client = _httpClientFactory.CreateHttpClient())
            {
                string uri = "users/?id=" + id;

                var response = await client.DeleteAsync(uri);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> DeleteUser(int id)
        {
            using (APIHelper client = _httpClientFactory.CreateHttpClient())
            {
                string uri = "users/?id=" + id;

                var response = await client.DeleteAsync(uri);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task<IEnumerable<UsersResponse>> GetUserByFirstName(string name)
        {
            using (APIHelper client = _httpClientFactory.CreateHttpClient())
            {
                string uri = "users/?name="+ name;

                IEnumerable<UsersResponse> users = await client.GetAsync<Users>(uri);

                return users;
            }
        }

        public async Task<JsonPostResponse> RegisterUser(Users entity)
        {
            using (APIHelper client = _httpClientFactory.CreateHttpClient())
            {
                string uri = "users" ;
                JsonPostResponse response = await client.PPostAsync<JsonPostResponse>(uri, entity);
                return response;
            }
        }

        public async Task<IEnumerable<UsersResponse>> GetUserByID(int id)
        {
            using (APIHelper client = _httpClientFactory.CreateHttpClient())
            {
                string uri = "users/?id=" + id;

                IEnumerable<UsersResponse> users = await client.GetAsync<UsersResponse>(uri);

                return users;
            }
        }

       public async Task<IEnumerable<UsersResponse>> GetAllUsers()
        {
            using (APIHelper client = _httpClientFactory.CreateHttpClient())
            {
                string uri = "users";

                IEnumerable<UsersResponse> users = await client.GetAsync<UsersResponse>(uri);

                return users;
            }
        }

    }
}

using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public interface IUserServices
    {
        Task<IEnumerable<UsersResponse>> GetUserByFirstName(string name);
        Task<IEnumerable<UsersResponse>> GetUserByID(int id);
        Task<IEnumerable<UsersResponse>> GetAllUsers();
        Task<JsonPostResponse> RegisterUser(Users entity);
        Task<bool> DeleteUser(int id);

    }
}

using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services.UserManagement
{
    class UserManagementServices : IUserManagementService
    {
        private readonly IUserServices _userServices;

        public UserManagementServices(IUserServices userServices)
        {
            _userServices = userServices;
            
        }
        //public async Task<RegistrationResult> RegisterUser(int idd, string name, string email, string gender, string status, DateTime created_at, DateTime updated_at)
        //{
        //    RegistrationResult result = RegistrationResult.Success;
        //    Users userid = await _userServices.GetUserByID(id);
        //    if (userid != null)
        //    {
        //        result = RegistrationResult.UserIDAlreadyExists;
        //    }

        //    if (result == RegistrationResult.Success)
        //    {
              

        //        Users user = new Users()
        //        {
        //            id = idd,
        //            name = name,
        //            email = email,
        //            gender = gender,
        //            status = status,
        //            created_at = DateTime.Now,
        //            updated_at = DateTime.Now
        //        };

                

        //        await _userServices.RegisterUser(user);
        //    }
        //    return result;
        //}
    }
}

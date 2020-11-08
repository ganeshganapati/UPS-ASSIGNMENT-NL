using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services.UserManagement
{
    public enum RegistrationResult
    {
        Success,
        UserIDAlreadyExists,
        UsernameAlreadyExists
    }
   public interface IUserManagementService
    {

        /// <summary>
        /// Register a new user.
        /// </summary>
        /// <param name="email">The user's email.</param>
        /// <param name="username">The user's name.</param>
        /// <param name="password">The user's password.</param>
        /// <param name="confirmPassword">The user's confirmed password.</param>
        /// <returns>The result of the registration.</returns>
        /// <exception cref="Exception">Thrown if the registration fails.</exception>
        Task<RegistrationResult> RegisterUser(int id, string name, string email, string gender, string status, DateTime created_at, DateTime updated_at);
    }
}

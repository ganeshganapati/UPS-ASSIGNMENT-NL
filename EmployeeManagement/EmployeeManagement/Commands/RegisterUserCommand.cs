using DomainModel.Models;
using DomainModel.Services;
//using DomainModel.Services.UserManagement;
using EmployeeManagement.State.Navigators;
using EmployeeManagement.ViewModels;
using Microsoft.Extensions.Logging;
using ModelingAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Commands
{
    public class RegisterUserCommand : AsyncCommandBase
    {
        private readonly RegisterViewModel _registerViewModel;
        private readonly IRenavigator _registerRenavigator;
        private readonly IUserServices _userManagementService;

        private JsonPostResponse _postResponse;
        public JsonPostResponse postResponse
        {
            get
            {
                return _postResponse;
            }
            set
            {
                _postResponse = value;
            }
        }

        public RegisterUserCommand(RegisterViewModel registerViewModel,/*IRenavigator registerRenavigator,*/ IUserServices userManagementService)
        {
            _registerViewModel = registerViewModel;
            _userManagementService = userManagementService;
           // _registerRenavigator = registerRenavigator;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            _registerViewModel.ErrorMessage = string.Empty;
            _registerViewModel.StatusMessage = string.Empty;
            Users objuser = new Users(
                        _registerViewModel.id,
                       _registerViewModel.name,
                       _registerViewModel.email,
                       _registerViewModel.gender,
                       _registerViewModel.status,
                       _registerViewModel.created_at,
                       _registerViewModel.updated_at);
            try
            {
               // var registrationResult = await _userManagementService.RegisterUser(objuser);

                 await _userManagementService.RegisterUser(objuser).ContinueWith(task =>
                {
                    if (task.Exception == null)
                    {
                        postResponse = (JsonPostResponse)task.Result;

                        switch (postResponse.code)
                        {
                            case 201:
                                _registerViewModel.StatusMessage = "Registration successful";
                                break;
                            case 422:
                                _registerViewModel.ErrorMessage = "Error:" + postResponse.data.Select(item => item.field).FirstOrDefault().ToString() + postResponse.data.Select(item => item.message).FirstOrDefault().ToString();
                                break;
                        }

                    }
                    else
                    {
                        throw new Exception("Service is not avilable/Reachable");
                    }
                });

                
               
                
            }
            catch (Exception ex)
            {
                _registerViewModel.ErrorMessage = ex.Message.ToString();
            }
        }
    }
    
}

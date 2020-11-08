using DomainModel.Services;
using EmployeeManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Commands
{
    class ViewallCommand : AsyncCommandBase
    {
        private readonly ManageUsersViewModel _viewModel;
        private readonly IUserServices _iuserServices;

        public ViewallCommand(ManageUsersViewModel viewModel, IUserServices iuserServices)
        {
            _viewModel = viewModel;
            _iuserServices = iuserServices;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                await _iuserServices.GetAllUsers().ContinueWith(task =>
                {
                    if (task.Exception == null)
                    {
                        _viewModel.musers = task.Result;
                    }
                    else
                    {
                        throw new Exception("Service is not avilable/Reachable");
                    }
                });

            }
            catch (Exception ex) { }

        }
    }
}

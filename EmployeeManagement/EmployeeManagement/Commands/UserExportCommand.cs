using EmployeeManagement.Utlility;
using EmployeeManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Commands
{
    public class UserExportCommand : AsyncCommandBase
    {
        private readonly ManageUsersViewModel _viewModel;
        private readonly IExport _iExport;
        public UserExportCommand(ManageUsersViewModel viewModel, IExport iExport)
        {
            _viewModel = viewModel;
            _iExport = iExport;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
               
               await _iExport.ExportToCSV(_viewModel.musers, ConfigurationManager.AppSettings.Get("ExportPath"));

            }
            catch (Exception ex) 
            {

            }
        }
    }
}

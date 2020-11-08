using DomainModel.Models;
using DomainModel.Services;
using EmployeeManagement.Commands;
using EmployeeManagement.Utlility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeManagement.ViewModels
{
   public class ManageUsersViewModel:ViewModelBase
    {
        private readonly IUserServices _manageUserService;
        private readonly IExport _iExport;
        private readonly IExport _iExportload;
        private int _searchID;
        public int searchID
        {
            get
            {
                return _searchID;
            }
            set
            {
                _searchID = value;
                OnPropertyChanged(nameof(searchID));
            }
        }
        private IEnumerable<UsersResponse> _users;
        public IEnumerable<UsersResponse>  musers
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(musers));
            }
        }
        public ICommand SearchSymbolCommand { get; set; }
        public ICommand UserExportCommand { get; set; }
        public ICommand ViewallCommand { get; set; }
        
    public ManageUsersViewModel(IUserServices iUserServices,IExport iexport)
        {
            _manageUserService = iUserServices;
            _iExport = iexport;
            SearchSymbolCommand = new SearchSymbolCommand(this, iUserServices);
            UserExportCommand = new UserExportCommand(this, _iExport);
            ViewallCommand = new ViewallCommand(this, iUserServices);
        }

        public static ManageUsersViewModel LoadManageUsersViewModel(IUserServices iUserServices,IExport iexport)
        {
            
            ManageUsersViewModel manageUsersViewModel = new ManageUsersViewModel(iUserServices, iexport);
            manageUsersViewModel.LoadUsers();
            return manageUsersViewModel;
        }

        private void LoadUsers()
        {
            _manageUserService.GetAllUsers().ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    musers = task.Result;
                }
            });
            //musers = _manageUserService.GetAllUsers();


        }
    }
}

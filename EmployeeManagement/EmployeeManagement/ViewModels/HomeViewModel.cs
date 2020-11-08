using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class HomeViewModel:ViewModelBase
    {

        public ManageUsersViewModel ManageUsersViewModel { get; }
        public HomeViewModel(ManageUsersViewModel manageusermodelView)
        {

            ManageUsersViewModel = manageusermodelView;
        }
    }
}

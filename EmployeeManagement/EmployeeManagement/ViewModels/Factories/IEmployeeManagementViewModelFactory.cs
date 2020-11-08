using EmployeeManagement.Sate.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels.Factories
{
    public interface IEmployeeManagementViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}

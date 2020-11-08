using System;
using EmployeeManagement.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Dynamic;

namespace EmployeeManagement.Sate.Navigators
{
    public enum ViewType
    {
        
        RegisterUser,
        DeleteUser,
        ManageUser,
        Home
        
    }

     
        public interface INavigator
        {
            ViewModelBase CurrentViewModel { get; set; }
         event Action StateChanged;
        
        }
    }


using EmployeeManagement.Sate.Navigators;
using EmployeeManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels.Factories
{
    public class EmployeeManagementViewModelFactory : IEmployeeManagementViewModelFactory
    {

        private readonly CreateViewModel<StartViewModel> _registerhomeView;
        private readonly CreateViewModel<RegisterViewModel> _registerViewModel;
        private readonly CreateViewModel<HomeViewModel> _createHomeViewModel;

        public EmployeeManagementViewModelFactory(CreateViewModel<HomeViewModel> createHomeViewModel,CreateViewModel<RegisterViewModel> registerViewModel, CreateViewModel<StartViewModel> startviewModel) 
        {
            _createHomeViewModel = createHomeViewModel;
            _registerViewModel = registerViewModel;
            _registerhomeView = startviewModel;
        }
        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.ManageUser:
                    return _createHomeViewModel();
                case ViewType.RegisterUser:
                    return _registerViewModel();
                case ViewType.Home:
                    return _registerhomeView();
                default:
                    throw new ArgumentException("The ViewType does not have a ViewModel.", "viewType");
            }
        }
    }
}

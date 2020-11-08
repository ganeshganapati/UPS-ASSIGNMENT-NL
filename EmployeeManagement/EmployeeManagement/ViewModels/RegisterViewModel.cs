using DomainModel.Models;
using DomainModel.Services;
//using DomainModel.Services.UserManagement;
using EmployeeManagement.Commands;
using EmployeeManagement.State.Navigators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace EmployeeManagement.ViewModels
{
    public class RegisterViewModel:ViewModelBase,IDataErrorInfo
    {
     
        public string this[string columnName]
        {
            get
            {
                string result = null;
                switch (columnName)
                {
                    case "name":
                        if (string.IsNullOrEmpty(name))
                            result = "Name cannot be blank";
                        break;
                    case "email":
                        if (string.IsNullOrEmpty(email))
                            result = "Email cannot be blank";
                        break;
                }
                return result;
            }


            
        }

        public string Error => null;

        public int _id;
        public int id
        {
            get 
            { 
                return _id;
            }
            set 
            {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }


        public string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                 OnPropertyChanged(nameof(name));
            }
        }

        public string _email;
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(email));
            }
        }
        public gender _gender;
        public gender gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(gender));
            }
        }

        public status _status;
        public status status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
            }
        }
        public DateTime _created_at;
        public DateTime created_at
        {
            get
            {
                return _created_at;
            }
            set
            {
                _created_at = value;
                OnPropertyChanged(nameof(created_at));
            }
        }
        public DateTime _updated_at;
        public DateTime updated_at
        {
            get
            {
                return _updated_at;
            }
            set
            {
                _updated_at = value;
                OnPropertyChanged(nameof(updated_at));
            }
        }

        public ICommand RegisterUserCommand { get; }
        public MessageViewModel ErrorMessageViewModel { get; }
        public string ErrorMessage
        {
            set => ErrorMessageViewModel.Message = value;
        }

        public MessageViewModel StatusMessageViewModel { get; }
        public string StatusMessage
        {
            set => StatusMessageViewModel.Message = value;
        }



        public RegisterViewModel(IUserServices iUserServices) 
        {
            
            ErrorMessageViewModel = new MessageViewModel();
            StatusMessageViewModel = new MessageViewModel();
            RegisterUserCommand = new RegisterUserCommand(this, iUserServices);
        }

    }
    public enum genderlist
    {
        Male,
        Femal
    }
    public enum statuslist
    {
        Active,
        Inactive
    }
}

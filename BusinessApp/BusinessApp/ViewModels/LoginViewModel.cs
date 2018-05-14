using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using SQLite;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Repositories;
using BusinessApp.Services;
using Xamarin.Forms;

namespace BusinessApp.ViewModels
{
   public class LoginViewModel : MvxViewModel
    {
        public IUserService _userService { get; } = DependencyService.Get<IUserService>();
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; RaisePropertyChanged(() => Email); }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged(() => Password); }
        }
        public LoginViewModel()
        {
           // IUserService userService = new IUserService();
            
        }

        public void isValid()
        {
            User user = _userService.GetUserByEmail(Email);
            if (user.Password != null && user.Email != null)
            {
                Helpers.Settings.GeneralEmail = user.Email;
                Helpers.Settings.GeneralLogin = "logged in"; 
                ShowViewModel<MainMenuViewModel>();

                //  return true;
            }
            else
            {
                ShowViewModel<RegisterViewModel>();
                // return false;
            }

        }
        public ICommand NavBack
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }

    
    }
}

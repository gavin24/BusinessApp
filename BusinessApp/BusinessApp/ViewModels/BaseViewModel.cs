using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        public BaseViewModel()
        {
            if (Helpers.Settings.GeneralLogin == "logged in")
            {
                ShowViewModel<MainMenuViewModel>();
            }
            else
            {
                ShowViewModel<MainViewModel>();
            }
        }
    
    }
}

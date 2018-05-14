using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Repositories;
using BusinessApp.Services;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using SQLite;
namespace BusinessApp.ViewModels
{
   public class MenusViewModel : MvxViewModel
    {
        public MenusViewModel()
        {

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

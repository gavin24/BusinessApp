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
   public class AccountViewModel : MvxViewModel
    {
        private readonly IAccountService _accountService;
        public ICommand OrderCommand => new MvxCommand(() =>  ShowViewModel<OrdersViewModel>());
        public ICommand QuoteCommand => new MvxCommand(() => ShowViewModel<QuotesViewModel>());
        public ICommand EnqueriesCommand => new MvxCommand(() => ShowViewModel<EnqueriesViewModel>());
        public AccountViewModel(IAccountService accountService)
        {
            _accountService = accountService;
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

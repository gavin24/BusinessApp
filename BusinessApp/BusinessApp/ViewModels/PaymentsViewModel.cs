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
   public class PaymentsViewModel : MvxViewModel
    {
        private readonly IPaymentsService _paymentsService;

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged(() => Name); }
        }
        private long _orderNumber;
        public long OrderNumber
        {
            get { return _orderNumber; }
            set { _orderNumber = value; RaisePropertyChanged(() => OrderNumber); }
        }
        private string _orderDetails;
        public string OrderDetails
        {
            get { return _orderDetails; }
            set { _orderDetails = value; RaisePropertyChanged(() => OrderDetails); }
        }
        private DateTime _billDate;
        public DateTime BillDate
        {
            get { return _billDate; }
            set { _billDate = value; RaisePropertyChanged(() => BillDate); }
        }
        private string _total;
        public string Total
        {
            get { return _total; }
            set { _total = value; RaisePropertyChanged(() => Total); }
        }
        public PaymentsViewModel(IPaymentsService paymentsService)
        {
            _paymentsService = paymentsService;
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

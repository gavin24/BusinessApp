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
   public class AddressViewModel : MvxViewModel
    {
        private readonly IAddressService _addressService;

        private string _number;
        public string Number
        {
            get { return _number; }
            set { _number = value; RaisePropertyChanged(() => Number); }
        }
        private string _street;
        public string Street
        {
            get { return _street; }
            set { _street = value; RaisePropertyChanged(() => Street); }
        }
        private string _postal;
        public string Postal
        {
            get { return _postal; }
            set { _postal = value; RaisePropertyChanged(() => Postal); }
        }
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; RaisePropertyChanged(() => City); }
        }
        private string _province;
        public string Province
        {
            get { return _province; }
            set { _province = value; RaisePropertyChanged(() => Province); }
        }

        public AddressViewModel(IAddressService addressService)
        {
            _addressService = addressService;
        }
        public ICommand Submit => new MvxCommand(createAddress);
        public void createAddress()
        {
            Address newAddress = new Address();
            //newAddress.Line1 = Number;
           // newAddress.Line2 = Street;
          //  newAddress.Line3 = Postal;
          //  newAddress.Line4 = City;
          //  newAddress.Line5 = Province;
            _addressService.Save(newAddress);
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

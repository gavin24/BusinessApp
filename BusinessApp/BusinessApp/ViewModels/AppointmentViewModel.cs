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
   public class AppointmentViewModel : MvxViewModel
    {
        private readonly IAppointmentService _appointmentService;

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged(() => Name); }
        }
        private DateTime _appointmentDate;
        public DateTime AppointmentDate
        {
            get { return _appointmentDate; }
            set { _appointmentDate = value; RaisePropertyChanged(() => AppointmentDate); }
        }
        private DateTime _appointmentTime;
        public DateTime AppointmentTime
        {
            get { return _appointmentTime; }
            set { _appointmentTime = value; RaisePropertyChanged(() => AppointmentTime); }
        }
        private string _appointmentEndTime;
        public string AppointmentEndTime
        {
            get { return _appointmentEndTime; }
            set { _appointmentEndTime = value; RaisePropertyChanged(() => AppointmentEndTime); }
        }
        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; RaisePropertyChanged(() => Notes); }
        }

        public AppointmentViewModel(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public ICommand Submit => new MvxCommand(createAppointment);
        public void createAppointment()
        {
            Appointment newAppointment = new Appointment();
          //  newAppointment = Name;
        //    newAppointment.AppointmentDate = AppointmentDate;
           // newAppointment.StartTime = AppointmentTime;
           // newAppointment.EndTime = AppointmentEndTime;
          //  newAppointment.Notes = Notes;
            _appointmentService.Save(newAppointment);
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

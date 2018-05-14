using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System.Reflection;
using MvvmCross.Platform.IoC;
using BusinessApp.Models;
using SQLite;
using Xamarin.Forms;

using SQLite.Net;
using BusinessApp.Contracts.Services;
using BusinessApp.Services;

namespace BusinessApp
{
    /// <summary>
    /// Main App class inherits from MvxApplication
    /// - Registers the interfaces and implementations the app uses.
    /// - Registers which ViewModel the App will show when it starts.
    /// - Controls how ViewModels are locate, most solutions will use default implementation supplied by MvxApplication.
    /// </summary>
    public class App : MvxApplication
    {
        /// <summary>
        /// Setup IoC registrations.
        /// </summary>
        //public App()
        //{
        //    // Whenever Mvx.Resolve is used, a new instance of Calculation is provided.
        //    //  Mvx.RegisterType<IBillCalculator, BillCalculator>();
        //    //   var calcExample = Mvx.Resolve<IBillCalculator>();

        //    // Tells the MvvmCross framework that whenever any code requests an IMvxAppStart reference,
        //    // the framework should return that same appStart instance.


        //    base.Initialize();

        //    CreatableTypes(typeof(App).GetTypeInfo().Assembly).EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
        //    CreatableTypes(typeof(App).GetTypeInfo().Assembly).EndingWith("Repository").AsInterfaces().RegisterAsLazySingleton();


        //    Mvx.RegisterSingleton<IMxAppConfigService>(appConfigService);
        //    Mvx.RegisterSingleton<ITastewiseAppConfigService>(appConfigService);
        //    var appStart = new CustomAppStart();
        //    Mvx.RegisterSingleton<IMvxAppStart>(appStart);
        //    RegisterAppStart();
        //    // Another option is to utilize a default App Start object with 
        //    // var appStart = new MvxAppStart<TipViewModel>();
        //}
        
        public override void Initialize()
        {
            base.Initialize();
            
            //CreatableTypes(typeof(App).GetTypeInfo().Assembly).EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
            //CreatableTypes(typeof(App).GetTypeInfo().Assembly).EndingWith("Repository").AsInterfaces().RegisterAsLazySingleton();
            CreatableTypes()
              .EndingWith("Service")
              .AsInterfaces()
              .RegisterAsLazySingleton();
          CreatableTypes()
           .EndingWith("Repository")
           .AsInterfaces()
           .RegisterAsLazySingleton();
            var appStart = new CustomAppStart();
            // Mvx.RegisterSingleton<IMvxAppStart>(appStart);
            //   CreateAllTables();
          
            RegisterAppStart(appStart);
        }
        public void CreateAllTables()
        {
            var db = DependencyService.Get<ISQLite>().GetConnection();
            
            db.CreateTable<User>();
            db.CreateTable<Account>();
            db.CreateTable<Address>();
            db.CreateTable<Appointment>();
            db.CreateTable<Bill>();
            db.CreateTable<Cart>();
            db.CreateTable<Categories>();
            db.CreateTable<Client>();
            db.CreateTable<ContactInfo>();
            db.CreateTable<Enqueries>();
            db.CreateTable<Images>();
            db.CreateTable<Location>();
            db.CreateTable<Menus>();
            db.CreateTable<Notification>();
            db.CreateTable<OrderLine>();
            db.CreateTable<Orders>();
            db.CreateTable<PaymentOption>();
            db.CreateTable<Price>();
            db.CreateTable<Products>();
            db.CreateTable<Quotes>();
            db.CreateTable<Stock>();
       
        }

    }
}

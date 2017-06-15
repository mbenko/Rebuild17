using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyRoadshowApp
{
    public static class MyAppContext
    {
        static MyDataViewModel _model;
        public static MyDataViewModel ViewModel => _model ?? (_model = new MyDataViewModel());
    }

    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new myRoadshow.MainPage();
            MainPage = new MasterDetailPage
            {
                Master = new MenuPage { Title = "Menu" },
                Detail = new MainPage { Title = "Roadshow" }
            };
        }

		protected override void OnStart ()
		{
            // Handle when your app starts
            MobileCenter.Start("android=9cff0fb0-5591-4bac-807a-3fbbb5e71983;" +
                               "uwp={Your UWP App secret here};" +
                               "ios={Your iOS App secret here}",
                               typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

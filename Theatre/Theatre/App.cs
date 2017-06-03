﻿using System.Diagnostics;
using FFImageLoading.Config;
using Plugin.Settings;
using Theatre.Services;
using Theatre.View;
using Theatre.View.PerformancePage;
using Theatre.ViewModel;
using Xamarin.Forms;

namespace Theatre
{
    public partial class App : Application
    {
        public static ViewModelLocator VMLocator = new ViewModelLocator();

        public App()
        {
            //InitializeComponent();
            //if ("1" == CrossSettings.Current.GetValueOrDefault<string>("timestamp", "1"))
            //{

            //    MainPage = new View.SwipeLeftMenuPage();
            //    MainPage = new NavigationPage(new View.WelcomPage());
            //}
            //else
            {
                MainPage = new View.SwipeLeftMenuPage();
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
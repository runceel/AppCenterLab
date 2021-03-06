﻿using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Auth;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCenterLab
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start($"android={AppCenterConfiguration.Android};" +
                  $"ios={AppCenterConfiguration.iOS}",
                  typeof(Analytics), typeof(Crashes), typeof(Auth), typeof(Data));
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

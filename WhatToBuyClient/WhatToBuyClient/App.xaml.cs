using System;
using WhatToBuyClient.Services;
using WhatToBuyClient.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatToBuyClient
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

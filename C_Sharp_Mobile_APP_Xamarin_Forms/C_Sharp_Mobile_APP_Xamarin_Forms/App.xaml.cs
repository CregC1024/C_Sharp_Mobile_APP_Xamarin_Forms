using C_Sharp_Mobile_APP_Xamarin_Forms.Services;
using C_Sharp_Mobile_APP_Xamarin_Forms.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace C_Sharp_Mobile_APP_Xamarin_Forms
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

using ForknGoodApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForknGoodApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());//Navigates to Home Page
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

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamIntro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            //MainPage = new RegistrationPage();
            //MainPage = new BookingsCarouselPage();
            //MainPage = new BookingsTabbedPage();
            // MainPage = new Page1();
            //MainPage = new NavigationPage(new Page1());
            //MainPage = new MasterDetailCSPage();
            //MainPage = new MasterDetailXamlPage();
            //MainPage = new NavigationPage(new AdvGrid());
            //MainPage = new NavigationPage(new LVPage1());
            MainPage = new NavigationPage(new LVPage2());
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

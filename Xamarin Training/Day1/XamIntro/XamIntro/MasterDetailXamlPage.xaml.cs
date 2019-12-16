using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamIntro
{
    public partial class MasterDetailXamlPage : MasterDetailPage
    {
        public MasterDetailXamlPage()
        {
            InitializeComponent();

            if (Device.Idiom == TargetIdiom.Tablet)
                this.MasterBehavior = MasterBehavior.Split;
            else
                this.MasterBehavior = MasterBehavior.Popover;

            MasterPage.ButtonHotels.Clicked += ButtonHotels_Clicked;
            MasterPage.ButtonFlight.Clicked += ButtonFlight_Clicked;
            MasterPage.ButtonCab.Clicked += ButtonCab_Clicked;
        }

        private void ButtonCab_Clicked(object sender, EventArgs e)
        {
            this.Detail = new NavigationPage(new CabPage());
            if (Device.Idiom == TargetIdiom.Phone)
                this.IsPresented = false;
        }

        private void ButtonFlight_Clicked(object sender, EventArgs e)
        {
            this.Detail = new NavigationPage(new FlightPage());
            if (Device.Idiom == TargetIdiom.Phone)
                this.IsPresented = false;
        }

        private void ButtonHotels_Clicked(object sender, EventArgs e)
        {
            this.Detail = new NavigationPage(new HotelPage());
            if (Device.Idiom == TargetIdiom.Phone)
                this.IsPresented = false;
        }
    }
}

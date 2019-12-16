using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamIntro
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            ButtonContinue.Clicked += ButtonContinue_Clicked;
        }

        private async void ButtonContinue_Clicked(object sender, EventArgs e)
        {
            var uname = EntryName.Text;
            //await Navigation.PushModalAsync(new Page2(uname));
            await Navigation.PushAsync(new Page2(uname));
        }
    }
}

using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamIntro
{
    public partial class Page2 : ContentPage
    {
        public Page2(string uname)
        {
            InitializeComponent();
            LabelMessage.Text = $"Welcome {uname} to Xamarin.Forms";
            ButtonBack.Clicked += ButtonBack_Clicked;
        }

        private async void ButtonBack_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PopModalAsync();
            await Navigation.PopAsync();
        }
    }
}

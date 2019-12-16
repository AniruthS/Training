using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamIntro
{
    public partial class LVPage2 : ContentPage
    {
        public LVPage2()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var speakers = new SpeakerService().GetSpeakers();
            ListViewSpeakers.ItemsSource = speakers;
        }
    }
}

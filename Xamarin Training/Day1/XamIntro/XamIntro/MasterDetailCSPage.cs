using System;

using Xamarin.Forms;

namespace XamIntro
{
    public class MasterDetailCSPage : MasterDetailPage
    {
        public MasterDetailCSPage()
        {
            this.Master = new MasterPage();
            this.Detail = new NavigationPage(new DefaultDetailPage());
        }
    }
}


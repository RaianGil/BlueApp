using BlueApp.Controllers;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlueApp
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
            var db = SQLiteConn.getInstance();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

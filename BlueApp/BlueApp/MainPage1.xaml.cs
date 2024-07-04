using BlueApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.Bluetooth.Printer.Plugin.Abstractions;

namespace BlueApp
{
    public partial class MainPage1 : ContentPage
    {
        private readonly IPrint prints;
        public MainPage1()
        {
            InitializeComponent();
            //prints = DependencyService.Get<IPrint>();
            //carCode.Focus();
            //entPrinterName.Text = "MPD31D-18A6";

        }

        private void entPr_Clicked(object sender, EventArgs e)
        {
            entPrueb.Focus();
        }
    }
}

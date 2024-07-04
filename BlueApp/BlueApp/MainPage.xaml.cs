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
    public partial class MainPage : ContentPage
    {
        private readonly IPrint prints;
        public MainPage()
        {
            InitializeComponent();
            prints = DependencyService.Get<IPrint>();
            carCode.Focus();
            entPrinterName.Text = "MPD31D-18A6";
        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
            string textToPrint =
                "^XA \r" +
                "^FT15,87 \r" +
                "^CI0 \r" +
                "^A0N,20,23^FDMARCA:^FS \r" +
                "^FT243,81 \r" +
                "^A0N,23,29^FDCOLOR:^FS \r" +
                "^FT15,116 \r" +
                "^A0N,20,23^FDMODELO:^FS \r" +
                "^FT15,151 \r" +
                "^A0N,20,23^FDANO:^FS \r" +
                "^FT99,89 \r" +
                "^A0N,20,21^FD@marca^FS \r" +
                "^FT339,79 \r" +
                "^A0N,17,19^FD@color^FS \r" +
                "^FT115,116 \r" +
                "^A0N,20,21^FD@modelo^FS \r" +
                "^FT85,151 \r" +
                "^A0N,20,21^FD@year^FS \r" +
                "^FO243,92 \r" +
                "^BY3^BCN,69,Y,N^FD>;@numero^FS \r" +
                "^FT193,41 \r" +
                "^A0N,25,29^FDGRUPO VIAMAR ^FS \r" +
                "^FO395,169 \r" +
                "^XGR:SSGFX000.GRF,1,1^FS \r" +
                "^PQ1,0,1,Y \r" +
                "^XZ";

            textToPrint = textToPrint.Replace("@marca", lblMarca.Text);
            textToPrint = textToPrint.Replace("@modelo", lblModelo.Text);
            textToPrint = textToPrint.Replace("@color", lblColor.Text);
            textToPrint = textToPrint.Replace("@numero", lblCode.Text);
            textToPrint = textToPrint.Replace("@year", lblYear.Text);

            await prints.PrintText($"{textToPrint}", entPrinterName.Text);
            slCarInfo.IsVisible = false;
            btnPrint.IsVisible = false;
            carCode.Focus();
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(carCode.Text))
                return;
            var car = SQLiteConn.getInstance().findCarByCode(carCode.Text);
            lblCode.Text = carCode.Text;
            carCode.Text = "";
            slCarInfo.IsVisible = car != null;
            btnPrint.IsVisible = car != null;
            if (car == null)
                return;
            lblMarca.Text = car.CarBrand;
            lblModelo.Text = car.CarMod;
            lblColor.Text = car.CarColor;
            lblYear.Text = car.CarYear.ToString();

        }
    }
}

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using BlueApp.Models;
using BlueApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System.Threading;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(MyEntryRenderer))]
namespace BlueApp.Droid
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.RequestFocus();
            var timer = new Timer(state => {
                Device.BeginInvokeOnMainThread(() =>
                {
                    Control.RequestFocus();
                });
            }, null, 0, 2000);
            
            Control.FocusChange += Control_FocusChange;
        }
        private void Control_FocusChange(object sender, FocusChangeEventArgs e)
        {
            var edittext = (EditText)Control;
            edittext.ShowSoftInputOnFocus = false;
        }
    }
}
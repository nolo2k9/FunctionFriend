using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net.Mobile.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunctionFriend
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QR : ContentPage
    {
        public QR()
        {
            InitializeComponent();
        }

        //Method exeuctes if 'scan away' button is clicked
        private async void Scanner_Clicked(object sender, EventArgs e)
        {
            // sets scanner ZXingScannerPage instance
            var scanner = new ZXingScannerPage();
            await Navigation.PushAsync(scanner);
            scanner.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    //returns whats read to text
                    leCode.Text = result.Text;
                });

            };
        }
    }
}
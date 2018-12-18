using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FunctionFriend
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void bmi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bmi());
        }

        async void timers_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timers());
        }
        async void flash_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Flash());
        }

       async void Location_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Locaton());
        }
        async void qr_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QR());
        }

        async void Comunmication_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Communication());
        }

       
        
    }
}

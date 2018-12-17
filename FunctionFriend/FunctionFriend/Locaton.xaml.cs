using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunctionFriend
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Locaton : ContentPage
	{
		public Locaton ()
		{
			InitializeComponent ();
		}
        private async void GetLocationBtn_Clicked(object sender, EventArgs e)
        {
            //gets current location of the device
            try

            {
                //gte s accuracy of location
                var request = new GeolocationRequest(GeolocationAccuracy.High);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    //Gets current lattitude and Longitude of device
                    longLat.Text = "Lattitude: " + location.Latitude + " " + "Longitude: " + location.Longitude;
                    //Gtes devices current altitude

                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }
    }
}
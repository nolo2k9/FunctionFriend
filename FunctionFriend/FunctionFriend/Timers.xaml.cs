using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunctionFriend
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Timers : ContentPage
	{
        //inititialise Stopwatch object
        Stopwatch stopwatch;
        public Timers ()
		{
			InitializeComponent ();
            stopwatch = new Stopwatch();
            displayStopwatch.Text = "00:00:00:0000000";
        }
        private void Start_Clicked(object sender, EventArgs e)
        {
            Start.Text = "Start";

            stopwatch.Start();
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                displayStopwatch.Text = stopwatch.Elapsed.ToString();
                return true;
            }
            );


        }

        private void Stop_Clicked(object sender, EventArgs e)
        {
            stopwatch.Stop();
            Start.Text = "Resume";
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            displayStopwatch.Text = "00:00:00:0000000";
            stopwatch.Reset();
            Start.Text = "Start";
        }
    }
}
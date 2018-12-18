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
            // Default Stopwatch Display
            displayStopwatch.Text = "00:00:00:0000000";
        }
        // When Start button is clicked
        //Calls Stopwatch.START() method
        //Displays the time to a string using the toString method
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
        // When Stop button is clicked
        //Calls Stopwatch.STOP() method
        //Displays the time to a string using the toString method
        //Start button changes dispaly to resume
        private void Stop_Clicked(object sender, EventArgs e)
        {
            stopwatch.Stop();
            Start.Text = "Resume";
        }
        // When Reset button is clicked
        //Calls Stopwatch.Reset() method
        //Displays the time to a string using the toString method
        //Start button changes dispaly to Start
        private void Reset_Clicked(object sender, EventArgs e)
        {
            displayStopwatch.Text = "00:00:00:0000000";
            stopwatch.Reset();
            Start.Text = "Start";
        }
    }
}
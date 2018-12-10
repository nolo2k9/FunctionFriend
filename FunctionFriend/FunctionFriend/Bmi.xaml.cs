using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunctionFriend
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bmi : ContentPage
	{
		public Bmi ()
		{
			InitializeComponent ();
		}


        //Method that does all the work!
        private void btnChangeLabel_Clicked(object sender, EventArgs e)
        {
            //Converting String inputs to Doubles for calculation
            double height = Convert.ToDouble(entryHeight.Text);
            double weight = Convert.ToDouble(entryWeight.Text);

            //BMI Calculation using parsed doubles
            double bmiCalculated = weight / (height * height);

            //Output formatted result by changing bmiCalc to a string
            lblDisplay.Text = "Your BMI is: " + bmiCalculated.ToString("F");
            entryHeight.Text = "";
            entryWeight.Text = "";

        }
    }
}
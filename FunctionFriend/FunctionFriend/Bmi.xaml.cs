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


            // if /else to calculate users Weight class
            if (bmiCalculated <=15)
            {
                lblDisplay2.Text = "Very severely underweight ";
            }
            else if (bmiCalculated >15 && bmiCalculated <= 16)
            {

                lblDisplay2.Text = "Severely underweight ";
            }
            else if (bmiCalculated > 16 && bmiCalculated <=18.5)
            {
                lblDisplay2.Text = "Underweight  ";
            }
            else if (bmiCalculated > 18.5 && bmiCalculated <= 25)
            {
                lblDisplay2.Text = "Normal (healthy weight) ";
            }
            else if (bmiCalculated >25 && bmiCalculated <= 30)
            {
                lblDisplay2.Text = "Overweight  ";
            }
            else if (bmiCalculated > 30 && bmiCalculated <= 35)
            {
                lblDisplay2.Text = "Obese Class I (Moderately obese)  ";
            }
            else if (bmiCalculated > 35 && bmiCalculated <= 40)
            {
                lblDisplay2.Text = "Obese Class II (Severely obese)  ";
            }
            else if (bmiCalculated > 40 && bmiCalculated <= 45)
            {
                lblDisplay2.Text = "Obese Class III (Very severely obese)  ";
            }
            else if (bmiCalculated > 45 && bmiCalculated <= 50)
            {
                lblDisplay2.Text = "Obese Class IV (Morbidly Obese)  ";
            }
            else if (bmiCalculated > 50 && bmiCalculated <= 60)
            {
                lblDisplay2.Text = "Obese Class V (Super Obese)   ";
            }
            else if(bmiCalculated > 60)
            {
                lblDisplay2.Text = "Obese Class VI (Hyper Obese)   ";
            }
        }
    }
}
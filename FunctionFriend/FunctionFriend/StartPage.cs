using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.Emit;

using Xamarin.Forms;


namespace FunctionFriend
{
    public class StartPage : ContentPage
    {
        //spash page image
        Image SpalshPic;


        public StartPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            SpalshPic = new Image
            {
                //image source
                Source = "login",
                WidthRequest = 100,
                HeightRequest = 100
            };
            //sets layout flags and postions and bounds
            AbsoluteLayout.SetLayoutFlags(SpalshPic,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SpalshPic,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(SpalshPic);
            //sets background colour
            this.BackgroundColor = Color.FromHex("#429de3");
            this.Content = sub;



        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await SpalshPic.ScaleTo(1, 2000);
            await SpalshPic.ScaleTo(0.9, 1500, Easing.Linear);
            await SpalshPic.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new MainPage());//what page to navigate to next
        }
    }
}

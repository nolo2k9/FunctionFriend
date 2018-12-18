using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Messaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunctionFriend
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Communication : ContentPage
	{
		public Communication ()
		{
			InitializeComponent ();
		}


        private void SMS_Clicked(object sender, EventArgs e)
        {
            //Send an SMS
            var sendSms =
                CrossMessaging.Current.SmsMessenger;
            //Checks to see if platform can send message
            if (sendSms.CanSendSms)
                sendSms.SendSms("+353858143100", "Hello, Sent from Funtion Friend");

        }
        private void TelePhone_Clicked(object sender, EventArgs e)
        {
            //Brings user to a phone dialler 
            var phone = CrossMessaging.Current.PhoneDialer;
            //Checks to see if platform can send message
            if (phone.CanMakePhoneCall)
                phone.MakePhoneCall("999", "Emergency Services");
        }

        private void Email_Clicked(object sender, EventArgs e)
        {
            var email = CrossMessaging.Current.EmailMessenger;
            if (email.CanSendEmail)
            {
                //sends an email with no attachments
                email.SendEmail("to.email@gmail.com", "Hello");

                //Can send a more complex email.
                //With Multiple recipiants, bcc, attachments

                var email2 = new EmailMessageBuilder()
                    .To("to. person@email.com")
                    .Cc("cc.person")
                    .Bcc(new[] { "bcc1.xamarin.com" })
                    .Subject("Messaging")
                    .Body("Hello, From Function Friend")
                    .Build();
                email.SendEmail(email2);
            }
        }
    }
}
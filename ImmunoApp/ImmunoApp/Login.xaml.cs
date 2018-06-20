using System;
using Xamarin.Forms;
using Acr.UserDialogs;

namespace ImmunoApp
{
	public partial class Login : ContentPage
    {
		public Login()
		{ 
			InitializeComponent();
            image.Source = ImageSource.FromResource("ImmunoApp.Images.Logo.jpg");
            image.GestureRecognizers.Add(new TapGestureRecognizer());
		}

      
        //Login
        void Handle_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainContainer();
            


        }
        //Passwort vergessen
        void Handle_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PasswortVergessen());
        }
    }
}

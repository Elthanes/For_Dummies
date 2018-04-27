using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImmunoApp
{
	public partial class MainPage : ContentPage
    {
		public MainPage()
		{ 
			InitializeComponent();
            image.Source = ImageSource.FromResource("ImmunoApp.Images.Logo.jpg");
            image.GestureRecognizers.Add(new TapGestureRecognizer());
		}

      
        //Login
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Home());
        }
        //Passwort vergessen
        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

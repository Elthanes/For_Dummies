using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImmunoApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Taking : ContentPage
	{
		public Taking ()
		{
			InitializeComponent ();
		}

        //Date Picked
void Handle_DateSelected(object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
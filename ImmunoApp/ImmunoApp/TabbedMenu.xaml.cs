using Naxam.Controls.Forms;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImmunoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedMenu : BottomTabbedPage
    {
        public TabbedMenu()
        {
            InitializeComponent();

            //taking.Source = ImageSource.FromResource("ImmunoApp.Images.taking.png");

        }
    }
}

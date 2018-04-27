using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ImmunoApp
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();

            taking.Image = (Xamarin.Forms.FileImageSource)ImageSource.FromFile("ImmunoApp.Images.taking.png");
        }
    }
}

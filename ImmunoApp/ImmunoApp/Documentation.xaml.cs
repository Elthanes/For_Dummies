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
    public partial class Documentation : ContentPage
    {
        public Documentation()
        {
            InitializeComponent();

            var table = new TableView();
            table.Intent = TableIntent.Settings;



            //Erste Zeile
            // Section Definition - an Root mappen
            var letzteEinnahme = new StackLayout() { Orientation = StackOrientation.Horizontal };
      
            // Zeilen Definition - an Section mappen
            //Text
            letzteEinnahme.Children.Add(new Label()
            {
                Margin = new Thickness(15, 15, 15, 15),
                Text = "Datum",
                VerticalOptions = LayoutOptions.Center
            });

            //Datum
            letzteEinnahme.Children.Add(new Label()
            {
                Margin = new Thickness(15, 15, 15, 15),
                Text = "Placeholder Datum",
                VerticalOptions = LayoutOptions.EndAndExpand
            });


            // Letzte 30 Tage Definition
            var Einnahme = new StackLayout() { Orientation = StackOrientation.Horizontal };

            // Zeilen Definition - an Section mappen

            //Text
            Einnahme.Children.Add(new Label()
            {
                Margin = new Thickness(15, 15, 15, 15),
                Text = "Datum",
                VerticalOptions = LayoutOptions.Center
            });

            //Datum
            Einnahme.Children.Add(new Label()
            {
                Margin = new Thickness(15, 15, 15, 15),
                Text = "Placeholder Datum",
                VerticalOptions = LayoutOptions.EndAndExpand
            });


       //Table Root - ab hier Sections einfügen
         table.Root = new TableRoot() {
                
                // Letzte Einnahme 
        new TableSection("Letzte Einnahme") {
        new ViewCell() {View = letzteEinnahme}
                },

                //Letzte 30 Tage
        new TableSection("Letzte 30 Tage")
                {
        new ViewCell() {View = Einnahme},
        new ViewCell() {View = Einnahme},
        new ViewCell() {View = Einnahme},
        new ViewCell() {View = Einnahme}
                },

                // Älter
        new TableSection("Älter")
                {
        new ViewCell() {View = Einnahme},
        new ViewCell() {View = Einnahme}
                }

            };

            Content = table;
          }
	}
}


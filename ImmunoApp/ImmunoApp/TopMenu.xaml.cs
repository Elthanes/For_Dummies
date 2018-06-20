using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ImmunoApp
{

    /// <summary>
    /// TopMenu represents the menu structure on the top of the app.
    /// Author: Christian Bender
    /// </summary>
    public partial class TopMenu : ContentPage
    {
        public ListView ListView { get { return _listView; } }
        ListView _listView;

        /// <summary>
        /// Constructor
        /// </summary>
        public TopMenu()
        {


            /*
            var settings = new ToolbarItem
            {
                Icon = "ic_refresh",
                Name = "Settings"
               //Command = new Command(this.pageTo),
            };

            Console.WriteLine("Adding ic_refresh");
            this.ToolbarItems.Add(settings);
            */


            //image.Source = ImageSource.FromResource("ImmunoApp.Images.Logo.jpg");


            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Einstellungen",
                IconSource = "ic_settings.png",
                TargetType = typeof(Settings)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Profil",
                IconSource = "ic_account_circle.png",
                TargetType = typeof(UserPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Über",
                IconSource = "ic_info.png",
                TargetType = typeof(About)
            });


            _listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    var grid = new Grid { Padding = new Thickness(5, 10) };
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                    var image = new Image();
                    image.SetBinding(Image.SourceProperty, "IconSource");
                    var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
                    label.SetBinding(Label.TextProperty, "Title");

                    grid.Children.Add(image);
                    grid.Children.Add(label, 1, 0);

                    return new ViewCell { View = grid };
                }),
                SeparatorVisibility = SeparatorVisibility.Default
            };

            Icon = "ic_menu.png";
            Title = "Personal Organiser";
            Padding = new Thickness(0, 40, 0, 0);
            Content = new StackLayout
            {
                Children = { _listView }
            };

        }
    }
}
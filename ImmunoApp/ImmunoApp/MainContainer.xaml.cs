using System;
using Xamarin.Forms;

namespace ImmunoApp
{

    /// <summary>
    /// MainContainer holds all elements, does the navigation, derived from MasterDetailPage
    /// Author: Christian Bender
    /// </summary>
    public partial class MainContainer : MasterDetailPage
    {
        TopMenu masterPage;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainContainer()
        {
            masterPage = new TopMenu();
            Master = masterPage;
            Detail = new NavigationPage(new TabbedMenu());
            masterPage.ListView.ItemSelected += OnItemSelected;
        }

        /// <summary>
        /// Handles the selection of items for changing the current view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Console.WriteLine(item.TargetType);
                Detail.Navigation.PushAsync((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
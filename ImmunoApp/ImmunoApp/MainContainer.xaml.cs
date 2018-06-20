using Acr.UserDialogs;
using System;
using System.Threading.Tasks;
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
            InitializeComponent();
            masterPage = new TopMenu();
            Master = masterPage;
            Detail = new NavigationPage(new TabbedMenu());
            masterPage.ListView.ItemSelected += OnItemSelected;

            //create refresh item
            var refresh_elem = new ToolbarItem
            {
                Icon = "ic_refresh",
                Command = new Command(this.handleSync),

            };

            //add to toolbar
            this.ToolbarItems.Add(refresh_elem);
        }

        /// <summary>
        /// handles async call of synchronization task
        /// </summary>
        /// <param name="obj"></param>
        private async void handleSync(object obj)
        {
            using (UserDialogs.Instance.Loading("Synchronisierung läuft..."))
            {
                for (int i = 0; i <= 100; i++)
                {
                    await Task.Delay(50);
                }
            }

            /*
           using (IProgressDialog progress = UserDialogs.Instance.Progress("Synchronisierung läuft", null, null, true, MaskType.Black))
           {
               for (int i = 0; i <= 100; i++)
               {
                   await Task.Run(() => progress.PercentComplete = i);
                   await Task.Delay(50);
               }
               await Task.Delay(1000);
           }



           IProgressDialog progress = UserDialogs.Instance.Progress("Synchronisierung läuft", null, null, true, MaskType.Black);
           for (int i = 0; i <= 100; i++)
           {
               progress.PercentComplete = i;
               await Task.Delay(50);
           }
           await Task.Delay(1000);
           progress.Hide();
           */

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
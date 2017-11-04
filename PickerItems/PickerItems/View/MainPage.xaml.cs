using CrossPieCharts.FormsPlugin.Abstractions;
using PickerItems.ViewModel;
using System;
using System.Linq;
using Xamarin.Forms;

namespace PickerItems
{
    public partial class MainPage : ContentPage
    {
        IMyLocation loc;
        MainPageViewModel vm = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();

            
            BindingContext = vm;
            Countries.ItemsSource = vm.countries.ToList();
        }

        private void Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            States1.IsEnabled = true;
            vm.addStates(Countries.SelectedItem.ToString());
            States1.SelectedIndex = 0;
        }

        private  void LocationGet_Clicked(object sender, EventArgs e)
        {
            
            DependencyService.Get<IProgressInterface>().Show();
            loc = DependencyService.Get<IMyLocation>();
            loc.locationObtained += (object sender1,
            ILocationEventArgs e1) =>
            {
                var lat = e1.lat;
                var lng = e1.lng;
                LocationT.Text = "Latitude: " + lat.ToString() + " Longitude: " + lng.ToString();
                if (LocationT.Text != null)
                    DependencyService.Get<IProgressInterface>().Hide();
            };       
            loc.ObtainMyLocation();
        }

        private void DataList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Alert msg", "ID:" + e.SelectedItem.ToString(), "OK");
            DataList.SelectedItem = null;
        }
    }
}

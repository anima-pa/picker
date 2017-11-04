using System;


using Xamarin.Forms;


namespace PickerItems.View
{
    
    public partial class progressGrid : ContentPage
    {
        
        public progressGrid()
        {
            
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(.02), OnTimer);
            loc = DependencyService.Get<IMyLocation>();

            loc.locationObtained += (object sender1,
            ILocationEventArgs e1) => {
                var lat = e1.lat;
                var lng = e1.lng;
                //LocationT.Text = "Latitude: " + lat.ToString() + " Longitude: " + lng.ToString();
                
            };
            loc.ObtainMyLocation();
        }

        public bool OnTimer()
        {
          
            var progress = (progressCon.Progress + .01);
            

            if (progress > 1) { progress = 0; }
            if (progress == 1)//LocationT.Text != null)
            {
                
                return false;
            }

            progressCon.Progress = progress;
            return true;
        }
    }
}
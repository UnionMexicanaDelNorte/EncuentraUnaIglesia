using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace maptest
{
    public partial class map_testPage : ContentPage
    {
        public map_testPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var position = new Position(27.3308284, -99.6013212); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "custom pin",
                Address = "custom detail info"
            };
            MyMap.Pins.Add(pin);
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(1)));
        }
        void Handle_Hybrid(object sender, System.EventArgs e)
        {
            MyMap.MapType = MapType.Hybrid;
        }
        void Handle_Street(object sender, System.EventArgs e)
        {
            MyMap.MapType = MapType.Street;
        }
        void Handle_Satellite(object sender, System.EventArgs e)
        {
            MyMap.MapType = MapType.Satellite;
        }
    }
}

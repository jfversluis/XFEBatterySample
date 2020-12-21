using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XFEBatterySample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BatteryLevel.Text = (Battery.ChargeLevel * 100).ToString() + "%";

            EnergySaver.Text = Battery.EnergySaverStatus.ToString();

            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            BatteryLevel.Text = (e.ChargeLevel * 100).ToString() + "%";
        }
    }
}

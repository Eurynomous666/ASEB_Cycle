using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Summary : MetroFramework.Forms.MetroForm
    {
        public Summary()
        {
            InitializeComponent();
            unit_data_kmPerhr();
        }

        public void unit_data_kmPerhr()
        {
            lblAverageSpeed.Text = System.Math.Round(First.averageSpeed, 2) + " Km/h";
            lblMaximumSpeed.Text = First.maxSpeed.ToString() + " Km/h";
            lblAverageHeartRate.Text = System.Math.Round(First.averageHeartRate, 2) + " bpm";
            lblMaximumHeartRate.Text = First.maxHeartRate.ToString() + " bpm";
            lblMinimumHeartRate.Text = First.minHeartRate.ToString() + " bpm";
            lblAveragePower.Text = System.Math.Round(First.averagePower, 2) + " W";
            lblMaximumPower.Text = First.maxPower.ToString() + " W";
            lblAverageAltitude.Text = System.Math.Round(First.averageAltitude, 2) + " m";
            lblMaximumAltitude.Text = First.maxAltitude.ToString() + " m";
            lblTotalDistance.Text = First.totalDistance.ToString() + " Km";
        }
        public void unit_data_mile()
        {
            lblAverageSpeed.Text = System.Math.Round(First.averageSpeedMiles, 2) + " miles";
            lblMaximumSpeed.Text = First.maxSpeedMiles.ToString() + " miles";
            lblAverageHeartRate.Text = System.Math.Round(First.averageHeartRate, 2) + " bpm";
            lblMaximumHeartRate.Text = First.maxHeartRate.ToString() + " bpm";
            lblMinimumHeartRate.Text = First.minHeartRate.ToString() + " bpm";
            lblAveragePower.Text = System.Math.Round(First.averagePower, 2) + " W";
            lblMaximumPower.Text = First.maxPower.ToString() + " W";
            lblAverageAltitude.Text = System.Math.Round(First.averageAltitudeMile, 2) + " Ft";
            lblMaximumAltitude.Text = System.Math.Round(First.maxAltitudeMile) + " Ft";
            lblTotalDistance.Text = First.totalDistanceMiles.ToString() + " miles";
        }


        private void radioMiles_CheckedChanged_1(object sender, EventArgs e)
        {
            unit_data_mile();
        }

        private void radioKm_CheckedChanged_1(object sender, EventArgs e)
        {
            unit_data_kmPerhr();
        }
    }
}

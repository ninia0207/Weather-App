using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather.PCL.Models.Abstractions;

namespace Weather_App
{
    public partial class Form2 : Form
    {
        public double Long { get; set; }
        public double Lati { get; set; }

        public IWeather WeatherInfo { get; set; }
        Form1 form1 = new Form1();
        public Form2(IWeather weatherInfo, double lng, double lat)
        {
            WeatherInfo = weatherInfo;
            InitializeComponent();
            longtitude.Text += lng;
            latitude.Text += lat;
            cityName.Text += WeatherInfo.Timezone;
            windSpeed.Text += WeatherInfo.Currently.WindSpeed;
            currentlySummary.Text += WeatherInfo.Currently.Summary;
            pictureBox1.ImageLocation = $@"C:\Users\ninia\OneDrive\Desktop\ninia's folder\it academy\.net\Weather App\Images\{WeatherInfo.Currently.Icon}.jpg";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            form1.Show();
            this.Hide();
        }
    }
}

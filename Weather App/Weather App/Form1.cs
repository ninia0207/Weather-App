using Configs.Abstractions;
using Configs.Implementations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather.PCL.Abstractions;
using Weather.PCL.Implementations;
using Weather.PCL.Models.Abstractions;
using Weather.PCL.Models.Enums;
using Weather.PCL.Models.Implementations;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Language[] LangArr { get; set; }
        public Form1()
        {
            InitializeComponent();
            Configuration langConfig = new Configuration("language.json");
            var language = langConfig.GetConfigs();
            LangArr = JsonConvert.DeserializeObject<Language[]>(language);
            languages.Items.AddRange(LangArr.Select(all=>all.Name).ToArray());
            languages.SelectedItem = LangArr.FirstOrDefault(o => o.Name == "English").Name;
        }

        public double Long { get; set; }
        public double Lati { get; set; }
        

        CultureSettings culture = new CultureSettings();

        IImagesService imageService = new ImagesService();

        private async void continueBtn_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;
            
            if (string.IsNullOrEmpty(Lng.Text) || string.IsNullOrEmpty(Lat.Text) || string.IsNullOrWhiteSpace(Lng.Text) || string.IsNullOrWhiteSpace(Lat.Text))
            {
                isEmpty = true;
                MessageBox.Show("Enter Longtitude and Latitude");
            }
            else
            {
                Long = double.Parse(Lng.Text);
                Lati = double.Parse(Lat.Text);
            }

            IConfiguration citConfiguration = new Configuration("cities.json");
            if (saveLocation.Checked)
            {
                City[] citiesConfig = new City[2];

                citiesConfig[0] = new City() { 
                    Id = 1,
                    CityName = "Tbilisi",
                    Lng = 123,
                    Lat = 321
                };

                citConfiguration.SetCityConfigs(citiesConfig);
            }

            if (celcius.Checked)
            {
                culture.ChoiceCorF(TempChoice.C);
            }
            else if(farenheit.Checked)
            {
                culture.ChoiceCorF(TempChoice.F);
            }
            else
            {
                isEmpty = true;
                MessageBox.Show("Choose Celcius or Farenheit");
            }

            

            var db = new DataBase();
            var weatherInfo = await db.GetWeatherDataByLngAndLat(Lati, Long, LangArr.FirstOrDefault(language => language.Name == languages.SelectedItem.ToString()).Code);

            var form2 = new Form2(weatherInfo, Long, Lati);

            if (!isEmpty)
            {
                form2.Show();
                this.Hide();
            }
        }


        private void Lng_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

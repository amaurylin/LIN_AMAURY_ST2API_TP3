using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;


namespace TP3_new
{
    public partial class Form1 : Form
    {
        string ApiKey = "c797631c5eddfebc5da5b8451261e31c";

        public Form1()
        {
            InitializeComponent();
        }

        double lon;
        double lat;


        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, ApiKey);
                var json = web.DownloadString(url);
                WeatherInfo.Root Info = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labelCity.Text = char.ToUpper(TBCity.Text[0])+ TBCity.Text.Substring(1);
                labelWeather.Text = Math.Round((Info.main.temp)-273.15).ToString();
                labelTempMax.Text = Math.Round((Info.main.temp_max) - 273.15).ToString();
                labelTempMin.Text = Math.Round((Info.main.temp_min) - 273.15).ToString();
                labelWind.Text = Info.wind.speed.ToString();
                labelSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                labelSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                labelLon.Text = Info.coord.lon.ToString();
                labelLat.Text = Info.coord.lat.ToString();

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }
        }

        DateTime convertDateTime(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();

            return day;
        }

        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={0}&exclude=current,minutely,alerts&appid={2}", lat, lon, ApiKey);
                var json = web.DownloadString(url);

                WeatherForecast.Root forecastInfo = JsonConvert.DeserializeObject<WeatherForecast.Root>(json);

                ForecastUserControl FUC;

                for (int i=0; i < 8; i++)
                {
                    FUC = new ForecastUserControl();
                    FUC.pictureWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.daily[i].weather[0].icon + ".png";
                    FUC.labelWeatherCondition.Text = forecastInfo.daily[i].weather[0].main;
                    FUC.labelWeatherDescription.Text = forecastInfo.daily[i].weather[0].description;
                    FUC.labelDT.Text = convertDateTime(forecastInfo.daily[i].dt).DayOfWeek.ToString();
                    FUC.labelForecastTempMax.Text = Math.Round((forecastInfo.daily[i].temp.max) - 273.15).ToString();
                    FUC.labelForecastTempMin.Text = Math.Round((forecastInfo.daily[i].temp.min) - 273.15).ToString();


                    FLP.Controls.Add(FUC);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

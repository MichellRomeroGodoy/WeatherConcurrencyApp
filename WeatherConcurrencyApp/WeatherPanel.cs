using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp
{
    public partial class WeatherPanel : UserControl
    {
        public OpenWeather selectWeath;
        public WeatherPanel(OpenWeather toStart)
        {
            InitializeComponent();
            selectWeath = toStart;
        }

        private void WeatherPanel_Load(object sender, EventArgs e)
        {
            DetailsWeather dw1 = new DetailsWeather();
            dw1.lblDetail.Text = "lon";
            dw1.lblDetailValue.Text = selectWeath.Coord.Lon.ToString();
            flpContent.Controls.Add(dw1);

            DetailsWeather dw2 = new DetailsWeather();
            dw2.lblDetail.Text = "lat";
            dw2.lblDetailValue.Text = selectWeath.Coord.Lat.ToString();
            flpContent.Controls.Add(dw2);

            DetailsWeather dw3 = new DetailsWeather();
            dw3.lblDetail.Text = "temp";
            dw3.lblDetailValue.Text = selectWeath.Main.Temp.ToString();
            flpContent.Controls.Add(dw3);

            DetailsWeather dw4 = new DetailsWeather();
            dw4.lblDetail.Text = "feels_like";
            dw4.lblDetailValue.Text = selectWeath.Main.Humidity.ToString();
            flpContent.Controls.Add(dw4);

            DetailsWeather dw5 = new DetailsWeather();
            dw5.lblDetail.Text = "temp_min";
            dw5.lblDetailValue.Text = selectWeath.Main.Temp_min.ToString();
            flpContent.Controls.Add(dw5);

            DetailsWeather dw6 = new DetailsWeather();
            dw6.lblDetail.Text = "temp_max";
            dw6.lblDetailValue.Text = selectWeath.Main.Temp_max.ToString();
            flpContent.Controls.Add(dw6);

            DetailsWeather dw7 = new DetailsWeather();
            dw7.lblDetail.Text = "pressure";
            dw7.lblDetailValue.Text = selectWeath.Main.Pressure.ToString();
            flpContent.Controls.Add(dw7);

            DetailsWeather dw8 = new DetailsWeather();
            dw8.lblDetail.Text = "humidity";
            dw8.lblDetailValue.Text = selectWeath.Main.Humidity.ToString();
            flpContent.Controls.Add(dw8);

            DetailsWeather dw9 = new DetailsWeather();
            dw9.lblDetail.Text = "visibility";
            dw5.lblDetailValue.Text = selectWeath.Visibility.ToString();
            flpContent.Controls.Add(dw9);

            DetailsWeather dw10 = new DetailsWeather();
            dw10.lblDetail.Text = "speed";
            dw10.lblDetailValue.Text = selectWeath.Wind.Speed.ToString();
            flpContent.Controls.Add(dw10);

            DetailsWeather dw11 = new DetailsWeather();
            dw11.lblDetail.Text = "sunrise";
            dw11.lblDetailValue.Text = selectWeath.Sys.Sunrise.ToString();
            flpContent.Controls.Add(dw11);

            DetailsWeather dw12 = new DetailsWeather();
            dw12.lblDetail.Text = "sunset";
            dw12.lblDetailValue.Text = selectWeath.Sys.Sunset.ToString();
            flpContent.Controls.Add(dw12);

            DetailsWeather dw13 = new DetailsWeather();
            dw13.lblDetail.Text = "timezone";
            dw13.lblDetailValue.Text = selectWeath.Timezone.ToString();
            flpContent.Controls.Add(dw13);
        }

        private void lblTemperature_Click(object sender, EventArgs e)
        {

        }
    }
}

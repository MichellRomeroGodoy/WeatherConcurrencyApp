using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrencyApp.Infrastructure.OpenWeatherClient;
using WeatherConcurrentApp.Domain.Entities;
using Newtonsoft.Json;
using System.IO;

namespace WeatherConcurrencyApp
{
    public partial class FrmMain : Form
    {
        public HttpOpenWeatherClient httpOpenWeatherClient;
        public OpenWeather openWeather;
        public countrys countys;
        /*JsonTextReader reader = new JsonTextReader(new StringReader('city.list.json'));*/
        StreamReader r = new StreamReader("./city.list.json");
        string jsonString;
        string elemento_looking  ;




        List<countrys> paises;




        public FrmMain()
        {
            httpOpenWeatherClient = new HttpOpenWeatherClient();
            InitializeComponent();
            jsonString = r.ReadToEnd();
            List<countrys> Modelo = JsonConvert.DeserializeObject<List<countrys>>(jsonString);
            Modelo.ForEach(ele =>
            {
                cmbListCity.Items.Add(ele.name);
            });
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(Request).Wait();
                if(openWeather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }




                WeatherPanel weatherPanel = new WeatherPanel(openWeather);
                flpContent.Controls.Add(weatherPanel);
            }
            catch (Exception eop )
            {
                MessageBox.Show(eop.ToString());
                
            }
           
        }

        public async Task Request()
        {
            
            openWeather = await httpOpenWeatherClient.GetWeatherByCityNameAsync(elemento_looking);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbListCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            elemento_looking = cmbListCity.SelectedItem.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

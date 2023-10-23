using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace hava_durumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "İstanbul")
            {
                string api = "fc1ebe2f4355d34ac0d82742295e40e8";
                string baglanti = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
                XDocument havadurumu = XDocument.Load(baglanti);
                var temperature = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                textBox1.Text = (temperature + "°");
            }
            if (comboBox1.SelectedItem.ToString() == "Elazığ")
            {
                string api = "fc1ebe2f4355d34ac0d82742295e40e8";
                string baglanti = "https://api.openweathermap.org/data/2.5/weather?q=elazig&mode=xml&lang=tr&units=metric&appid=" + api;
                XDocument havadurumu = XDocument.Load(baglanti);
                var temperature = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                textBox1.Text = (temperature + "°");
            }
            if (comboBox1.SelectedItem.ToString() == "Edirne")
            {
                string api = "fc1ebe2f4355d34ac0d82742295e40e8";
                string baglanti = "https://api.openweathermap.org/data/2.5/weather?q=edirne&mode=xml&lang=tr&units=metric&appid=" + api;
                XDocument havadurumu = XDocument.Load(baglanti);
                var temperature = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                textBox1.Text = (temperature + "°");
            }
        }
    }
}

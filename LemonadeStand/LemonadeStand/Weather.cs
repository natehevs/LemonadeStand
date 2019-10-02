using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        // member variables (HAS A)

        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public string predictedForecast;

        // constructor

        public Weather()
        {
            weatherConditions = new List<string>() { "sunny", "raining", "cloudy" };
            CreateWeather();
            CreateTemperature();
        }

        // member methods (CAN DO)

        private void CreateWeather()
        {
            Random random = new Random();
            int index = random.Next(weatherConditions.Count);
            condition = weatherConditions[index];
        }

        private void CreateTemperature()
        {
            Random random = new Random();
            temperature = random.Next(50, 90);
        }
    }
}

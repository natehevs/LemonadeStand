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
        public string predictedCondition;
        

        // constructor

        public Weather()
        {
            //string[] weatherArray = new string[3];

            
            weatherConditions = new List<string>() { "sunny", "raining", "cloudy" };
            CreateWeather();
            CreateTemperature();
        }

        

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

        private void CreatePredictedCondition()
        {
            Random random = new Random();
            int index = random.Next(weatherConditions.Count);
            predictedCondition = weatherConditions[index];
        }
    }
}

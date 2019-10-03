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

        // member methods (CAN DO)

        /*public void CreateWeather()
        {
            weatherArray[0] = "sunny";
            weatherArray[1] = "raining";
            weatherArray[2] = "cloudy";
            foreach (string item in weatherArray)
            {
                Console.WriteLine(item);
            }

            if (item = [0])
            {
                I need it to display sunny and then make sunny have higher chance for people to buy lemonade.
            }

            else if (item = [1])
            {
                I need it to display raining and then make it the lowest probability people would buy lemonade.
            }

            else
            {
                display cloudy and then make it average or medium probability people would want to buy lemonade.
            }
       }*/

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

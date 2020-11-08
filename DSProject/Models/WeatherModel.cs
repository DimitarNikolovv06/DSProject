using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSProject.Models
{
    public class WeatherModel
    {
        public string City { get; set; }

        public WeatherData Weather { get; set; }

    }


    public class WeatherData
    {
        public string name { get; set; }

        public WeatherMain main { get; set; }

        public WeatherWind wind { get; set; }

        public List<WeatherWeather> weather { get; set; }
    }

    public class WeatherMain
    {
        public double temp { get; set; }

        public double pressure { get; set; }

        public double humidity { get; set; }
    }

    public class WeatherWind
    {
        public double speed { get; set; }

        public double deg { get; set; }
    }

    public class WeatherWeather
    {
        public string main { get; set; }

        public string description { get; set; }

    }

}
using DSProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DSProject.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Index(string city)
        {
            var Model = new WeatherModel()
            {
                City = city
            };

            if (city != null && city != "")
            {

                const string key = "5afa920673234dc90e1018bf6f4ceeb2";
                string downloadString = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}";
                var data = new WebClient().DownloadString(downloadString);

                Model.Weather = JsonConvert.DeserializeObject<WeatherData>(data);
            }



            return View(Model);
        }
    }
}
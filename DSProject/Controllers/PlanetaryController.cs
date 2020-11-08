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
    public class PlanetaryController : Controller
    {
        // GET: Planetary
        public ActionResult Index()
        {

            string key = "QyoFXfC8fOd9LyCbGjyCV1PecgyC830y47OrhKFG";
            string downloadString = $"https://api.nasa.gov/planetary/apod?api_key={key}";
            var data = new WebClient().DownloadString(downloadString);

            var Model = new PlanetaryModel();
            Model = JsonConvert.DeserializeObject<PlanetaryModel>(data);


            return View(Model);
        }
    }
}
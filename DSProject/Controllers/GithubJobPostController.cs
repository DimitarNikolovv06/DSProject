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
    public class GithubJobPostController : Controller
    {
        // GET: GithubJobPost
        public ActionResult Index(string searchParam)
        {

            var Model = new GithubJobPostModel()
            {
                SearchParam = searchParam
            };

            if(searchParam != null && searchParam != "")
            {
                string url = $"https://jobs.github.com/positions.json?search={searchParam}";
                var data = new WebClient().DownloadString(url);

                Model.data = JsonConvert.DeserializeObject<List<GithubJobPostData>>(data);
            }



            return View(Model);
        }
    }
}
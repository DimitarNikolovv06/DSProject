using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSProject.Models
{
    public class GithubJobPostModel
    {

        public string SearchParam { get; set; }
       public List<GithubJobPostData> data { get; set; }

    }

    public class GithubJobPostData
    {

        public string type { get; set; }

        public string url { get; set; }

        public string company { get; set; }

        public string location { get; set; }

        public string title { get; set; }

        public string description { get; set; }     
    }
}
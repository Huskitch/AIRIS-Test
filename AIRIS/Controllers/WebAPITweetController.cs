using AIRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIRIS.Controllers
{
    public class WebAPITweetController : ApiController
    {
        [Route("api/WebAPIMethod")]
        [HttpPost]
        public string WebAPIMethod()
        {
            return "This is a web api method called using json";
        }
    }
}

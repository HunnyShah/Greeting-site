using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Question1.Controllers
{
    public class GreetingController : ApiController
    {
        public string Get()
        {
            string greet = "Hello World!";
            return greet;
        }
    }
}

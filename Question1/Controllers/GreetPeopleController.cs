using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Question1.Controllers
{
    public class GreetPeopleController : ApiController
    {
        public string Get( int id)
        {
            var greet = "Greetings to " + id  +" people!";
            return greet;
        }
    }
}

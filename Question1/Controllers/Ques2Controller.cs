using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Question1.Controllers
{
    public class Ques2Controller : ApiController
    {
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Question1.Controllers
{
    public class OperatorController : ApiController
    {
        public int Get(int id)
        {
            id = 10 + 20 - 5 * 4 / 2;
            return id;
        }
    }
}

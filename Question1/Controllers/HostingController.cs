using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Question1.Controllers
{
    public class HostingController : ApiController
    {
        public IEnumerable<string> Get(int id)
        {
            double fort_night = id / 14;
            int fnight = (int)fort_night + 1;
            double cost = fnight * 5.50;
            double Hst = fnight * 0.72;
            double Totalcost = Hst + cost;
            return new string[] { fnight +" fornights at $5.50/FN= $"+cost+" CAD",
                 "HST 13% = $"+ Hst +" CAD",
                "Total=$"+ Totalcost+" CAD"};

        }
    }
}

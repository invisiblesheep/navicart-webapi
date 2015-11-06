using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Navicart.Controllers
{
    public class MapController : ApiController
    {

        // GET api/map
        [Route("api/map")]
        public IEnumerable<string> GetMap(int id)
        {
            return new string[] { "value1", "value2" };
        }
    }
}

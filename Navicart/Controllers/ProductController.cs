using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Navicart.Controllers
{
    public class ProductController : ApiController
    {

        // GET api/product/id
        [Route("api/product/id")]
        public string Get()
        {
            return "value";
        }

        // POST product/search/nimi
    }
}

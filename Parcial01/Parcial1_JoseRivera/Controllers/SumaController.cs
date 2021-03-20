using Parcial1_JoseRivera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Parcial1_JoseRivera.Controllers
{
    public class SumaController : ApiController
    {
        [HttpPost]
        [Route("Add")]
        public int Add(int num_a, int num_b)
        {
            return num_a + num_b;
        }
    }
}

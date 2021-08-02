using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BasicASP.NETMvc.Controllers
{
    [AllowAnonymous]
    //basic points 12 Please change "api" to made this controller root path is "api/route"
    [RoutePrefix("api/route")]
    public class RouteController : ApiController
    {
 
        //basic points 13 Change "xxx" and requet "/api/route/index" by Get
        [Route("index")]
        public string Gete()
        {
            return "hello world";
        }
        [HttpGet]
        [Route("index2")]
        public string Post()
        {
            return "hello world";
        }
    }
}
using Demo.WebApi.Models;
using System;
using System.Web.Http;

namespace Demo.WebApi.Controllers
{
    public class HelloController : ApiController
    {
        public HelloResponse Get(string id)
        {
            return new HelloResponse { Result = "Hello, " + id };
        }

        [Route("api/time/{id}")]
        public TimeResponse GetTime(string id)
        {
            string message = string.Format("Hello, {0}. The time is {1}", id, DateTime.Now);
            return new TimeResponse { Result = message };
        }
    }
}

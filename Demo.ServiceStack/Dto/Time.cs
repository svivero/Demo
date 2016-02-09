using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.ServiceStack.Dto
{
    [Route("/time/{Name}")]
    public class Time
    {
        public string Name { get; set; }
    }

    public class TimeResponse
    {
        public string Result { get; set; }
    }
}
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.ServiceStack.Dto
{
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }
}
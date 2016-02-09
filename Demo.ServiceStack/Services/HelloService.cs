using ServiceStack;
using Demo.ServiceStack.Dto;
using System;

namespace Demo.ServiceStack.Services
{
    public class HelloService : Service
    {
        public object Get(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
        
        public TimeResponse Get(Time request)
        {
            string message = string.Format("Hello, {0}. The time is {1}", request.Name, DateTime.Now);
            return new TimeResponse { Result = message };
        }
    }
}
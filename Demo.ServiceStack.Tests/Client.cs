using ServiceStack;
using System;

namespace Demo.ServiceStack.Tests
{
    public class Client
    {
        private Client() { }

        public static JsonServiceClient Instance()
        {
            return new JsonServiceClient("http://localhost:64943/");
        }
    }
}

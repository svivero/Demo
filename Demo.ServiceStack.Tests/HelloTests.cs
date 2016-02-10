using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceStack;
using Demo.ServiceStack.Dto;

namespace Demo.ServiceStack.Tests
{
    [TestClass]
    public class HelloTests
    {
        private JsonServiceClient client = Client.Instance();

        [TestMethod]
        public void ServiceStack_GetHelloResponse()
        {
            HelloResponse response = client.Get<HelloResponse>(new Hello { Name = "steve" });
            Assert.AreEqual("Hello, steve", response.Result);
        }

        [TestMethod]
        public void ServiceStack_GetTimeResponse()
        {
            TimeResponse response = client.Get<TimeResponse>(new Time { Name = "steve" });
            Assert.AreNotEqual("Hello, steve", response.Result);
        }
    }
}

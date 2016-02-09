using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using Demo.WebApi.Models;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Demo.WebApi.Tests
{
    [TestClass]
    public class HelloTests
    {
        private HttpClient client = new HttpClient();

        [TestInitialize]
        public void Init()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49352/");
        }

        [TestMethod]
        public void WebApi_GetHelloResponse()
        {
            HttpResponseMessage response = client.GetAsync("api/hello/steve").Result;
            HelloResponse product = response.Content.ReadAsAsync<HelloResponse>().Result;
            Assert.AreEqual("Hello, steve", product.Result);
        }

        [TestMethod]
        public void WebApi_GetTimeResponse()
        {
            HttpResponseMessage response = client.GetAsync("api/time/steve").Result;
            TimeResponse product = response.Content.ReadAsAsync<TimeResponse>().Result;
            Assert.AreNotEqual("Hello, steve", product.Result);
        }
    }
}

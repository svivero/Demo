using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using ServiceStack;
using Demo.ServiceStack.Services;

namespace Demo.ServiceStack
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public class AppHost : AppHostBase
        {
            //Tell ServiceStack the name of your application and where to find your services
            public AppHost() : base("Hello Web Services", typeof(HelloService).Assembly) { }

            public override void Configure(Funq.Container container)
            {
                //register any dependencies your services use, e.g:
                //container.Register<ICacheClient>(new MemoryCacheClient());
            }
        }

        //Initialize your application singleton
        protected void Application_Start(object sender, EventArgs e)
        {
            AppHost host = new AppHost();
            host.SetConfig(new HostConfig
            {
                DefaultContentType = MimeTypes.Json
            });
            host.Init();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace WebApplication2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);

            HttpConfiguration configuration = new HttpConfiguration();
            configuration.MessageHandlers.Add(new FooHandler());
            configuration.MessageHandlers.Add(new BarHandler());
            configuration.MessageHandlers.Add(new BazHandler());
            GlobalConfiguration.Configuration.MessageHandlers.Add(new MyHttpServer(configuration));
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }
    }
}
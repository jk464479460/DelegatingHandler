using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication2
{
    public class MyHttpServer: HttpServer
    {
        public MyHttpServer(HttpConfiguration confi) : base(confi) { }

        public new void Initialize()
        {
            base.Initialize();
        }
    }
}
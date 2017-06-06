using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Text;

namespace WebApplication2.Controllers
{
    public class TestController : ApiController
    {
        private StringBuilder _bu = null;
        [HttpGet]
        [Route("Test2")]
        public IHttpActionResult Index()
        {
            _bu = new StringBuilder();
          

          

            return Ok(_bu.ToString());
        }

        void PrintMessageHandlerChain(DelegatingHandler handler)
        {
            System.Web.HttpContext.Current.Response.Write(handler.GetType().Name);
            while (null != handler.InnerHandler)
            {
                _bu.Append(" => " + handler.InnerHandler.GetType().Name);
                handler = handler.InnerHandler as DelegatingHandler;
                if (null == handler)
                {
                    break;
                }
            }
            _bu.Append("<br/>");
        }
    }
}

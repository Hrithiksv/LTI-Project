using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace FarmerScheme
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Removing XML formater
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

            ////Removing reference looping while serialization
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling =
               Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}

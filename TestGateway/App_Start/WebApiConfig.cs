using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using NLog;
using TestGateway.Filters;


namespace TestGateway
{
    public static class WebApiConfig
    {

        private static Logger log = LogManager.GetCurrentClassLogger();
        public static void Register(HttpConfiguration config)
        {
            
            log.Info("INIT");
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Filters.Add(new ValidationFilter());
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            
        }
    }
}

using System;
using System.IO;
using System.Web.Http;

namespace apiBeer
{
    public static class WebApiConfig
    {
        public static string BreweryDbKey;
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            BreweryDbKey = "SECRETKEY";

        }
    }
}

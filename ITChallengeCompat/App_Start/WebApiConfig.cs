using ITChallengeCompat.App_Start;
using ITChallengeCompat.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ITChallengeCompat
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.DependencyResolver = new MyDependencyResolver();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

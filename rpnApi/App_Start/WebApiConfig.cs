using System.Collections.Generic;
using System.Web.Http;

namespace rpnApi
{
    public static class WebApiConfig
    {
        //public static Stack<decimal> _stack;

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
            );


        }
    }
}

using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace gmstore1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            var cors = new EnableCorsAttribute("https://localhost:44397", "*", "*");
            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "CartApi",
                routeTemplate: "api/cart/{action}",
                defaults: new { controller = "CartController" }
            );


        }
    }
}

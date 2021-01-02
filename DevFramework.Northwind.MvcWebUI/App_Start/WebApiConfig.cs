using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.UI.WebControls;
using RouteParameter = System.Web.Http.RouteParameter;

namespace DevFramework.Northwind.MvcWebUI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
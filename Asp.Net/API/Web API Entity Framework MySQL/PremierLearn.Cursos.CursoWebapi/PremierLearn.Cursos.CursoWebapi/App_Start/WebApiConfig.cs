using Newtonsoft.Json;
using PremierLearn.Cursos.CursoWebapi.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PremierLearn.Cursos.CursoWebapi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Re‌​ferenceLoopHandling = ReferenceLoopHandling.Ignore;

            //config.Routes.MapHttpRoute(
            //    name: "Livros",
            //    routeTemplate: "api/editoras/{idEditora}/livros",
            //    defaults: new { controller = "Livros" }
            //    );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new ValidationExceptionFilterAttribute());
        }
    }
}

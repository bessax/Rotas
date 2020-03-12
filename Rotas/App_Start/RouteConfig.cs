using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Criando uma URL amigável para noticias - Aula 47 e 48.
            routes.MapRoute(
                name: "Todas as noticias",
                url:"noticias/",
                defaults: new {controller="Home",action="TodasAsNoticias"}

                );

            routes.MapRoute(
                name: "Categoria específica",
                url: "noticias/{categoria}",
                defaults: new { controller = "Home", action = "MostraCategoria" }

                );

            routes.MapRoute(
                name: "Mostras noticias",
                url: "noticias/{categoria}/{titulo}-{noticiaId}",
                defaults: new { controller = "Home", action = "MostraNoticia" }

                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

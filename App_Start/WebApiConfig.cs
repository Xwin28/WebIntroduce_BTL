﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BTL_ASP
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Routes.MapHttpRoute(

                name: "DefaultApi",

                routeTemplate: "api/{controller}/{action}/{id}",

                defaults: new { id = RouteParameter.Optional }

            );

            config.Routes.MapHttpRoute(

                name: "MultiGet",

                routeTemplate: "api/{controller}/{action}/{A}/{B}"

            );



        }
    }
}

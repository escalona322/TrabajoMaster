using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Filters
{
    public class AuthorizeJugadoresAttribute : AuthorizeAttribute,
        IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string controller =
                context.RouteData.Values["controller"].ToString();
            string action =
                context.RouteData.Values["action"].ToString();        

            context.HttpContext.Response.Cookies.Append("controller", controller);
            context.HttpContext.Response.Cookies.Append("action", action);

            var user = context.HttpContext.User;
            if (user.Identity.IsAuthenticated == false)
            {
                ITempDataProvider provider = context.HttpContext
                    .RequestServices.GetService(typeof(ITempDataProvider))
                    as ITempDataProvider;

                var TempData = provider.LoadTempData(context.HttpContext);

                TempData["controller"] = controller;
                TempData["action"] = action;
                context.Result = this.GetRouteRedirect("Managed", "LogIn");
            }
            else
            {
            }
        }



        private RedirectToRouteResult GetRouteRedirect
                (string controller, string action)
        {
            RouteValueDictionary ruta =
                new RouteValueDictionary(new
                {
                    controller = controller,
                    action = action
                });
            RedirectToRouteResult result =
                new RedirectToRouteResult(ruta);
            return result;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class BaseLogin: Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var res = Session["login"];
            if (res==null)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { Controller="Login", Action="Index",Area="Admin"}));


            }
            base.OnActionExecuting(filterContext);
        }

    }
}
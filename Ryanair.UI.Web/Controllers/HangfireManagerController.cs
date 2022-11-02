using Hangfire.Annotations;
using Hangfire.Dashboard;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ryanair.UI.Web.Controllers
{
    public class HangfireManagerController : IDashboardAuthorizationFilter
    {

        //public IActionResult Index()
        //{
        //    var UserToken = HttpContext.Session.GetString("UserToken");
        //    if (User.Identity.IsAuthenticated && !String.IsNullOrEmpty(UserToken))
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return Redirect("/UserAccount/Login");
        //    }
        //}
        public bool Authorize([NotNull] DashboardContext context)
        {
            var httpContext = context.GetHttpContext();
            if (httpContext.User.Identity.IsAuthenticated)
            {

            }
            // Allow all authenticated users to see the Dashboard (potentially dangerous).
            return httpContext.User.Identity.IsAuthenticated;
        }
    }
}

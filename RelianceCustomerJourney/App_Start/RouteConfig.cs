using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RelianceCustomerJourney
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{SrNo}",
                defaults: new { controller = "Home", action = "Index", SrNo = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "RelianceCustomerJourney",
                url: "{controller}/{action}/{SrNo}",
                defaults: new { controller = "RelianceCustomerJourney", action = "PreSrDetails", SrNo = UrlParameter.Optional }
            );
        }
    }
}

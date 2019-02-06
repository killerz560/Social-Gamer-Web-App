using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using GamersForums.Models;

namespace GamersForum
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static ForumArticleRepository mainForum;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            mainForum = new ForumArticleRepository(@"C:\Users\zacha\source\repos\GamersForum\GamersForum\forumFiles", "forum.dat");
        }
    }
}

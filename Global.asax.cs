using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TrackerLibrary;

namespace TournamentTrackerMVCUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //intialize the database and text file connections
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.sql);
            //TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);
        }
    }
}

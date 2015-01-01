using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using ChatApplication.Migrations;
using ChatApplication.Models;
using Autofac.Integration.Mvc;
using ChatApplication.App_Start;

namespace ChatApplication
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start(object sender,EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            IocConfig.RegisterDependencies();
             WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ChatContext,Configuration>());
            using (ChatContext context = new ChatContext())
            {
                context.Database.Initialize(false);
            }
            
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using VI_Home2.App_Start;

namespace VI_Home2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            //AreaRegistration.RegisterAllAreas();
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Code that runs on application startup
            Application["SiteVisitedCounter"] = 0;
            
        }
        protected void Session_End(object sender, EventArgs e)
        {
          
        }

    
        protected void Application_End(object sender, EventArgs e)
        {
          
        }
        protected void Session_Start(object sender, EventArgs e)
        {
         
        
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Application.Lock();
            Application["SiteVisitedCounter"] = Convert.ToInt32(Application["SiteVisitedCounter"]) + 1;
            Application.UnLock();
        }
      
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

    }
}
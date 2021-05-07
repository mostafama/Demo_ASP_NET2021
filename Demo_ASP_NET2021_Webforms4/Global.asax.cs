using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Demo_ASP_NET2021_Webforms4
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_Error(object sender, EventArgs e)
        {
            string url = Request.Path;
            Exception ex = Server.GetLastError();
            string msg = "compose some error message using ex/ url.<br> " + ex.Message;
            EventLog log = new EventLog();
            log.Source = "Application Name";
            //log.WriteEntry(msg, EventLogEntryType.Error);
            //Server.Transfer("~/Error.aspx");
        }

    }
}
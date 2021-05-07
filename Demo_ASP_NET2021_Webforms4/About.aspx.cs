using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_ASP_NET2021_Webforms4
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.NameLabelText = "Hello All.";
            //throw new Exception("Test Exception");

            
            this.Trace.Write("Load event", "This is a trace writing");
            this.Trace.Warn("Load event", "This is a trace warning");
        }

        protected void likeLnk_Click(object sender, EventArgs e)
        {
            this.Trace.Write("Like event", "The user liked the page.");
        }

        // Page level error handling 
        //protected void Page_Error(object sender, EventArgs e)
        //{

        //    Server.Transfer("~/Error.aspx");
        //}

    }
}
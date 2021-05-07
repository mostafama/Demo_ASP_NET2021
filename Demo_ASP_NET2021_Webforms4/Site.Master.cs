using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_ASP_NET2021_Webforms4
{
    public partial class SiteMaster : MasterPage
    {
        public string NameLabelText
        {
            get { return NameLabel.Text; }
            set { NameLabel.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
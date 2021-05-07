using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_ASP_NET2021_WebForms1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sayhelloBtn_Click(object sender, EventArgs e)
        {            
            helloLbl.Text = "Hello " + nameTxt.Text;
        }

        protected void howareyouBtn_Click(object sender, EventArgs e)
        {
            fineLbl.Text = "I'm fine. How about you ?";
        }
    }
}
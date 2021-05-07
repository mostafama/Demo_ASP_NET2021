using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_ASP_NET2021_Webforms4
{
    public partial class Error : System.Web.UI.Page
    {
        public string ErrorMessage { get { return errorMsg.Text;  } set { errorMsg.Text = value; } }
        protected void Page_Load(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            //test for type of exception if necessary
            
            if(ex != null)
                errorMsg.Text = ex.Message;
            Server.ClearError();
        }
    }
}
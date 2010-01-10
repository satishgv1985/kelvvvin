using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Kelvin
{
    public partial class AdminDashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserId"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void lbtnAddUsers_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("~/Users/AddUser.aspx");
        }

        protected void lbtnAddGroups_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("~/Groups/AddGroup.aspx");
        }
    }
}

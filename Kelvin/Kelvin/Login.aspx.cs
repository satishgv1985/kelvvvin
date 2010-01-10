using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kelvin.Framework;
using Kelvin.DAO;
using Kelvin.BO;
using Kelvin.Entities;

namespace Kelvin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblUserLogout.Visible = false;
            lblInvalidError.Visible = false;
            tbLoginName.Focus();
            if (!IsPostBack)
            {
                //lblUserLogout.Visible = false;

                if (Convert.ToBoolean(Session["IsUserLogout"]))
                {
                    //lblUserLogout.Visible = true;
                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = userLoginValidation(tbLoginName.Text, tbPassword.Text);
            if (success)
            {
                Group userGroupDetails = GroupBO.GetGroupDetailsByUserId(Convert.ToInt32(Session["UserId"]));
                if (userGroupDetails.GroupName.ToLower() == "admin")
                {
                    Session["IsAdminUser"] = true;
                }
                else
                {
                    Session["IsAdminUser"] = false;
                }
                Response.Redirect("FacilityHome.aspx");
                //Server.Transfer("Default.aspx");
            }
            else
            {
                lblInvalidError.Visible = true;
                Session.RemoveAll();
            }
        }

        private bool userLoginValidation(string loginName, string password)
        {
            string passwordHash = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");

            User userLogged = UserBO.ValidateUserLogin(DBClass.Sanitize(loginName), DBClass.Sanitize(passwordHash));

            if (userLogged.ValidUser)
            {
                Session["UserId"] = userLogged.UserId;
                Session["UserName"] = userLogged.UserName;
                Session["UserFName"] = userLogged.UserFName;
                Session["UserLName"] = userLogged.UserLName;
            }

            return userLogged.ValidUser;
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            tbLoginName.Text = "";
            tbPassword.Text = "";
        }
    }
}

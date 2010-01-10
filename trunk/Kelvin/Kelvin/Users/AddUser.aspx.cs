using System;
using System.Collections;
using System.Collections.Generic;
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
using Kelvin.Entities;
using Kelvin.BO;
namespace Kelvin.Users
{
    public partial class AddUser : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserId"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                UserBO userBussiness = new UserBO();
                ddlGroups.DataSource = userBussiness.GetGroups();
                ddlGroups.DataTextField = "GroupName";
                ddlGroups.DataValueField = "GroupId";
                ddlGroups.DataBind();
                
            }



        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clearControls();
            // Server.Transfer("../Default.aspx");

        }

        protected void lbtnApplication_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("../Default.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UserBO userBussiness = new UserBO();
            int userID = 1;
            int returnValue;
            int groupID = Convert.ToInt32(ddlGroups.SelectedValue.ToString());
            Kelvin.Entities.User instUser = new User();
            instUser.UserName = txtUserName.Text.Trim();
            instUser.UserFName = txtUserFName.Text.Trim();
            instUser.UserLName = txtUserLName.Text.Trim();
            instUser.Password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text.Trim().ToString(), "MD5");
            instUser.UserAddedBy = userID;
            instUser.UserAddedOn = System.DateTime.Now;

            Boolean isDuplicateFound = checkDuplicate();

            if (isDuplicateFound)
            {
                lblStatus.Text = "UserName already exists.";
            }
            else
            {
                returnValue = userBussiness.InsertUser(instUser, groupID);
                if (returnValue > 1)
                {
                    lblStatus.Text = "Record Inserted Successfully.";
                    clearControls();
                }
                else
                {
                    lblStatus.Text = "Record not Inserted Successfully.";
                }
            }
        }

        private Boolean checkDuplicate()
        {
            UserBO userBussiness = new UserBO();
            Boolean duplicateFound = false;
            List<User> usersList = userBussiness.GetUserNameByPrefix(txtUserName.Text.Trim());
            if (usersList != null)
            {
                foreach (Kelvin.Entities.User userCheck in usersList)
                {
                    if (userCheck.UserName.Trim() == txtUserName.Text.Trim())
                    {
                        duplicateFound = true;
                        break;
                    }
                    else
                    {
                        duplicateFound = false;
                    }
                }
            }
            else
            {
                duplicateFound = false;
            }
            return duplicateFound;
        }

        private void clearControls()
        {
            txtPassword.Text = string.Empty;
            txtUserFName.Text = string.Empty;
            txtUserLName.Text = string.Empty;
            txtUserName.Text = string.Empty;
        }
    }

}

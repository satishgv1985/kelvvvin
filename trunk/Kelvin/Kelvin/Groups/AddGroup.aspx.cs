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
using Kelvin.BO;
using Kelvin.Entities;
namespace Kelvin.Groups
{
    public partial class AddGroup : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, System.EventArgs e)
        {
            GroupBO groupBL = new GroupBO();
            Group instGroup = new Group();
            int returnValue = 0;

            instGroup.CanAdd = chkCanAdd.Checked;
            instGroup.CanDelete = chkCanDelete.Checked;
            instGroup.CanUpdate = chkUpDate.Checked;
            instGroup.CanView = chkCanView.Checked;
            instGroup.GroupName = txtGroupName.Text.Trim();
            instGroup.GroupDescription = txtGroupDescription.Text.Trim();
            instGroup.GroupAddedBy = 1;

            returnValue = groupBL.InsertGroup(instGroup);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, System.EventArgs e)
        { 

        }
    }
}

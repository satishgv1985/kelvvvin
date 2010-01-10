using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using Kelvin.DAO;
using Kelvin.BO;
using Kelvin.Entities;

namespace Kelvin
{
    public partial class Site : System.Web.UI.MasterPage
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


                //BindRepeater();
                //if (Session["TestMasterId"] != null && Session["TestMasterId"].ToString() != "")
                BindInnerRepeater(1);

                // Session.RemoveAll();
                //BindRepeater();
                if (Session["TestMasterId"] != null && Session["TestMasterId"] != "")
                    BindInnerRepeater(Convert.ToInt32(Session["TestMasterId"]));


                if (Convert.ToBoolean(Session["IsAdminUser"]))
                {
                    lbAdminLink.Visible = true;
                }
                else
                {
                    lbAdminLink.Visible = false;
                }

                // lblLoggedUserName.Text = Convert.ToString(Session["UserFName"]) + " " + Convert.ToString(Session["UserLName"]);

                //lblLoggedUserName.Text = Convert.ToString(Session["UserFName"]) + " " + Convert.ToString(Session["UserLName"]);


            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Init(object sender, EventArgs e)
        {
            //innerRepeater_command(null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void repeaterTabs_command(object sender, RepeaterCommandEventArgs e)
        {
            Button btnInner = (Button)e.Item.FindControl("tabsContent");
            Session["TestMasterId"] = Convert.ToInt32(btnInner.CommandName);

            BindInnerRepeater(Convert.ToInt32(btnInner.CommandName));

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="testMasterId"></param>
        private void BindInnerRepeater(int testMasterId)
        {
            //TestBO testBL = new TestBO();
            innerRepeater.DataSource = TestBO.GetTestsDetailsByTestMasterId(testMasterId);
            innerRepeater.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void innerRepeater_command(object sender, RepeaterCommandEventArgs e)
        {
            if (innerRepeater != null)
            {
                Button btnInner = (Button)e.Item.FindControl("innerTabsContent");
                List<TestProcedure> lstTestProcedures = TestProceduresBO.GetTestProcedureListByTestId(Convert.ToInt32(btnInner.CommandName));
                Session["TestProcedures"] = lstTestProcedures;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session["IsUserLogout"] = "true";
            Server.Transfer("HomePage.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbAdminLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Groups/AddGroup.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbTestMaster_Click(object sender, CommandEventArgs e)
        {
            int testMasterId = Convert.ToInt32(e.CommandArgument);
            BindInnerRepeater(testMasterId);
            Session["innerRepeater"] = testMasterId;

        }
    }

}

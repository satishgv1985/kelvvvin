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
using System.Xml;
namespace Kelvin.MasterPages
{
    public partial class LoggedIn : System.Web.UI.MasterPage
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
                //if (Session["TestMasterId"] != null && Session["TestMasterId"].ToString() != "")
                BindInnerRepeater(1);

                // Session.RemoveAll();
                //BindRepeater();
                if (Session["TestMasterId"] != null && Convert.ToString(Session["TestMasterId"]) != "")
                    BindInnerRepeater(Convert.ToInt32(Session["TestMasterId"]));


                if (Convert.ToBoolean(Session["IsAdminUser"]))
                {
                    hlAdminLink.Visible = true;
                }
                else
                {
                    hlAdminLink.Visible = false;
                }
                loginWelcomeName.Text = " Dr. " + Convert.ToString(Session["UserFName"]) + " " + Convert.ToString(Session["UserLName"]);
                //lblLoggedUserName.Text = Convert.ToString(Session["UserFName"]) + " " + Convert.ToString(Session["UserLName"]);

                //lblLoggedUserName.Text = Convert.ToString(Session["UserFName"]) + " " + Convert.ToString(Session["UserLName"]);
                string requestUrl = Request.Url.ToString().ToLower();
                if (requestUrl.Contains("facility") || requestUrl.Contains("addpatients") || requestUrl.Contains("patient"))
                {
                    liFacilityHome.Attributes.Add("class", "active");
                }
                else if (requestUrl.Contains("default"))
                {
                    liDiagnostics.Attributes.Add("class", "active");
                }
                else if (requestUrl.Contains("admindashboard") || requestUrl.Contains("adduser") || requestUrl.Contains("addgroup"))
                {
                    liAdminLink.Attributes.Add("class", "active");
                }

            }
            //showTab();


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
        protected void lbTestMaster_Click(object sender, CommandEventArgs e)
        {
            int testMasterId = Convert.ToInt32(e.CommandArgument);
            BindInnerRepeater(testMasterId);
            Session["innerRepeater"] = testMasterId;

        }

        /// <summary> 
        /// This sub function is used to show the current tab (MPL / Diagnostic test...) 
        /// </summary> 
        /// <remarks>AUTHOR: Vishwanatha Reddy on 04/08/2009</remarks> 
        private void showTab()
        {
            string url = string.Empty;
            XmlDocument xmlDocTabs = null;
            XmlNodeList xmlNodes = null;
            string currentTab = string.Empty;

            try
            {
                //Set Xml document object. 
                xmlDocTabs = new XmlDocument();
                xmlDocTabs.Load(Server.MapPath("~/App_Data/Tabs.xml"));
                xmlNodes = xmlDocTabs.SelectNodes("/Tabs/Page");

                //Fetch the current tab name from XML document. 
                foreach (XmlNode eachXmlNode in xmlNodes)
                {
                    url = eachXmlNode.Attributes.GetNamedItem("URL").Value;
                    if (url.ToUpper().Trim() == Page.ToString().ToUpper().Trim())
                    {
                        currentTab = eachXmlNode.Attributes.GetNamedItem("Tab").Value;
                        break; // TODO: might not be correct. Was : Exit For 
                    }
                }

                //Clear the class attribute 
                //liFacilityHome.Attributes.Remove("class");
                //liDiagnostics.Attributes.Remove("class");




                //Add the class attribute based on the current page's module. 
                switch (currentTab)
                {
                    case "DIAGNOSTICS":
                        liDiagnostics.Attributes.Add("class", "active");
                        break;
                    case "FACILITYHOME":
                        liFacilityHome.Attributes.Add("class", "active");
                        break;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

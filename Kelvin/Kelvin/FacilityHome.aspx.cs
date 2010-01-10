using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kelvin
{
    public partial class FacilityHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserId"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                if (Convert.ToBoolean(Session["IsAdminUser"]))
                {
                    lbtnAdmin.Visible = true;
                    ibtnAdmin.Visible = true;
                }
                else
                {
                    lbtnAdmin.Visible = false;
                    ibtnAdmin.Visible = false;
                }
            }
        }

        //protected void BrowsePatientRecords_Click(object sender, ImageClickEventArgs e)
        //{
        //    Response.Redirect("SelectPatient.aspx");
        //}

        protected void BrowsePatientRecords_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectPatient.aspx");
        }

        protected void lbtnAdmin_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("AdminDashBoard.aspx");
        }
        protected void ibtnAdmin_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("AdminDashBoard.aspx");
        }

        protected void lbtnAddnePatients_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("Patients/AddPatients.aspx");
        }
    }
}

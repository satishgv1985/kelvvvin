using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kelvin.BO;
namespace Kelvin.Patients
{
    public partial class SelectPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PatientsBO ptobj = new PatientsBO();
                gvSearchPatientResults.DataSource = ptobj.SelectPatients("");
                gvSearchPatientResults.DataBind();
            }
        }
        protected void btnSearchPatient_Click(object sender, EventArgs e)
        {
            PatientsBO ptobj = new PatientsBO();
            gvSearchPatientResults.DataSource = ptobj.SelectPatientsByNameSsn(tbSearchPatientText.Text.Trim().ToString(),txtSSn.Text.Trim());
            gvSearchPatientResults.DataBind();

        }

        protected void gvSearchPatientResults_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Visible = false;
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Visible = false;
            }
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {

            PatientsBO ptobj = new PatientsBO();
            gvSearchPatientResults.DataSource = ptobj.SelectPatients("");
            gvSearchPatientResults.DataBind();
            //gvSearchPatientResults.Visible = true;
        }

        protected void gvSearchPatientResults_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSearchPatientResults.PageIndex = e.NewPageIndex;
            PatientsBO ptobj = new PatientsBO();
            gvSearchPatientResults.DataSource = ptobj.SelectPatients("");
            gvSearchPatientResults.DataBind();
        }
    }
}

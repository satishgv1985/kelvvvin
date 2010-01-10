using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Kelvin.BO;
using Kelvin.Entities;

namespace Kelvin
{
    public partial class PatientRecord : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int patientId = 0;



            if (Request.QueryString["pid"] != null)
            {
                patientId = Convert.ToInt32(Request.QueryString[0]);
                Session["patientId"] = patientId;
            }
            else if (Session["patientId"] != null && patientId == 0)
            {
                patientId = Convert.ToInt32(Session["patientId"]);
            }

            if (patientId == 0)
            {
                if (Session["patientId"] == null && Request.QueryString["pid"] == null)
                    Response.Redirect("SelectPatient.aspx");
            }

            TestProceduresBO testBL = new TestProceduresBO();
            Patient pt = testBL.GetPatientFullInfo(patientId);
            if (pt.PatientLastName == string.Empty)
            {
                if (pt.DOB == DateTime.MinValue)
                    lbPatientDOB.Text = "";
            }
            else
            {
                lblPatientName.Text = pt.PatientLastName+" "+ pt.PatientFirstName;
                if (pt.DOB == DateTime.MinValue)
                    lbPatientDOB.Text = "";
                else
                    lbPatientDOB.Text = Convert.ToString(pt.DOB.ToShortDateString());

                lblPatientBloodGroup.Text = pt.BloodGroup.ToString();
                lblPtSSnAns.Text = pt.SSN.ToString();
                lblPatientMedicareNo.Text = pt.MedicareNumber.ToString();
                lblPatientConsultingDoctor.Text = pt.Gender.ToString();

            }

        }
    }
}
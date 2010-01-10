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
using System.Collections.Generic;
namespace Kelvin.Patients
{
    public partial class AddPatients : System.Web.UI.Page
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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PatientsBO patientsBL = new PatientsBO();
            List<Patient> patientsList = patientsBL.SelectPatients("");
            List<Patient> instPatient = new List<Patient>();
            //instPatient = patientsList.FindAll((Patient instGetPatient) => instGetPatient.MedicareNumber.Contains(txtMedicareNumber.Text.Trim()));

            Patient instPatientRecord = new Patient();
            //if (instPatient == null)
            //{
            instPatientRecord.PatientFirstName = txtPatientName.Text.Trim();
            instPatientRecord.PatientLastName = txtPatientLastName.Text.Trim();
            instPatientRecord.MedicareNumber = txtMedicareNumber.Text.Trim();
            instPatientRecord.Facility = txtFacilityName.Text.Trim();
            instPatientRecord.ConsultingDoctor = txtConsultingDoctor.Text.Trim();
            instPatientRecord.Address = txtAddress.Text.Trim();
            instPatientRecord.BloodGroup = ddlBloodGroup.SelectedItem.Text.Trim();
            instPatientRecord.DOB = Convert.ToDateTime(txtDOB.Text.Trim());
            instPatientRecord.SSN = txtSSN.Text.Trim();
            instPatientRecord.ContactNo = txtContactNo.Text.Trim();
            instPatientRecord.EmailId = txtEmailId.Text.Trim();
            instPatientRecord.Gender = rblGender.SelectedItem.Text.Trim().ToString();
            int returnValue = patientsBL.InsertPatients(instPatientRecord);
            Session["patientId"] = returnValue;
            lblStatus.Text = "Record Inserted Successfully";

            Response.Redirect("../PatientDashBoard.aspx");
            //}
            //else
            //{
            //    lblStatus.Text = "This Medicare Number already exists";
            //}

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {


        }
    }
}

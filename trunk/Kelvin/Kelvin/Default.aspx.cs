using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Kelvin.Framework;
using Kelvin.Entities;
using System.Data;
using Kelvin.BO;
using Microsoft.Reporting.WebForms;
using System.Net.Mail;
using System.Web.Configuration;
using System.IO;
using System.Net;
using Kelvin.net.interfax.ws;

namespace Kelvin
{
    public partial class _Default : System.Web.UI.Page
    {

        #region "Private Varaibles: "

        /// <summary>
        /// 
        /// </summary>
        private int _testId;

        /// <summary>
        /// 
        /// </summary>
        private int _check = 0;

        /// <summary>
        /// 
        /// </summary>
        private int _patientId;

        #endregion

        #region "Properties: "

        public int TestId
        {
            get { return _testId; }
            set { _testId = value; }
        }

        #endregion

        #region "Events: "

        /// <summary>
        /// This Event Fires when the Page loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["patientId"] != null)
            {
                _patientId = Convert.ToInt32(Session["patientId"]);
            }
            TestProceduresBO testBL = new TestProceduresBO();
            if (!IsPostBack)
            {
                BindInnerRepeater(1);

                if (Session["UserId"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                Session.Remove("Selected_Ids");
                Session.Remove("Already_Selected_Ids");
                Session.Remove("TestProcedures");
                Session.Remove("Selected_Rows");
                Session.Remove("selectedTab");

                lbOccupationTherapy.CssClass = "normalStyle";
                DataSet objPatientTests = testBL.GetTestsForPatient(_patientId);
                ArrayList alreadySelectedIds = new ArrayList();
                if (objPatientTests.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i <= objPatientTests.Tables[0].Rows.Count - 1; i++)
                    {
                        alreadySelectedIds.Add(Convert.ToInt32(objPatientTests.Tables[0].Rows[i][0]));
                    }
                }
                Session["Already_Selected_Ids"] = alreadySelectedIds;
                Session["Selected_Rows"] = objPatientTests.Tables[0];
                gvSaveandAddMore.DataSource = objPatientTests.Tables[0];
                gvPdfPreview.DataSource = objPatientTests.Tables[0];
                gvPdfPreview.DataBind();
                gvSaveandAddMore.DataBind();
                if (alreadySelectedIds.Count > 0)
                {
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnSubmit.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnSubmit.Enabled = false;
                }
            }
            else
            {

                Control control = null;
                //first we will check the "__EVENTTARGET" because if post back made by       the controls
                //which used "_doPostBack" function also available in Request.Form collection.
                string ctrlname = Page.Request.Params["__EVENTTARGET"];
                string actualTab = "";
                if (ctrlname != null && ctrlname != String.Empty)
                {
                    control = Page.FindControl(ctrlname);
                }
                if (control != null)
                {
                    actualTab = control.ID.ToString().ToLower();

                }
                else
                {
                    actualTab = "";
                }
                lbOccupationTherapy.CssClass = "tabsStyle";
                lbPhysicalTherapy.CssClass = "tabsStyle";
                lbMedicalImaging.CssClass = "tabsStyle";
                lbLabs.CssClass = "tabsStyle";

                switch (actualTab)
                {
                    case "lboccupationtherapy":
                        lbOccupationTherapy.CssClass = "normalStyle";
                        break;
                    case "lbphysicaltherapy":
                        lbPhysicalTherapy.CssClass = "normalStyle";
                        break;
                    case "lbmedicalimaging":
                        lbMedicalImaging.CssClass = "normalStyle";
                        break;
                    case "lblabs":
                        lbLabs.CssClass = "normalStyle";
                        break;
                    default:
                        lbOccupationTherapy.CssClass = "normalStyle";
                        break;
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (_check == 0)
            {
                if (Session["TestProcedures"] != null)
                {
                    gvMedicationProcedures.DataSource = Session["TestProcedures"];
                    gvMedicationProcedures.DataBind();
                }
            }
        }

        /// <summary>
        /// This Event Fires when ever Search Button Clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //Declaring the List of procedures list
            List<TestProcedure> testProceduresList = new List<TestProcedure>();

            //Checking for Session and Storing 
            if (Session["TestProcedures"] != null)
            {
                testProceduresList = (List<TestProcedure>)Session["TestProcedures"];
            }

            string procedureSearchCriteria = txtKeyWord.Text.Trim().ToString();
            string codeSearchCriteria = txtIcdCode.Text.Trim().ToString();
            gvMedicationProcedures.DataSource = testProceduresList.FindAll((TestProcedure testProcedure) => testProcedure.TestProcedureDescription.Contains(procedureSearchCriteria) || testProcedure.ICD9Code.Contains(codeSearchCriteria));
            gvMedicationProcedures.DataBind();
            _check = 1;
        }

        /// <summary>
        /// This Event Fires when ever the Srot Alphabet Button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnA_Click(object sender, EventArgs e)
        {
            //Declaring the List of procedures list
            List<TestProcedure> testProceduresList = new List<TestProcedure>();

            //Checking for Session and Storing 
            if (Session["TestProcedures"] != null)
            {
                testProceduresList = (List<TestProcedure>)Session["TestProcedures"];
            }

            //Declaring a new instance of Button for Finding Which letter is clicked
            LinkButton btnLetter = new LinkButton();
            btnLetter = (LinkButton)(sender);

            ///gvMedicationProcedures.DataSource = from testProcedure in testProceduresList where testProcedure.TestProcedureDescription
            if (btnLetter.Text == "Show All")
            {
                gvMedicationProcedures.DataSource = testProceduresList;
            }
            else
            {
                gvMedicationProcedures.DataSource = testProceduresList.FindAll((TestProcedure testProcedure) => testProcedure.TestProcedureDescription.StartsWith(btnLetter.Text.ToString(), true, null));
                //= sortedTestProceduresList;
            }

            gvMedicationProcedures.DataBind();
            _check = 1;

        }

        /// <summary>
        /// This event fires at the time of RowDataBound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvMedicationProcedures_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Visible = false;

                //Geting the instance of checkbox in the GridView
                CheckBox chkSelect = new CheckBox();
                chkSelect = (CheckBox)(e.Row.FindControl("chkSelect"));

                //Declaring New Object and a List of TestProcedures.
                TestProcedure instTestProcedure = new TestProcedure();
                List<TestProcedure> testProceduresList = new List<TestProcedure>();
                ArrayList selectedIds = new ArrayList();
                ArrayList alreadySelectedIds = new ArrayList();
                if (Session["Already_Selected_Ids"] != null)
                {
                    alreadySelectedIds = (ArrayList)Session["Already_Selected_Ids"];
                }

                //Checking for the Sessions.
                if (Session["Selected_Ids"] != null)
                {
                    selectedIds = (ArrayList)Session["Selected_Ids"];
                }

                //Checking the Count of the SelectedIds 
                if (selectedIds.Count > 0)
                {

                    if (selectedIds.Contains(Convert.ToInt32(e.Row.Cells[1].Text)))
                    {
                        chkSelect.Checked = true;
                        e.Row.BackColor = System.Drawing.Color.FromArgb(211, 237, 176);
                    }
                    else
                    {
                        chkSelect.Checked = false;
                        e.Row.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    }

                }

                if (alreadySelectedIds.Count > 0)
                {

                    if (alreadySelectedIds.Contains(Convert.ToInt32(e.Row.Cells[1].Text)))
                    {
                        chkSelect.Checked = true;
                        e.Row.BackColor = System.Drawing.Color.FromArgb(211, 237, 176);
                    }
                    else
                    {
                        chkSelect.Checked = false;
                        e.Row.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    }

                }
            }
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[1].Visible = false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvMedicationProcedures_PageIndexChanging(Object sender, GridViewPageEventArgs e)
        {
            gvMedicationProcedures.PageIndex = e.NewPageIndex;
            if (Session["TestProcedures"] != null)
            {
                gvMedicationProcedures.DataSource = Session["TestProcedures"];
                gvMedicationProcedures.DataBind();
            }
        }

        /// <summary>
        /// This Event raises when CheckBox Check Changed in GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkSelect_CheckedChanged(object sender, System.EventArgs e)
        {
            //GridViewRow eachRow=default(GridViewRow);
            GridViewRow getCheckedRow = default(GridViewRow);
            CheckBox checkedCheckBox = default(CheckBox);
            CheckBox rowLevelCheckBox = default(CheckBox);
            CheckBox headerLevelCheckBox = default(CheckBox);
            ArrayList selectedIds = new ArrayList();
            ArrayList alreadySelectedIds = new ArrayList();
            if (Session["Already_Selected_Ids"] != null)
            {
                alreadySelectedIds = (ArrayList)Session["Already_Selected_Ids"];
            }
            if (Session["Selected_Ids"] != null)
            {
                selectedIds = (ArrayList)Session["Selected_Ids"];
            }
            bool isAllChecked = true;
            bool isOneChecked = false;
            checkedCheckBox = (CheckBox)(sender);
            headerLevelCheckBox = (CheckBox)gvMedicationProcedures.HeaderRow.FindControl("chkSelectAll");
            foreach (GridViewRow eachRow in gvMedicationProcedures.Rows)
            {
                rowLevelCheckBox = (CheckBox)eachRow.FindControl("chkSelect");
                if ((rowLevelCheckBox != null))
                {
                    if (!rowLevelCheckBox.Checked)
                    {
                        isAllChecked = false;
                    }
                    else
                    {
                        isOneChecked = true;
                    }
                }
            }
            if (isAllChecked)
            {
                headerLevelCheckBox.Checked = true;
            }
            else
            {
                headerLevelCheckBox.Checked = false;
            }

            getCheckedRow = (GridViewRow)checkedCheckBox.Parent.Parent;
            if (checkedCheckBox.Checked)
            {
                getCheckedRow.BackColor = System.Drawing.Color.FromArgb(211, 237, 176);
            }
            else
            {
                getCheckedRow.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            }
            //foreach (GridViewRow eachRow in gvMedicationProcedures.Rows)
            //{
            // rowLevelCheckBox = (CheckBox)eachRow.FindControl("chkSelect");
            if (checkedCheckBox.Checked == true)
            {
                if (selectedIds.Count > 0)
                {
                    if (!selectedIds.Contains(Convert.ToInt32(getCheckedRow.Cells[1].Text)))
                    {
                        selectedIds.Add(Convert.ToInt32(getCheckedRow.Cells[1].Text));
                    }

                }
                else
                {
                    selectedIds.Add(Convert.ToInt32(getCheckedRow.Cells[1].Text));
                }
                addRowtoDataTable(getCheckedRow);

            }
            else
            {
                if (selectedIds.Count > 0)
                {
                    if (selectedIds.Contains(Convert.ToInt32(getCheckedRow.Cells[1].Text)))
                    {
                        selectedIds.Remove(Convert.ToInt32(getCheckedRow.Cells[1].Text));
                    }
                }
                if (alreadySelectedIds.Count > 0)
                {
                    if (alreadySelectedIds.Contains(Convert.ToInt32(getCheckedRow.Cells[1].Text)))
                    {

                        alreadySelectedIds.Remove(Convert.ToInt32(getCheckedRow.Cells[1].Text));
                    }
                }
                removeRowFromDataTable(getCheckedRow);
            }
            //}
            Session["Selected_Ids"] = selectedIds;
            _check = 1;
            if (selectedIds.Count > 0)
            {
                btnSave.Enabled = true;
                btnSubmit.Enabled = true;
                btnCancel.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnSubmit.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkSelectAll_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox chkSelectAll = (CheckBox)sender;
            CheckBox rowLevelCheckBox = new CheckBox();
            ArrayList selectedIds = new ArrayList();
            ArrayList alreadySelectedIds = new ArrayList();
            if (Session["Already_Selected_Ids"] != null)
            {
                alreadySelectedIds = (ArrayList)Session["Already_Selected_Ids"];
            }
            if (Session["Selected_Ids"] != null)
            {
                selectedIds = (ArrayList)Session["Selected_Ids"];
            }
            if (chkSelectAll.Checked)
            {
                foreach (GridViewRow gvRow in gvMedicationProcedures.Rows)
                {
                    rowLevelCheckBox = (CheckBox)gvRow.FindControl("chkSelect");
                    rowLevelCheckBox.Checked = true;
                    gvRow.BackColor = System.Drawing.Color.FromArgb(211, 237, 176);
                    if (!selectedIds.Contains(Convert.ToInt32(gvRow.Cells[1].Text)))
                    {
                        selectedIds.Add(Convert.ToInt32(gvRow.Cells[1].Text));
                    }
                    //if (!alreadySelectedIds.Contains(Convert.ToInt32(gvRow.Cells[1].Text)))
                    //{
                    //    alreadySelectedIds.Add(Convert.ToInt32(gvRow.Cells[1].Text));
                    //}
                    addRowtoDataTable(gvRow);
                }

            }
            else
            {
                foreach (GridViewRow gvRow in gvMedicationProcedures.Rows)
                {
                    rowLevelCheckBox = (CheckBox)gvRow.FindControl("chkSelect");
                    rowLevelCheckBox.Checked = false;
                    gvRow.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    if (selectedIds.Contains(Convert.ToInt32(gvRow.Cells[1].Text)))
                    {
                        selectedIds.Remove(Convert.ToInt32(gvRow.Cells[1].Text));
                    }
                    if (alreadySelectedIds.Contains(Convert.ToInt32(gvRow.Cells[1].Text)))
                    {
                        alreadySelectedIds.Remove(Convert.ToInt32(gvRow.Cells[1].Text));
                    }
                    removeRowFromDataTable(gvRow);
                }
            }
            Session["Selected_Ids"] = selectedIds;
            Session["Already_Selected_Ids"] = alreadySelectedIds;
            _check = 1;

            if (selectedIds.Count > 0)
            {
                btnSave.Enabled = true;
                btnSubmit.Enabled = true;
                btnCancel.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnSubmit.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, System.EventArgs e)
        {
            int patientId = _patientId;
            int returnValue;
            TestProceduresBO testBL = new TestProceduresBO();
            ArrayList selectesIds = (ArrayList)Session["Selected_Ids"];
            if (selectesIds.Count > 0)
            {
                for (int i = 0; i <= selectesIds.Count - 1; i++)
                {
                    returnValue = testBL.InsertTests(patientId, Convert.ToInt32(selectesIds[i]));
                }
            }
            Response.Redirect("FacilityHome.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnClose_Click(object sender, System.EventArgs e)
        {
            mpeSubmit.Hide();
            _check = 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvPdfPreview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            mpePdfPreview.Show();
            gvMedicationProcedures.PageIndex = e.NewPageIndex;
            DataTable dt = new DataTable();
            if (Session["Selected_Rows"] != null)
            {
                dt = (DataTable)Session["Selected_Rows"];
            }
            gvPdfPreview.DataSource = dt;
            gvPdfPreview.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvSaveandAddMore_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            mpeSaveAndAddMore.Show();
            gvMedicationProcedures.PageIndex = e.NewPageIndex;
            DataTable dt = new DataTable();
            if (Session["Selected_Rows"] != null)
            {
                dt = (DataTable)Session["Selected_Rows"];
            }
            gvSaveandAddMore.DataSource = dt;
            gvSaveandAddMore.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddMore_Click(object sender, System.EventArgs e)
        {
            mpeSaveAndAddMore.Hide();
            _check = 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSaveExit_Click(object sender, System.EventArgs e)
        {
            int patientId = _patientId;
            int returnValue;
            TestProceduresBO testBL = new TestProceduresBO();
            ArrayList selectesIds = (ArrayList)Session["Selected_Ids"];
            if (selectesIds.Count > 0)
            {
                for (int i = 0; i <= selectesIds.Count - 1; i++)
                {
                    returnValue = testBL.InsertTests(patientId, Convert.ToInt32(selectesIds[i]));
                }
            }
            Response.Redirect("PatientDashBoard.aspx");
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
            Repeater thisRepeater = new Repeater();
            thisRepeater = (Repeater)sender;
            foreach (RepeaterItem ri in thisRepeater.Items)
            {
                Button btnInRepeater = (Button)ri.FindControl("innerTabsContent");
                btnInRepeater.Attributes.Add("style", "cursor: hand; margin-top: 10px;background: repeat-x #ffffff; color: #A4D165; border: 0px #ffffff");
            }
            if (innerRepeater != null)
            {
                Button btnInner = (Button)e.Item.FindControl("innerTabsContent");
                List<TestProcedure> lstTestProcedures = TestProceduresBO.GetTestProcedureListByTestId(Convert.ToInt32(btnInner.CommandName));
                btnInner.Attributes.Add("style", "cursor: hand; margin-top: 10px;background: url(../Green/Images/button-bg.png) repeat-x #A4D165;border: 0px solid #5F911A;color: #FFFFFF;font-family: Verdana;font-weight: bold;height:26px;");
                Session["TestProcedures"] = lstTestProcedures;
            }
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
            Session["selectedTab"] = testMasterId;
            LinkButton lbtn = (LinkButton)sender;
            lbtn.Attributes.Add("class", "active");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnPdfCancel_Click(object sender, System.EventArgs e)
        {
            mpePdfPreview.Hide();
            _check = 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnPdfSaveandExit_Click(object sender, System.EventArgs e)
        {
            mpePdfPreview.Hide();

            int returnValue;
            TestProceduresBO testBL = new TestProceduresBO();
            ArrayList selectesIds = (ArrayList)Session["Selected_Ids"];
            if (selectesIds.Count > 0)
            {
                for (int i = 0; i <= selectesIds.Count - 1; i++)
                {
                    returnValue = testBL.InsertTests(_patientId, Convert.ToInt32(selectesIds[i]));
                }
            }
            Response.Redirect("PatientDashBoard.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnPdfSubmit_Click(object sender, System.EventArgs e)
        {
            mpePdfPreview.Hide();
            mpeSubmit.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvSaveandAddMore_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Visible = false;
            }
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[1].Visible = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOk_Click(object sender, EventArgs e)
        {
            int patientId = _patientId;
            int returnValue;
            TestProceduresBO testBL = new TestProceduresBO();
            ArrayList selectesIds = new ArrayList();
            if (Session["Selected_Ids"] != null)
            {
                selectesIds = (ArrayList)Session["Selected_Ids"];
            }
            if (selectesIds.Count > 0)
            {
                for (int i = 0; i <= selectesIds.Count - 1; i++)
                {
                    returnValue = testBL.InsertTests(patientId, Convert.ToInt32(selectesIds[i]));
                }
            }

            DataSet objPatientTest = testBL.GetTestsForPatient(patientId);
            DataSet objPatientName = testBL.GetPatientName(patientId);

            LocalReport lr = new LocalReport();
            lr.ReportPath = HttpContext.Current.Server.MapPath("~/Reports/PatientTests.rdlc");

            ReportDataSource objrdTests = new ReportDataSource("KalvinDataSet_uspGetSelectedTests", objPatientTest.Tables[0]);
            ReportDataSource objrdPatientName = new ReportDataSource("KalvinDataSet_GetPatientName", objPatientName.Tables[0]);

            lr.DataSources.Add(objrdTests);
            lr.DataSources.Add(objrdPatientName);


            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytes = lr.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);
            if (chkFtp.Checked)
            {
                #region MyRegion
                FtpWebRequest reqFTP;

                // Create FtpWebRequest object from the Uri provided
                reqFTP = (FtpWebRequest)FtpWebRequest.Create("ftp://67.228.179.97/PatientTests.pdf");

                // Provide the WebPermission Credintials
                reqFTP.Credentials = new NetworkCredential("ftptest", "ASDFlkj123");

                // By default KeepAlive is true, where the control connection
                // is not closed after a command is executed.
                reqFTP.KeepAlive = false;

                // Specify the command to be executed.
                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

                // Specify the data transfer type.
                reqFTP.UseBinary = true;

                // Notify the server about the size of the uploaded file
                reqFTP.ContentLength = bytes.Length;
                //   reqFTP.ContentLength =5000;
                // The buffer size is set to 2kb
                int buffLength = 2048;
                byte[] buff = new byte[buffLength];

                // Opens a file stream (System.IO.FileStream) to read the file
                // to be uploaded
                // FileStream fs = fileInf.OpenRead();

                try
                {
                    // Stream to which the file to be upload is written
                    Stream strm = reqFTP.GetRequestStream();
                    strm.Write(bytes, 0, bytes.Length);

                    //// Read from the file stream 2kb at a time
                    //contentLen = fs.Read(buff, 0, buffLength);

                    //// Till Stream content ends


                    // Close the file stream and the Request Stream
                    strm.Close();
                    // fs.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("Error::: " + ex.Message);
                }


                #endregion

            }

            if (chkSendMail.Checked)
            {
                MemoryStream s = new MemoryStream(bytes);
                s.Seek(0, SeekOrigin.Begin);

                //System.Configuration.Configuration config = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
                //System.Net.Configuration.MailSettingsSectionGroup settings = (System.Net.Configuration.MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");


                ////Obtain the Network Credentials from the mailSettings section
                //System.Net.NetworkCredential credential = new System.Net.NetworkCredential(settings.Smtp.Network.UserName, settings.Smtp.Network.Password);

                //Create the SMTP Client
                //SmtpClient client = new SmtpClient();
                //client.Host = settings.Smtp.Network.Host;
                //client.Credentials = credential;
                string patientName = Convert.ToString(objPatientName.Tables[0].Rows[0]["PatientFullName"]);
                string pdfName = patientName + "_" + System.DateTime.Now + ".pdf";
                Attachment a = new Attachment(s, pdfName);

                //MailMessage message = new MailMessage("mailreport@vishishta.com", "bas.123ele@gmail.com", "pdf report generation is completed!", "Here is a report for you");
                ////string tmpStr = "bas.123ele@gmail.com" ;

                ////MailAddress copy = new MailAddress(tmpStr);
                ////message.CC.Add(copy);
                //message.Attachments.Add(a);

                string from = "mailreport@vishishta.com";
                string to = "bas.123ele@gmail.com";
                string subject = "PDF Generated";
                string body = "<br>Attached is the PDF Report";


                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                MailAddress fromAddress = new MailAddress(from);
                MailAddress toAddress = new MailAddress(to);
                
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                mail.From = fromAddress;
                mail.To.Add(toAddress);
                mail.Attachments.Add(a);
                
                
                System.Net.Mail.SmtpClient objSmtpClient = new System.Net.Mail.SmtpClient();
                objSmtpClient.Host = "mail.vishishta.com";
                objSmtpClient.Port = 26;
                //objSmtpClient.EnableSsl = true;
                objSmtpClient.Credentials = new NetworkCredential("mailreport@vishishta.com", "report123");
                objSmtpClient.Send(mail);

            }
            if (chkFax.Checked)
            {
                InterFax fax = new InterFax();
                long returnFaxStatus = 0;
                returnFaxStatus = fax.Sendfax("konkalabhaskar", "mscele", "+18477500209", bytes, "pdf");
            }
            mpeSubmit.Hide();
            _check = 1;
            Response.Redirect("FacilityHome.aspx");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmitCancel_Click(object sender, EventArgs e)
        {
            mpeSubmit.Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnClose_Click(object sender, EventArgs e)
        {
            mpePdfPreview.Hide();
            _check = 1;
        }

        #endregion

        #region "Private Functions : "

        //TestProcedureId
        //TestProcedureDescription
        //ICD9Code
        private void addRowtoDataTable(GridViewRow gvRow)
        {
            DataTable dt = new DataTable();
            if (Session["Selected_Rows"] != null)
            {
                dt = (DataTable)Session["Selected_Rows"];
            }
            else
            {
                dt.Columns.Add(new DataColumn("TestProcedureId", System.Type.GetType("System.Int32")));
                dt.Columns.Add(new DataColumn("TestProcedureDescription", System.Type.GetType("System.String")));
                dt.Columns.Add(new DataColumn("ICD9Code", System.Type.GetType("System.String")));
            }
            DataRow row;
            row = dt.NewRow();
            if (gvRow.Cells[1].Text != "")
            {
                row["TestProcedureId"] = Convert.ToInt32(gvRow.Cells[1].Text);
            }
            if (gvRow.Cells[2].Text != "")
            {
                row["TestProcedureDescription"] = Convert.ToString(gvRow.Cells[2].Text);
            }
            if (gvRow.Cells[3].Text != "")
            {
                row["ICD9Code"] = Convert.ToString(gvRow.Cells[3].Text);
            }

            dt.Rows.Add(row);
            Session["Selected_Rows"] = dt;
            gvSaveandAddMore.DataSource = dt;
            gvPdfPreview.DataSource = dt;
            gvPdfPreview.DataBind();
            gvSaveandAddMore.DataBind();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dr"></param>
        private void removeRowFromDataTable(GridViewRow gvRow)
        {
            DataTable dt = new DataTable();
            if (Session["Selected_Rows"] != null)
            {
                dt = (DataTable)Session["Selected_Rows"];
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    if (Convert.ToInt32(dt.Rows[i]["TestProcedureId"]) == Convert.ToInt32(gvRow.Cells[1].Text))
                    {
                        dt.Rows.RemoveAt(i);
                        break;
                    }
                }
                Session["Selected_Rows"] = dt;
                gvSaveandAddMore.DataSource = dt;
                gvPdfPreview.DataSource = dt;
                gvPdfPreview.DataBind();
                gvSaveandAddMore.DataBind();
            }

        }

        #endregion

    }
}

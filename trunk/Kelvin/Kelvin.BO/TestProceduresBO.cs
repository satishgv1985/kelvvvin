using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kelvin.DAO;
using System.Data;
using System.Data.Common;
using Kelvin.Entities;
namespace Kelvin.BO
{
    public class TestProceduresBO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="testId"></param>
        /// <returns></returns>
        public static List<TestProcedure> GetTestProcedureListByTestId(int testId)
        {
            List<TestProcedure> listTP = new List<TestProcedure>();

            DataTable dt = TestProceduresDAO.GetTestProceduresListByTestId(testId);
            if (dt == null)
                return listTP;
            foreach (DataRow dr in dt.Rows)
            {
                TestProcedure tp = new TestProcedure();
                tp.TestProcedureId = Convert.ToInt32(dr["TestProcedureId"]);
                tp.TestProcedureName = Convert.ToString(dr["TestProcedureName"]);
                tp.TestProcedureDescription = Convert.ToString(dr["TestProcedureDescription"]);
                tp.ICD9Code = Convert.ToString(dr["ICD9Code"]);

                listTP.Add(tp);
            }
            return listTP;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="testProcedureId"></param>
        /// <returns></returns>
        public int InsertTests(int patientId, int testProcedureId)
        {
            TestProceduresDAO testDL = new TestProceduresDAO();
            return testDL.InsertTests(patientId, testProcedureId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public DataSet GetTestsForPatient(int patientID)
        {
            TestProceduresDAO testDL = new TestProceduresDAO();
            return testDL.GetTestsForPatient(patientID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public DataSet GetPatientName(int patientID)
        {
            TestProceduresDAO testDL = new TestProceduresDAO();
            return testDL.GetPatientName(patientID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public Patient GetPatientFullInfo(int patientId)
        {
            TestProceduresDAO testDL = new TestProceduresDAO();
            DataTable dt = testDL.GetPatientFullInfoById(patientId);

            Patient ptDetails = new Patient();
            //ptDetails.PatientName = Convert.ToString(dt.Tables[0].Rows[0][0]);


            if (dt == null)
            {
                return ptDetails;
            }
            else if (dt.Rows.Count == 0)
            {
                return ptDetails;
            }
            else
            {
                DataRow patientdr = dt.Rows[0];
                ptDetails.PatientFirstName = Convert.ToString(patientdr["PatientFirstName"]);
                ptDetails.PatientLastName = Convert.ToString(patientdr["PatientLastName"]); 
                ptDetails.DOB = Convert.ToDateTime(patientdr["DOB"]);
                ptDetails.SSN = Convert.ToString(patientdr["SSN"]);
                ptDetails.ContactNo = Convert.ToString(patientdr["ContactNo"]);
                ptDetails.EmailId = Convert.ToString(patientdr["EmailId"]); 
                ptDetails.Facility = Convert.ToString(patientdr["Facility"]);
                ptDetails.Address = Convert.ToString(patientdr["Address"]);
                ptDetails.BloodGroup = Convert.ToString(patientdr["BloodGroup"]);
                ptDetails.MedicareNumber = Convert.ToString(patientdr["MedicareNumber"]);
                ptDetails.ConsultingDoctor = Convert.ToString(patientdr["ConsultingDoctor"]);
                ptDetails.Gender = Convert.ToString(patientdr["Gender"]);
                return ptDetails;
            }


        }
    }
}

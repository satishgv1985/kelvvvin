using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kelvin.DAO;
using Kelvin.Entities;
using System.Data.Common;
using System.Data;

namespace Kelvin.BO
{
    public class PatientsBO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="instPatient"></param>
        /// <returns></returns>
        public int InsertPatients(Patient instPatient)
        {
            int patientIdInserted = 1;
            PatientsDAO patientDL = new PatientsDAO();
             DataTable dtPatients=patientDL.InsertPatients(instPatient);
             foreach (DataRow dr in dtPatients.Rows)
             {
                     patientIdInserted = Convert.ToInt32(dr[0]);
             }
             return patientIdInserted;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Patient> SelectPatients(string startsWith)
        {
            PatientsDAO patientDL = new PatientsDAO();
            DataTable dtPatients = patientDL.SelectPatients(startsWith);
            List<Patient> patientsList = new List<Patient>();

            if (dtPatients != null)
            {
                if (dtPatients.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtPatients.Rows)
                    {
                        Patient instPatient = new Patient();
                        if (dr["PatientId"] != DBNull.Value)
                        {
                            instPatient.PatientId = Convert.ToInt32(dr["PatientId"]);
                        }
                        if (dr["PatientFullName"] != DBNull.Value)
                        {
                            instPatient.PatientFullName = Convert.ToString(dr["PatientFullName"]);
                        }
                        if (dr["PatientFirstName"] != DBNull.Value)
                        {
                            instPatient.PatientFirstName = Convert.ToString(dr["PatientFirstName"]);
                        }
                        if (dr["PatientLastName"] != DBNull.Value)
                        {
                            instPatient.PatientLastName = Convert.ToString(dr["PatientLastName"]);
                        }
                        if (dr["DOB"] != DBNull.Value)
                        {
                            instPatient.DOB = Convert.ToDateTime(dr["DOB"]);
                        }
                        if (dr["SSN"] != DBNull.Value)
                        {
                            instPatient.SSN = Convert.ToString(dr["SSN"]);
                        }
                        if (dr["ContactNo"] != DBNull.Value)
                        {
                            instPatient.ContactNo = Convert.ToString(dr["ContactNo"]);
                        }
                        if (dr["EmailId"] != DBNull.Value)
                        {
                            instPatient.EmailId = Convert.ToString(dr["EmailId"]);
                        }
                        if (dr["Facility"] != DBNull.Value)
                        {
                            instPatient.Facility = Convert.ToString(dr["Facility"]);
                        }
                        if (dr["Address"] != DBNull.Value)
                        {
                            instPatient.Address = Convert.ToString(dr["Address"]);
                        }
                        if (dr["BloodGroup"] != DBNull.Value)
                        {
                            instPatient.BloodGroup = Convert.ToString(dr["BloodGroup"]);
                        }
                        if (dr["MedicareNumber"] != DBNull.Value)
                        {
                            instPatient.MedicareNumber = Convert.ToString(dr["MedicareNumber"]);
                        }
                        if (dr["ConsultingDoctor"] != DBNull.Value)
                        {
                            instPatient.ConsultingDoctor = Convert.ToString(dr["ConsultingDoctor"]);
                        }
                        patientsList.Add(instPatient);
                    }
                }
            }
            return patientsList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Patient> SelectPatientsByNameSsn(string startsWith,string ssn)
        {
            PatientsDAO patientDL = new PatientsDAO();
            DataTable dtPatients = patientDL.SelectPatientsByNameSsn(startsWith, ssn);
            List<Patient> patientsList = new List<Patient>();

            if (dtPatients != null)
            {
                if (dtPatients.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtPatients.Rows)
                    {
                        Patient instPatient = new Patient();
                        if (dr["PatientId"] != DBNull.Value)
                        {
                            instPatient.PatientId = Convert.ToInt32(dr["PatientId"]);
                        }
                        if (dr["PatientFullName"] != DBNull.Value)
                        {
                            instPatient.PatientFullName = Convert.ToString(dr["PatientFullName"]);
                        }
                        if (dr["PatientFirstName"] != DBNull.Value)
                        {
                            instPatient.PatientFirstName = Convert.ToString(dr["PatientFirstName"]);
                        }
                        if (dr["PatientLastName"] != DBNull.Value)
                        {
                            instPatient.PatientLastName = Convert.ToString(dr["PatientLastName"]);
                        }
                        if (dr["DOB"] != DBNull.Value)
                        {
                            instPatient.DOB = Convert.ToDateTime(dr["DOB"]);
                        }
                        if (dr["SSN"] != DBNull.Value)
                        {
                            instPatient.SSN = Convert.ToString(dr["SSN"]);
                        }
                        if (dr["ContactNo"] != DBNull.Value)
                        {
                            instPatient.ContactNo = Convert.ToString(dr["ContactNo"]);
                        }
                        if (dr["EmailId"] != DBNull.Value)
                        {
                            instPatient.EmailId = Convert.ToString(dr["EmailId"]);
                        }
                        if (dr["Facility"] != DBNull.Value)
                        {
                            instPatient.Facility = Convert.ToString(dr["Facility"]);
                        }
                        if (dr["Address"] != DBNull.Value)
                        {
                            instPatient.Address = Convert.ToString(dr["Address"]);
                        }
                        if (dr["BloodGroup"] != DBNull.Value)
                        {
                            instPatient.BloodGroup = Convert.ToString(dr["BloodGroup"]);
                        }
                        if (dr["MedicareNumber"] != DBNull.Value)
                        {
                            instPatient.MedicareNumber = Convert.ToString(dr["MedicareNumber"]);
                        }
                        if (dr["ConsultingDoctor"] != DBNull.Value)
                        {
                            instPatient.ConsultingDoctor = Convert.ToString(dr["ConsultingDoctor"]);
                        }
                        patientsList.Add(instPatient);
                    }
                }
            }
            return patientsList;
       }
       
    }
}

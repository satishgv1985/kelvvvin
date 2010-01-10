using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kelvin.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
namespace Kelvin.DAO
{
    public class PatientsDAO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="instPatients"></param>
        /// <returns></returns>
        public DataTable InsertPatients(Patient instPatients)
        {
            string errormsg = null;
            int returnValue = 0;
            DbCommand cmd;
            DataTable dtPatients = new DataTable();
            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection();
                cmd.CommandText = "uspPatientsInsert";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@patientFirstName", SqlDbType.VarChar);
                param.Value = instPatients.PatientFirstName;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@patientLastName", SqlDbType.VarChar);
                param.Value = instPatients.PatientLastName;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@DOB", SqlDbType.DateTime);
                param.Value = instPatients.DOB;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@SSN", SqlDbType.VarChar);
                param.Value = instPatients.SSN;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@contactNo", SqlDbType.VarChar);
                param.Value = instPatients.ContactNo;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@emailId", SqlDbType.VarChar);
                param.Value = instPatients.EmailId;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@address", SqlDbType.VarChar);
                param.Value = instPatients.Address;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@bloodGroup", SqlDbType.VarChar);
                param.Value = instPatients.BloodGroup;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@facility", SqlDbType.VarChar);
                param.Value = instPatients.Facility;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@gender", SqlDbType.VarChar);
                param.Value = instPatients.Gender;
                cmd.Parameters.Add(param);
                //@gender
                param = new SqlParameter("@medicareNumber", SqlDbType.VarChar);
                param.Value = instPatients.MedicareNumber;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@consultingDoctor", SqlDbType.VarChar);
                param.Value = instPatients.ConsultingDoctor;
                cmd.Parameters.Add(param);
                dtPatients = DBClass.GetTable(ref cmd, out errormsg);
                               
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return dtPatients;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable SelectPatients(string startsWith)
        { 
            string errormsg = null;
            DataTable dtPatients = new DataTable();
            DbCommand cmd;
            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection();
                cmd.CommandText = "uspPatientsSelect";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@startsWith", SqlDbType.VarChar);
                param.Value = startsWith;
                cmd.Parameters.Add(param);

                dtPatients = DBClass.GetTable(ref cmd, out errormsg);

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return dtPatients;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable SelectPatientsByNameSsn(string startsWith, string ssn)
        {
            string errormsg = null;
            DataTable dtPatients = new DataTable();
            DbCommand cmd;
            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection();
                cmd.CommandText = "uspPatientsSelectBySSn";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@startsWith", SqlDbType.VarChar);
                param.Value = startsWith;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@ssn", SqlDbType.VarChar);
                param.Value = ssn;
                cmd.Parameters.Add(param);

                dtPatients = DBClass.GetTable(ref cmd, out errormsg);

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return dtPatients;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Kelvin.DAO
{
    public sealed class TestProceduresDAO
    {
        public static DataTable GetTestProceduresListByTestId(int testId)
        {
            string errormsg = null;
           // DbConnection conn;
            DbCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                //conn = ConnectionClass.GetConnection();
                //conn.Open();
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection(); ;
                cmd.CommandText = "uspGetTestProcedures";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.Int;
                param.ParameterName = "@testID";
                param.Direction = ParameterDirection.Input;
                param.Value = testId;
                cmd.Parameters.Add(param);
                dt = DBClass.GetTable(ref cmd, out errormsg);
                //conn.Close();
                
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="testProcedureId"></param>
        /// <returns></returns>
        public int InsertTests(int patientId, int testProcedureId)
        { 
            string errormsg = null;
            // DbConnection conn;
            DbCommand cmd;
            int returnValue=0;
            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection(); ;
                cmd.CommandText = "uspInsertTestForPatient";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.VarChar;
                param.ParameterName = "@patientID";
                param.Direction = ParameterDirection.Input;
                param.Value = patientId;
                cmd.Parameters.Add(param);
                SqlParameter param1 = new SqlParameter();
                param1.SqlDbType = SqlDbType.VarChar;
                param1.ParameterName = "@testProcedureID";
                param1.Direction = ParameterDirection.Input;
                param1.Value = testProcedureId;
                cmd.Parameters.Add(param1);
                returnValue = DBClass.ExecuteNonQuery(ref cmd, out errormsg);
            }
            catch (Exception ex)
            { 
                ex.Message.ToString();
            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        public DataSet GetTestsForPatient(int patientId)
        { 
            string errormsg = null;
           // DbConnection conn;
            DbCommand cmd;
            DataSet ds = new DataSet();

            try
            {
                //conn = ConnectionClass.GetConnection();
                //conn.Open();
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection(); ;
                cmd.CommandText = "uspGetSelectedTests";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.Int;
                param.ParameterName = "@patientID";
                param.Direction = ParameterDirection.Input;
                param.Value = patientId;
                cmd.Parameters.Add(param);
                ds = DBClass.GetDataSet(ref cmd, out errormsg);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        public DataSet GetPatientName(int patientId)
        {
            string errormsg = null;
            // DbConnection conn;
            DbCommand cmd;
            DataSet ds = new DataSet();

            try
            {
                //conn = ConnectionClass.GetConnection();
                //conn.Open();
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection(); ;
                cmd.CommandText = "uspGetPatientName";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.Int;
                param.ParameterName = "@patientId";
                param.Direction = ParameterDirection.Input;
                param.Value = patientId;
                cmd.Parameters.Add(param);
                ds = DBClass.GetDataSet(ref cmd, out errormsg);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ds;
        }

        public DataTable GetPatientFullInfoById(int patientId)
        {
            string errormsg = null;
            // DbConnection conn;
            DbCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                //conn = ConnectionClass.GetConnection();
                //conn.Open();
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection(); ;
                cmd.CommandText = "uspGetPatientInfoById";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.Int;
                param.ParameterName = "@patientId";
                param.Direction = ParameterDirection.Input;
                param.Value = patientId;
                cmd.Parameters.Add(param);
                dt = DBClass.GetTable(ref cmd, out errormsg);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return dt;
        }
    }
}

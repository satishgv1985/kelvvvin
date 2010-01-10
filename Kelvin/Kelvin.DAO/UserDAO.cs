using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Kelvin.Entities;
namespace Kelvin.DAO
{
    public class UserDAO
    {
        public DataTable GetUserNameByPrefix(string prefix)
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
                cmd.CommandText = "UserNameSearch";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.VarChar;
                param.ParameterName = "@name";
                param.Direction = ParameterDirection.Input;
                param.Value = prefix;
                cmd.Parameters.Add(param);
                dt = DBClass.GetTable(ref cmd, out errormsg);
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
        /// <returns></returns>
        public DataTable GetGroups()
        {
            string errormsg = null;
            // DbConnection conn;
            DbCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection();
                cmd.CommandText = "GroupSelect";
                cmd.CommandType = CommandType.StoredProcedure;
                dt = DBClass.GetTable(ref cmd, out errormsg);
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
        /// <param name="user"></param>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public int InsertUser(User user, int groupID)
        { 
            string errormsg = null;
            // DbConnection conn;
            DbCommand cmd;
            int returnValue=0;
            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection(); ;
                cmd.CommandText = "UserCreate";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.VarChar;
                param.ParameterName = "@userName";
                param.Direction = ParameterDirection.Input;
                param.Value = user.UserName;
                cmd.Parameters.Add(param);
                 SqlParameter param0 = new SqlParameter();
                param0.SqlDbType = SqlDbType.VarChar;
                param0.ParameterName = "@password";
                param0.Direction = ParameterDirection.Input;
                param0.Value = user.Password;
                cmd.Parameters.Add(param0); 
                SqlParameter param1 = new SqlParameter();
                param1.SqlDbType = SqlDbType.VarChar;
                param1.ParameterName = "@userFName";
                param1.Direction = ParameterDirection.Input;
                param1.Value = user.UserFName;
                cmd.Parameters.Add(param1);
                 SqlParameter param2 = new SqlParameter();
                param2.SqlDbType = SqlDbType.VarChar;
                param2.ParameterName = "@userLName";
                param2.Direction = ParameterDirection.Input;
                param2.Value = user.UserLName;
                cmd.Parameters.Add(param2);
                 SqlParameter param3 = new SqlParameter();
                param3.SqlDbType = SqlDbType.Int;
                param3.ParameterName = "@userAddedBy";
                param3.Direction = ParameterDirection.Input;
                param3.Value = user.UserAddedBy;
                cmd.Parameters.Add(param3);
                 SqlParameter param4 = new SqlParameter();
                param4.SqlDbType = SqlDbType.DateTime;
                param4.ParameterName = "@userAddedOn";
                param4.Direction = ParameterDirection.Input;
                param4.Value = user.UserAddedOn;
                cmd.Parameters.Add(param4);
                SqlParameter param5 = new SqlParameter();
                param5.SqlDbType = SqlDbType.Int;
                param5.ParameterName = "@groupId";
                param5.Direction = ParameterDirection.Input;
                param5.Value = groupID;
                cmd.Parameters.Add(param5);
                returnValue = DBClass.ExecuteNonQuery(ref cmd,out errormsg);
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
            return returnValue;
         }

        public static DataTable ValidateUserLogin(User userDetails)
        {
            string errormsg = null;
            DbCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection();
                cmd.CommandText = "uspValidateUser";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.VarChar;
                param.ParameterName = "@userName";
                param.Direction = ParameterDirection.Input;
                param.Value = userDetails.UserName;
                cmd.Parameters.Add(param);

                SqlParameter param2 = new SqlParameter();
                param2.SqlDbType = SqlDbType.VarChar;
                param2.ParameterName = "@password";
                param2.Direction = ParameterDirection.Input;
                param2.Value = userDetails.Password;
                cmd.Parameters.Add(param2);

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

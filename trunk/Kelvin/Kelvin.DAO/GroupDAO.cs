using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Kelvin.Entities;
namespace Kelvin.DAO
{
    public class GroupDAO
    {
        public static DataTable GetGroupDetailsByUserId(int userId)
        {
            string errormsg = null;
            DbCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection();
                cmd.CommandText = "uspAdminUserCheck";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.VarChar;
                param.ParameterName = "@userId";
                param.Direction = ParameterDirection.Input;
                param.Value = userId;
                cmd.Parameters.Add(param);

                dt = DBClass.GetTable(ref cmd, out errormsg);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return dt;
        }
        public int InsertGroup(Group instGroup)
        {
            string errormsg = null;
            int returnValue=0;
            DbCommand cmd;
            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection();
                cmd.CommandText = "uspInsertGroup";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@groupName", SqlDbType.VarChar);
                param.Value = instGroup.GroupName;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@groupDescription", SqlDbType.VarChar);
                param.Value = instGroup.GroupDescription;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@canView", SqlDbType.Bit);
                param.Value = instGroup.CanView;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@canUpdate", SqlDbType.Bit);
                param.Value = instGroup.CanUpdate;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@canDelete", SqlDbType.Bit);
                param.Value = instGroup.CanDelete;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@canAdd", SqlDbType.Bit);
                param.Value = instGroup.CanAdd;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@groupAddedBy", SqlDbType.Int);
                param.Value = instGroup.GroupAddedBy;
                cmd.Parameters.Add(param);
                returnValue = DBClass.ExecuteNonQuery(ref cmd, out errormsg);

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return returnValue;
        }

        public DataTable SearchGroupByPreFix(string groupPrefix)
        {
            string errormsg = null;
            DataTable dtGroups = new DataTable(); ;
            DbCommand cmd;
            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection();
                cmd.CommandText = "uspSelectGroupByPrefix";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@groupPreFix", SqlDbType.VarChar);
                param.Value = groupPrefix;
                cmd.Parameters.Add(param);

                dtGroups = DBClass.GetTable(ref cmd, out errormsg);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            return dtGroups;
        }
    }
}

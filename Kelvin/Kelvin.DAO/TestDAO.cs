using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Kelvin.DAO
{
    public class TestDAO
    {
        public static DataTable GetTestsDetailsByTestMasterId(int testMasterId)
        {
            string errormsg = null;
            DbCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection(); ;
                cmd.CommandText = "uspGetTestsDetailsByTestMasterId";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.SqlDbType = SqlDbType.Int;
                param.ParameterName = "@testMasterId";
                param.Direction = ParameterDirection.Input;
                param.Value = testMasterId;
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

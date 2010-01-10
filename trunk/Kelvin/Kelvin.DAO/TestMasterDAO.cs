using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;

namespace Kelvin.DAO
{
    public class TestMasterDAO
    {
        public static DataTable GetTestMasterList()
        {
            string errormsg = null;
            //DbConnection conn;
            DbCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                //conn = ConnectionClass.GetConnection();
                //conn.Open();
                cmd = DBClass.GetCommand();
                cmd.Connection = ConnectionClass.GetConnection(); ;
                cmd.CommandText = "uspGetTestMasterList";
                cmd.CommandType = CommandType.StoredProcedure;
                dt = DBClass.GetTable(ref cmd, out errormsg);
                //conn.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            return dt;
        }
    }
}

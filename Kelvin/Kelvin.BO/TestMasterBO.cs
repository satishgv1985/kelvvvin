using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kelvin.Entities;
using System.Data;
using Kelvin.DAO;
namespace Kelvin.BO
{
    public class TestMasterBO
    {
        public static List<TestMaster> GetTestMasterList()
        {
            List<TestMaster> listTM = new List<TestMaster>();

            DataTable dt = TestMasterDAO.GetTestMasterList();
            foreach (DataRow dr in dt.Rows)
            {
                TestMaster tm = new TestMaster();
                tm.TestMasterId = Convert.ToInt32(dr["TestMasterId"]);
                tm.TestMasterName = Convert.ToString(dr["TestMasterName"]);
                tm.TestMasterDescription = Convert.ToString(dr["TestMasterDescription"]);

                listTM.Add(tm);
            }
            return listTM;
        }
    }
}

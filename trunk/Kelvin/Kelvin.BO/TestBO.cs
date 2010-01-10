using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kelvin.Entities;
using System.Data.SqlClient;
using System.Data;
using Kelvin.DAO;

namespace Kelvin.BO
{
    public class TestBO
    {

        public static List<Test> GetTestsDetailsByTestMasterId(int testMasterId)
        {
            List<Test> listT = new List<Test>();
            DataTable dt = TestDAO.GetTestsDetailsByTestMasterId(testMasterId);

            
            foreach (DataRow dr in dt.Rows)
            {
                Test objTest = new Test();
                objTest.TestId = Convert.ToInt32(dr["TestId"]);
                objTest.TestName = Convert.ToString(dr["TestName"]);
                objTest.TestMasterId = Convert.ToInt32(dr["TestMasterId"]);

                listT.Add(objTest);
            }
            return listT;
            
        }
    }
}

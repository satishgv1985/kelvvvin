using System;
using System.Collections.Generic;
using System.Text;

namespace Kelvin.Entities
{
    public class TestProcedure
    {
        private int _testProcedureId;

        public int TestProcedureId
        {
            get { return _testProcedureId; }
            set { _testProcedureId = value; }
        }
        private int _testId;

        public int TestId
        {
            get { return _testId; }
            set { _testId = value; }
        }
        private string _testProcedureName;

        public string TestProcedureName
        {
            get { return _testProcedureName; }
            set { _testProcedureName = value; }
        }
        private string _testProcedureDescription;

        public string TestProcedureDescription
        {
            get { return _testProcedureDescription; }
            set { _testProcedureDescription = value; }
        }
        private string _ICD9Code;

        public string ICD9Code
        {
            get { return _ICD9Code; }
            set { _ICD9Code = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Kelvin.Entities
{
    public class PatientTest
    {
        private int _patientId;
        private string _patientName;
        private int _testProcedureId;
        private string _testProcedureName;
        private string _icd9Code;

        public string ICD9Code
        {
            get { return _icd9Code; }
            set { _icd9Code = value; }
        }
        public int TestProcedureId
        {
            get { return _testProcedureId; }
            set { _testProcedureId = value; }
        }

        public int PatientId
        {
            get { return _patientId; }
            set { _patientId = value; }
        }

        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }

        public string TestProcedureName
        {
            get { return _testProcedureName; }
            set { _testProcedureName = value; }
        }
    }
}

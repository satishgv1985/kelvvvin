using System;
using System.Collections.Generic;
using System.Text;

namespace Kelvin.Entities
{
    public class Test
    {
        private int _testId;

        public int TestId
        {
            get { return _testId; }
            set { _testId = value; }
        }
        private int _testMasterId;

        public int TestMasterId
        {
            get { return _testMasterId; }
            set { _testMasterId = value; }
        }
        private string _testName;

        public string TestName
        {
            get { return _testName; }
            set { _testName = value; }
        }
        private string _testDescription;

        public string TestDescription
        {
            get { return _testDescription; }
            set { _testDescription = value; }
        }
    }
}

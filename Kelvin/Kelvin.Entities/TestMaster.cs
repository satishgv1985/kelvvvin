using System;
using System.Collections.Generic;
using System.Text;

namespace Kelvin.Entities
{
    public class TestMaster
    {
        private int _testMasterId;

        public int TestMasterId
        {
            get { return _testMasterId; }
            set { _testMasterId = value; }
        }
        private string _testMasterName;

        public string TestMasterName
        {
            get { return _testMasterName; }
            set { _testMasterName = value; }
        }
        private string _testMasterDescription;

        public string TestMasterDescription
        {
            get { return _testMasterDescription; }
            set { _testMasterDescription = value; }
        }
    }
}

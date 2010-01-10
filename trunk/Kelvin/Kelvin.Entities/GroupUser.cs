using System;
using System.Collections.Generic;
using System.Text;

namespace Kelvin.Entities
{
    public class GroupUser
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private int _groupId;

        public int GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _groupName;

        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }
    }
}

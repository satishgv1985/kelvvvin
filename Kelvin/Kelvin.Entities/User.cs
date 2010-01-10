using System;
using System.Collections.Generic;
using System.Text;

namespace Kelvin.Entities
{
    public class User
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _userFName;

        public string UserFName
        {
            get { return _userFName; }
            set { _userFName = value; }
        }

        private string _userLName;

        public string UserLName
        {
            get { return _userLName; }
            set { _userLName = value; }
        }

        private int _userAddedBy;

        public int UserAddedBy
        {
            get { return _userAddedBy; }
            set { _userAddedBy = value; }
        }
        
        private DateTime _userAddedOn;

        public DateTime UserAddedOn
        {
            get { return _userAddedOn; }
            set { _userAddedOn = value; }
        }
        
        private int _userModifiedBy;

        public int UserModifiedBy
        {
            get { return _userModifiedBy; }
            set { _userModifiedBy = value; }
        }
        
        private DateTime _userModifiedOn;

        public DateTime UserModifiedOn
        {
            get { return _userModifiedOn; }
            set { _userModifiedOn = value; }
        }

        private bool _validUser;
        public bool ValidUser
        {
            get { return _validUser; }
            set { _validUser = value; }
        }
    }
}

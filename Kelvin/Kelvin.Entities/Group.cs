using System;
using System.Collections.Generic;
using System.Text;

namespace Kelvin.Entities
{
    public class Group
    {
        private int _groupId;

        public int GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }

        private string _groupName;

        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }

        private bool _canView;

        public bool CanView
        {
            get { return _canView; }
            set { _canView = value; }
        }

        private bool _canAdd;

        public bool CanAdd
        {
            get { return _canAdd; }
            set { _canAdd = value; }
        }

        private bool _canUpdate;

        public bool CanUpdate
        {
            get { return _canUpdate; }
            set { _canUpdate = value; }
        }

        private bool _canDelete;

        public bool CanDelete
        {
            get { return _canDelete; }
            set { _canDelete = value; }
        }

        private int _groupAddedBy;

        public int GroupAddedBy
        {
            get { return _groupAddedBy; }
            set { _groupAddedBy = value; }
        }

        private DateTime _groupAddedOn;

        public DateTime GroupAddedOn
        {
            get { return _groupAddedOn; }
            set { _groupAddedOn = value; }
        }

        private int _groupModifiedBy;

        public int GroupModifiedBy
        {
            get { return _groupModifiedBy; }
            set { _groupModifiedBy = value; }
        }


        private DateTime _groupModifiedOn;

        public DateTime GroupModifiedOn
        {
            get { return _groupModifiedOn; }
            set { _groupModifiedOn = value; }
        }

        private string _groupDescription;

        public string GroupDescription
        {
            get { return _groupDescription; }
            set { _groupDescription = value; }
        }
    }
}

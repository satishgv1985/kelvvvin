using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kelvin.Entities;
using Kelvin.DAO;
using System.Data;

namespace Kelvin.BO
{
    public class GroupBO
    {
        public static Group GetGroupDetailsByUserId(int userId)
        {
            Group groupDetails = new Group();
            DataTable dt = GroupDAO.GetGroupDetailsByUserId(userId);
            groupDetails.GroupName = "otheruser";
            if (dt == null)
            {
                return groupDetails;
            }

            if (dt.Rows.Count == 0)
            {
                return groupDetails;
            }
            else
            {
                DataRow groupdr = dt.Rows[0];
                groupDetails.GroupId = Convert.ToInt32(groupdr["GroupId"]);
                groupDetails.GroupName = Convert.ToString(groupdr["GroupName"]);
                //groupDetails.CanView = Convert.ToBoolean(groupdr["CanView"]);

                return groupDetails;
            }
        }

        public int InsertGroup(Group instGroup)
        {
            GroupDAO groupDL = new GroupDAO();
            return groupDL.InsertGroup(instGroup);
        }

        public List<Group> SearchGroupByPreFix(string groupPrefix)
        {
            GroupDAO groupDL = new GroupDAO();
            List<Group> gruopsList = new List<Group>();
            DataTable dtGroups = groupDL.SearchGroupByPreFix(groupPrefix);

            if (dtGroups != null)
            {
                if (dtGroups.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtGroups.Rows)
                    {
                        Group instGroup = new Group();
                        if (dr["GroupId"] != DBNull.Value)
                        {
                            instGroup.GroupId = Convert.ToInt32(dr["GroupId"]);
                        }
                        if (dr["GroupName"] != DBNull.Value)
                        {
                            instGroup.GroupName = Convert.ToString(dr["GroupName"]);
                        }
                        if (dr["CanView"] != DBNull.Value)
                        {
                            instGroup.CanView = Convert.ToBoolean(dr["CanView"]);
                        }
                        if (dr["CanAdd"] != DBNull.Value)
                        {
                            instGroup.CanAdd = Convert.ToBoolean(dr["CanAdd"]);
                        }
                        if (dr["CanUpdate"] != DBNull.Value)
                        {
                            instGroup.CanUpdate = Convert.ToBoolean(dr["CanUpdate"]);
                        }
                        if (dr["CanDelete"] != DBNull.Value)
                        {
                            instGroup.CanDelete = Convert.ToBoolean(dr["CanDelete"]);
                        }
                        if (dr["GroupAddedBy"] != DBNull.Value)
                        {
                            instGroup.GroupAddedBy = Convert.ToInt32(dr["GroupAddedBy"]);
                        }
                        if (dr["GroupAddedOn"] != DBNull.Value)
                        {
                            instGroup.GroupAddedOn = Convert.ToDateTime(dr["GroupAddedOn"]);
                        }
                        if (dr["GroupModifiedBy"] != DBNull.Value)
                        {
                            instGroup.GroupModifiedBy = Convert.ToInt32(dr["GroupModifiedBy"]);
                        }
                        if (dr["GroupModifiedOn"] != DBNull.Value)
                        {
                            instGroup.GroupModifiedOn = Convert.ToDateTime(dr["GroupModifiedOn"]);
                        }

                        gruopsList.Add(instGroup);
                    }

                }
            }
            else
            {
                gruopsList = null;
            }
            return gruopsList;
            
        }
    }
}

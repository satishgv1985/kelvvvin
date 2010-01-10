using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kelvin.Entities;
using System.Data;
using Kelvin.DAO;
using System.Web.UI;
using System.Web;
using System.Web.SessionState;

namespace Kelvin.BO
{
    public class UserBO
    {
        public bool EncryptPassword(User user)
        {
            return false;
        }

        public static User ValidateUserLogin(string loginName, string passwordHash)
        {
            User userDetails = new User();
            userDetails.UserName = loginName;
            userDetails.Password = passwordHash;
            DataTable dt = UserDAO.ValidateUserLogin(userDetails);
            if (dt == null)
            {

                userDetails.ValidUser = false;
                return userDetails;
            }
            else if (dt.Rows.Count == 0)
            {
                userDetails.ValidUser = false;
                return userDetails;
            }
            else
            {
                DataRow userdr = dt.Rows[0];
                userDetails.ValidUser = true;
                userDetails.UserId = Convert.ToInt32(userdr["UserId"]);
                userDetails.UserName = Convert.ToString(userdr["UserName"]);
                userDetails.UserFName = Convert.ToString(userdr["UserFName"]);
                userDetails.UserLName = Convert.ToString(userdr["UserLName"]);
                userDetails.Password = "";

                return userDetails;
            }
        }

        public List<Group> GetGroups()
        {
            UserDAO userDL = new UserDAO();
            List<Group> gruopsList = new List<Group>();
            DataTable dt = userDL.GetGroups();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
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

        public int InsertUser(User user, int groupId)
        {
            UserDAO userDataAccess = new UserDAO();
            return userDataAccess.InsertUser(user, groupId);
        }

        public List<User> GetUserNameByPrefix(string prefix)
        {
            UserDAO userDL = new UserDAO();
            List<User> usersList = new List<User>();
            DataTable dt = userDL.GetUserNameByPrefix(prefix);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        User instUser = new User();
                        if (dr["UserId"] != DBNull.Value)
                        {
                            instUser.UserId = Convert.ToInt32(dr["UserId"]);
                        }
                        if (dr["UserName"] != DBNull.Value)
                        {
                            instUser.UserName = Convert.ToString(dr["UserName"]);
                        }
                        if (dr["UserFname"] != DBNull.Value)
                        {
                            instUser.UserFName = Convert.ToString(dr["UserFname"]);
                        }
                        if (dr["UserLname"] != DBNull.Value)
                        {
                            instUser.UserLName = Convert.ToString(dr["UserLname"]);
                        }
                        if (dr["UserAddedBy"] != DBNull.Value)
                        {
                            instUser.UserAddedBy = Convert.ToInt32(dr["UserAddedBy"]);
                        }
                        if (dr["UserAddedOn"] != DBNull.Value)
                        {
                            instUser.UserAddedOn = Convert.ToDateTime(dr["UserAddedOn"]);
                        }
                        if (dr["UserModifiedBy"] != DBNull.Value)
                        {
                            instUser.UserModifiedBy = Convert.ToInt32(dr["UserModifiedBy"]);
                        }
                        if (dr["UserModifiedOn"] != DBNull.Value)
                        {
                            instUser.UserModifiedOn = Convert.ToDateTime(dr["UserModifiedOn"]);
                        }
                        usersList.Add(instUser);
                    }
                }
            }
            else
            {
                usersList = null;
            }
            return usersList;
        }
    }
}

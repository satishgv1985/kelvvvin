using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Data;
using Kelvin.Entities;
namespace Kelvin.Framework
{
    public static class Common
    {
        //common methods for the project will be available here.
        public static string ReadResourceValue(ResourceFile resourcefile)
        {
            return "Key Value";
        }

        public static bool CheckSQLInjection(string value)
        {
            return false;
        }
        //add method related to validation controls.

        /// <summary>
        /// This method is used for converting DataTable to GenericList
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static List<User> FromDataTableToList(DataTable dataTable)
        {
            List<User> genericList = new List<User>();
            Type t = typeof(User);
            PropertyInfo[] pi = t.GetProperties();
            foreach (DataRow row in dataTable.Rows)
            {
                object defaultInstance = Activator.CreateInstance(t);
                foreach (PropertyInfo prop in pi)
                {
                    try
                    {
                        object columnvalue = row[prop.Name];
                        if (columnvalue != DBNull.Value)
                        {
                            prop.SetValue(defaultInstance, columnvalue, null);
                        }
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
                User myclass = (User)defaultInstance;
                genericList.Add(myclass);
            }
            return genericList;
        }

    }
}

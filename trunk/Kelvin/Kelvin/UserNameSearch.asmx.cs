using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Collections.Generic;
using Kelvin.Entities;
using Kelvin.BO;
using System.Web.Script.Services;

namespace Kelvin
{
    /// <summary>
    /// Summary description for UserNameSearch
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class UserNameSearch : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string[] UserCreationSearch(string prefixText, int count)
        {
            string LastWord = null;
            string ExpressionStart = null;
            Int32 i = default(Int32);
            string sPreviousDescription = "";
            if (prefixText.Contains(",") && prefixText.LastIndexOf(",") < prefixText.Length)
            {
                LastWord = prefixText.Substring(prefixText.LastIndexOf(",") + 1);
                ExpressionStart = prefixText.Substring(0, prefixText.LastIndexOf(",") + 1);
            }
            else
            {
                LastWord = prefixText;
                ExpressionStart = string.Empty;
            }

            List<string> suggestions = new List<string>();
            if (LastWord.Length > 0)
            {
                UserBO userBussiness = new UserBO();
                List<User> usersList = userBussiness.GetUserNameByPrefix(prefixText);
                foreach (User instUser in usersList)
                {
                    if (instUser.UserName != sPreviousDescription)
                    {
                        i = i + 1;

                        suggestions.Add(instUser.UserName.ToString());
                    }
                    sPreviousDescription = instUser.UserName;
                    if (i > count)
                    {
                        break;
                        // TODO: might not be correct. Was : Exit For
                    }

                }


            }
            return suggestions.ToArray();
        }

        [WebMethod]
        public string[] GroupCreationSearch(string prefixText, int count)
        {
            string LastWord = null;
            string ExpressionStart = null;
            Int32 i = default(Int32);
            string sPreviousDescription = "";
            if (prefixText.Contains(",") && prefixText.LastIndexOf(",") < prefixText.Length)
            {
                LastWord = prefixText.Substring(prefixText.LastIndexOf(",") + 1);
                ExpressionStart = prefixText.Substring(0, prefixText.LastIndexOf(",") + 1);
            }
            else
            {
                LastWord = prefixText;
                ExpressionStart = string.Empty;
            }

            List<string> suggestions = new List<string>();
            if (LastWord.Length > 0)
            {
                GroupBO groupBL = new GroupBO();
                List<Group> GroupsList = groupBL.SearchGroupByPreFix(prefixText);
                foreach (Group instGroup in GroupsList)
                {
                    if (instGroup.GroupName != sPreviousDescription)
                    {
                        i = i + 1;

                        suggestions.Add(instGroup.GroupName.ToString());
                    }
                    sPreviousDescription = instGroup.GroupName;
                    if (i > count)
                    {
                        break;
                        // TODO: might not be correct. Was : Exit For
                    }

                }


            }
            return suggestions.ToArray();
        }

        [WebMethod]
        public string[] PatientDetailsSearch(string prefixText, int count)
        {
            string LastWord = null;
            string ExpressionStart = null;
            Int32 i = default(Int32);
            string sPreviousDescription = "";
            if (prefixText.Contains(",") && prefixText.LastIndexOf(",") < prefixText.Length)
            {
                LastWord = prefixText.Substring(prefixText.LastIndexOf(",") + 1);
                ExpressionStart = prefixText.Substring(0, prefixText.LastIndexOf(",") + 1);
            }
            else
            {
                LastWord = prefixText;
                ExpressionStart = string.Empty;
            }

            List<string> suggestions = new List<string>();
            if (LastWord.Length > 0)
            {
                PatientsBO patientBL = new PatientsBO();
                List<Patient> patientsList = patientBL.SelectPatients(prefixText);
                foreach (Patient instPatient in patientsList)
                {
                    if (instPatient.PatientFullName != sPreviousDescription)
                    {
                        i = i + 1;

                        suggestions.Add(instPatient.PatientFullName.ToString());
                    }
                    sPreviousDescription = instPatient.PatientFullName;
                    if (i > count)
                    {
                        break;
                        // TODO: might not be correct. Was : Exit For
                    }

                }


            }
            return suggestions.ToArray();
        }

    }
}

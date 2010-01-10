using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kelvin.Framework
{
    public class Finder<T, V>
    {

        /// <summary> 
        /// This method is used for getting a list of objects from a list based on some condition 
        /// </summary> 
        /// <param name="lst"></param> 
        /// <param name="propertyName"></param> 
        /// <param name="codeToFind"></param> 
        /// <returns></returns> 
        /// <remarks>Author : Bhaskar</remarks> 
        public static List<T> FindAll(List<T> lst, string propertyName, V codeToFind)
        {
            List<T> FoundList = default(List<T>);
            System.Reflection.PropertyInfo propInfo = typeof(T).GetProperty(propertyName);
            FoundList = lst.FindAll((T question) => ((V)propInfo.GetValue(question, null)).ToString() == codeToFind.ToString());
            return FoundList;
        }

        /// <summary> 
        /// This method is used for getting an object from a list based on some condition 
        /// </summary> 
        /// <param name="lst"></param> 
        /// <param name="propertyName"></param> 
        /// <param name="codeToFind"></param> 
        /// <returns></returns> 
        /// <remarks>Author : Bhaskar</remarks> 
        public static T Find(List<T> lst, string propertyName, V codeToFind)
        {
            T Found = default(T);
            System.Reflection.PropertyInfo propInfo = typeof(T).GetProperty(propertyName);
            Found = lst.Find((T question) => ((V)propInfo.GetValue(question, null)).ToString() == codeToFind.ToString());
            return Found;
        }


    }

}

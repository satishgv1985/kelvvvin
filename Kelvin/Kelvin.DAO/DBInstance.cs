using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kelvin.DAO
{
    public sealed class DBInstance
    {
        static DBInstance dbinstance = null;
        static readonly object padlock = new object();

        public static DBInstance Instance
        {
            get
            {
                lock (padlock)
                {
                    if (dbinstance == null)
                    {
                        dbinstance = new DBInstance();
                    }
                    return dbinstance;
                }
            }
        }

    }
}

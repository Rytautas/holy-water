using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace holy_water
{
    internal class Utility
    {
        //Get the connection string from App config file.  
        internal static string GetConnectionString()
        {
            string returnValue = null;
 
            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["SimpleDataApp.Properties.Settings.connString"];

            //If found, return the connection string.  
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }

    }
}

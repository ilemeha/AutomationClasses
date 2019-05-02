using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTests.Configuration
{
    public class Config
    {
        public static string GetEnviroment()
        {
            return GetConfigValue("Enviroment");
        }

        public static string GetBrowser()
        {
            return GetConfigValue("Browser");
        }

        public static string GetURL()
        {
            string key = "AlexPetsURL." + GetEnviroment();
            return GetConfigValue(key);
        }


        public static string GetConfigValue(string key)
        {
            /* go References - Add- System Configuration (come from .Net Framework)*/
            return ConfigurationManager.AppSettings[key];
        }
    }
}

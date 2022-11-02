using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Configuration
{
    public class ConfigReader
    {
        public static string GetAppSettingsValue(string key)
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")[key];
        }

        public static string GetConnectionStringsValue(string key)
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")[key];
        }

    }
}

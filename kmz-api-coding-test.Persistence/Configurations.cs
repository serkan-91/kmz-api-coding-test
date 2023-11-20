using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Persistence
{
    public class Configurations
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath (Path.Combine (Directory.GetCurrentDirectory () , "../kmz-api-coding-test"));
                configurationManager.AddJsonFile ("appsettings.json");

                return configurationManager.GetConnectionString ("MSSQL");
            }
        }
    }
}

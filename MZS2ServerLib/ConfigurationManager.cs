using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using MZS2ServerLib.DataTransferObjects;

namespace MZS2ServerLib
{
    public static class ConfigurationManager
    {
        private static string _connectionString;

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_connectionString))
                {

                    string configFile = "./CSharpClasses/MZS2Configuration.xml";
                    XmlSerializer ser = new XmlSerializer(typeof(ConfigurationFile));
                    StreamReader reader = new StreamReader(configFile);
                    ConfigurationFile settings = (ConfigurationFile)ser.Deserialize(reader);

                    SqlConnectionStringBuilder sqlSb = new SqlConnectionStringBuilder();
                    sqlSb.InitialCatalog = settings.DatabaseCatalog;
                    sqlSb.UserID = settings.DatabaseUsername;
                    sqlSb.Password = settings.DatabasePassword;
                    sqlSb.DataSource = settings.DatabaseIPAddress;

                    _connectionString = sqlSb.ToString();
                }

                return _connectionString;
            }
        }
    }
}

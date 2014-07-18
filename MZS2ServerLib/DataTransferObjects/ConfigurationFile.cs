using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MZS2ServerLib.DataTransferObjects
{
    public class ConfigurationFile
    {
        public string DatabaseIPAddress { get; set; }
        public string DatabaseUsername { get; set; }
        public string DatabasePassword { get; set; }
        public string DatabaseCatalog { get; set; }

        public ConfigurationFile()
        {
        }
    }
}

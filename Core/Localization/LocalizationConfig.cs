using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace Core
{
    public class LocalizationConfig : ConfigurationSection
    {
        [ConfigurationProperty("Language", DefaultValue="lv")]
        public string Language
        {
            get { return (string)this["Language"]; }
            set { this["Language"] = value; }
        }
        [ConfigurationProperty("MappingsFile", DefaultValue="mappings.xml")]
         public string MappingsFile
        {
            get { return (string)this["MappingsFile"]; }
            set { this["MappingsFile"] = value; }
        }

        [ConfigurationProperty("DictionaryFile", DefaultValue = "dictionary.xml")]
        public string DictionaryFile
        {
            get { return (string)this["DictionaryFile"]; }
            set { this["DictionaryFile"] = value; }
        }
	
    }
}

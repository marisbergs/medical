using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Collections;
using System.Collections.Specialized;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TpaisScheduler
{
    [RunInstaller(true)]
    public partial class ConfigFileUpdate : Installer
    {
        public ConfigFileUpdate()
        {
            InitializeComponent();            
        }

        public override void Commit(System.Collections.IDictionary savedState)
        {
            base.Commit(savedState);
            string installDir = Path.GetDirectoryName(this.Context.Parameters["assemblypath"]);

            string hibPath = installDir + @"\hibernate.central.cfg.xml";
            string appConfigPath = installDir + @"\TpaisScheduler.exe.config";
            string dictPath = installDir + @"\Localization\Dictionary.xml";
            XmlDocument doc = new XmlDocument();
            FileStream fs = new FileStream(appConfigPath , FileMode.Open);
            doc.Load(fs);
            fs.Close();
            XmlNode node = doc.SelectSingleNode("configuration/appSettings/add[@key ='hibernate_config_path']");
            node.Attributes["value"].Value = hibPath;

            doc.SelectSingleNode("configuration/Localization").Attributes["DictionaryFile"].Value = dictPath;

            doc.Save(appConfigPath);
        }

    }
}
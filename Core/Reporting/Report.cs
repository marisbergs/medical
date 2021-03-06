using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using NVelocity.Context;
using NVelocity;
using Core.Bll;
using System.Xml;
using System.Windows.Forms;

namespace Core.Reporting
{
    public class Report
    {
        private static IContext aliasContext;
  
        public static void InitAliases( string fileName )
        { 
            XmlReaderSettings readerSettings = new XmlReaderSettings();
            readerSettings.ProhibitDtd = false;
            readerSettings.ValidationType = ValidationType.DTD;

            XmlDocument doc = new XmlDocument();
            XmlReader reader = XmlReader.Create(fileName, readerSettings);
            doc.Load(reader);
            reader.Close();
            Hashtable ht = new Hashtable();
            foreach (XmlNode node in doc.ChildNodes[1])
            {
                if (node.NodeType != XmlNodeType.Element)
                {
                    continue;
                }
                ht.Add (node.Attributes["key"].Value , node.Attributes["value"].Value );
            }
            aliasContext = new VelocityContext(ht);
            
        }
        
        public static bool CreateReport(Stream templateStream, string outputFileName, Hashtable context)
        {
            IContext dataContext = new VelocityContext(context);
            // TODO : move file name to config
            InitAliases(Application.StartupPath + "\\Reporting\\TemplateAliases.xml");          
            bool result = false;
            string str = "";
            try
            {
                string tempFileName = outputFileName + Guid.NewGuid().ToString();
                using (TextWriter sw = new StreamWriter(outputFileName))
                {
                    TextWriter tmp = new StreamWriter(tempFileName);
                    result = NVEngine.Instance.Evaluate(aliasContext, tmp, "", new StreamReader(templateStream));
                    tmp.Close();
#if DEBUG
                    SaveFileDialog sfg = new SaveFileDialog();
                    if (sfg.ShowDialog ()== DialogResult.OK)
                    {
                        File.Copy(tempFileName, sfg.FileName, true);
                    }
#endif
                    result = NVEngine.Instance.Evaluate(dataContext, sw, str, new StreamReader(tempFileName));
                }
            }
            catch (Exception ex)
            {
                throw new CriticalException("Kļūda veidlapas sagatavē! " + ex.ToString(), ex);
            }
            return result;
        }

        public static void RunShell(string command)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = command;
            proc.Start();
        }
    }   
}

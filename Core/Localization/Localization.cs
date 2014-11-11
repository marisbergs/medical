using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Configuration;
using System.Windows.Forms;
using System.Reflection;
using System.Xml.Schema;
using System.IO;

namespace Core
{
    public class Localization
    {
        private static Localization _instance;

        public static Localization Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Localization();
                }
                return _instance;
            }

        }

        private LocalizationConfig m_Config;
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public Dictionary<string, string> Dictionary
        {
            get { return _dictionary; }
        }
      
        public List<LocalizationObject> LocalizationObjects { get;set;} 
        private Localization()
        {
            LocalizationObjects = new List<LocalizationObject>();
            m_Config = (LocalizationConfig)ConfigurationManager.GetSection("Localization");            
            string dictionaryFile = "Core\\Localization\\Dictionary.xml";
            if (m_Config != null)
            {
                dictionaryFile = m_Config.DictionaryFile;
            }
            XmlReaderSettings readerSettings = new XmlReaderSettings();
            readerSettings.ProhibitDtd = false;
            readerSettings.ValidationType = ValidationType.DTD;

            try
            {                
                XmlDocument XMLDictionary = new XmlDocument();
                XmlReader dictionaryReader = XmlReader.Create(dictionaryFile, readerSettings);
                XMLDictionary.Load(dictionaryReader);

                XmlNode dictionaryNode = XMLDictionary.GetElementsByTagName("dictionary")[0];

                if (dictionaryNode == null) return;

                
                _dictionary.Clear();
                foreach (XmlNode dicitionaryEntry in dictionaryNode.ChildNodes)
                {
                    if (!(dicitionaryEntry.NodeType == XmlNodeType.Element)) continue;
                    string key = dicitionaryEntry.Attributes["key"].Value;
                    string value = dicitionaryEntry.Attributes["value"].Value;
                    _dictionary.Add(key, value);
                }
                
            }
            catch (Exception ex)
            {
                throw new CriticalException("Medical", ex);
            }
            
            
        }

        public string TranslateWithDefault(string key, string defaultResult, params object[] parameters)
        {
            var res = SamekletLokalizaciju("xml", key);
            string translatedString;
            
            //returns false if key is not found in the dictionary
            if (res == null)
            {
                translatedString = defaultResult;
            }
            else
            {
                translatedString = res.Aktuala;
            }
            return String.Format(translatedString , parameters);
        }

        public string Translate(string key, params object[] parameters)
        {
            return TranslateWithDefault(key, "?? " + key, parameters);
        }

        public Boolean Contains(string key)
        {
            return _dictionary.ContainsKey(key);
        }

        public string this[string key]
        {
            get
            {
                if (key == null)
                    return "empty localization id!";
                return Translate(key);
            }
        }

        public string this[string key, params object [] parameters ]
        {
           get
           {
               return Translate(key, parameters);
           }
        }
        public Boolean NeedViolations(string propertyName)
        {
            return Contains(propertyName);             
        }
        
        private LocalizationObject SamekletLokalizaciju(string forma, string label)
        {
            foreach (var o in LocalizationObjects)
            {
                if (o.Forma == "xml")
                {
                    if (o.Labels == label)
                        return o;
                }
                if(o.Forma == forma )
                {
                    if(o.Labels==label)
                        return o;
                }
            }
            return null;
        }

        //public void Localize(Control f)
        //{
        //    string fileName = Application.StartupPath + "\\Localization\\" + f.Name + ".xml";
        //    if (!File.Exists(fileName)) return;

        //    XmlDocument formMappings = new XmlDocument();
        //    XmlReader mappingsReader = XmlReader.Create(fileName);
        //    formMappings.Load(mappingsReader);
        //    XmlNode formNode = formMappings.GetElementsByTagName("form")[0];
            
        //    if (formNode == null) return;

        //    foreach (XmlElement mappingNode in formNode.ChildNodes)
        //    {
        //        string propertyPath = mappingNode.Attributes["key"].Value;
        //        string value = mappingNode.Attributes["value"].Value;
        //        ReflectionHelper.SetMemberValue (f, propertyPath, value);
        //    }
        //}
    }

    public class LocalizationObject
    {
        public LocalizationObject(string forma, string labels, string aktuala)
        {
            Forma = forma;
            Labels = labels;
            Aktuala = aktuala;
        }
        public string Forma { get; set; }
        public string Labels { get; set; }
        public string Aktuala { get; set; }
    }

}


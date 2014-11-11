using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;



namespace Core.Dal
{
    /// <summary>
    /// Datu piekļuves līmeņa pārvaldnieks.
    /// </summary>
    public sealed class Manager
    {
        #region Thread-safe singleton
        
        static Manager instance = null;
        static readonly object padlock = new object();

        public static Manager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Manager();
                    return instance;
                }
            }
        }

        public static void SetInstanceNull()
        {
            instance = null;
        }

        #endregion

        private ConnectionTarget _defaultConnectionTarget;

        /// <summary>
        /// Uzstāda noklusēto pieslēgšanās vietu.
        /// </summary>
        /// <param name="target">Serveris, kam pieslēgties.</param>
        public void SetDefaultConnectionTarget(ConnectionTarget target)
        {
            _defaultConnectionTarget = target;
        }

        public static string ConfigFileName(ConnectionTarget target)
        {
            string absolutePath = System.Configuration.ConfigurationManager.AppSettings["hibernate_config_path"];
            if (absolutePath != null) return absolutePath;
            return new StringBuilder("hibernate.")
#if DEBUG
.Append("debug.")
#endif
                        .Append(target.Value.ToString()).Append(".cfg.xml").ToString();
        }

        //when change keys or encrypt decrypt procs, be sure to make the same changes in FileEncryptor project
        private static byte[] desIV = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        private static byte[] desKey = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };


        public static string Encrypt(string PlainText)
        {
            MemoryStream ms = new MemoryStream();
            // Create a CryptoStream using the memory stream and the CSP DES key.  
            CryptoStream encStream = new CryptoStream(ms, (new DESCryptoServiceProvider()).CreateEncryptor(desKey, desIV), CryptoStreamMode.Write);
            // Create a StreamWriter to write a string to the stream.
            StreamWriter sw = new StreamWriter(encStream);

            // Write the plaintext to the stream.
            sw.WriteLine(PlainText);

            // Close the StreamWriter and CryptoStream.
            sw.Flush();
            sw.Close();
            encStream.Close();

            // Get an array of bytes that represents the memory stream.
            byte[] buffer = ms.ToArray();
            ms.Close();

            // Return the encrypted byte array as string
            return Convert.ToBase64String(buffer);
        }

        // Decrypt the byte array.
        public static string Decrypt(string CypherText)
        {
            // Create a memory stream to the passed string converted to byte[] buffer.
            string val;
            if (CypherText == null)
            {
                return null;
            }
            try
            {
                MemoryStream ms = new MemoryStream(Convert.FromBase64String(CypherText));
                // Create a CryptoStream using the memory stream and the CSP DES key. 
                CryptoStream encStream = new CryptoStream(ms, (new DESCryptoServiceProvider()).CreateDecryptor(desKey, desIV), CryptoStreamMode.Read);
                // Create a StreamReader for reading the stream.
                StreamReader sr = new StreamReader(encStream);
                // Read the stream as a string.
                val = sr.ReadLine();

                // Close the streams.
                sr.Close();
                encStream.Close();
                ms.Close();
            }
            catch (FormatException)
            {
                val = CypherText;
            }
            return val;
        }

        public static void EncryptFile(String fileName)
        {
            //Create the streams to handle the input and output
            FileStream inStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader inReader = new StreamReader(inStream);
            FileStream outStream = new FileStream(fileName + "_", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter outWriter = new StreamWriter(outStream);

            while (inReader.Peek() > -1)
            {
                String input = inReader.ReadLine();
                outWriter.WriteLine(Encrypt(input));
            }
            inReader.Close();
            inStream.Close();

            outWriter.Flush();
            outWriter.Close();
            outStream.Close();
            System.IO.File.Replace(fileName + "_", fileName, null);
            System.IO.File.Delete(fileName + "_");
        }

        public static void DecryptFile(String fileName)
        {
            //Create the streams to handle the input and output
            FileStream inStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader inReader = new StreamReader(inStream);
            FileStream outStream = new FileStream(fileName + "_", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter outWriter = new StreamWriter(outStream);

            while (inReader.Peek() > -1)
            {
                String input = inReader.ReadLine();
                outWriter.WriteLine(Decrypt(input));
            }
            inReader.Close();
            inStream.Close();

            outWriter.Flush();
            outWriter.Close();
            outStream.Close();
            File.Replace(fileName + "_", fileName, null);
            File.Delete(fileName + "_");
        }

        private static Stream DecryptConfigFile(String fileName)
        {

            //EventLog.WriteEntry("PreMedic Scheduler file", fileName);
            //Create the streams to handle the input and output
            FileStream inStream;
            if (File.Exists(fileName))
            inStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            else
            inStream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + fileName, FileMode.Open, FileAccess.Read);
            StreamReader inReader = new StreamReader(inStream);
            MemoryStream outStream = new MemoryStream();
            StreamWriter outWriter = new StreamWriter(outStream);

            Boolean? encrypted = null;

            while (inReader.Peek() > -1)
            {
                String input = inReader.ReadLine();
                if (!encrypted.HasValue)
                {
                    // If starts with "<?" then assumes that file is already decrypted
                    encrypted = !input.StartsWith("<?");
                }
                //if just password is encrypted then try to find and decrypt password
                //  outWriter.WriteLine(DecryptConfigLine(input));
                //else decrypte visu
                outWriter.WriteLine(encrypted.Value ? Decrypt(input) : input);
            }
            inReader.Close();
            inStream.Close();

            outWriter.Flush();
            outStream.Position = 0;
            return outStream;
        }

        /// <summary>
        /// Finds and decrypts passwords in the string
        /// If no passwords is found the string is returned unchanged
        /// </summary>
        private static String DecryptConfigLine(String input)
        {
            String encryptedPassword = Regex.Match(input, "Password=(?<pw>[^;]*)").Groups["pw"].Value;
            if (encryptedPassword != "")
            {
                input = Regex.Replace(input, "Password=[^;]*", "Password=" + Decrypt(encryptedPassword));
            }
            return input;
        }

        private IDictionary<ConnectionTarget, NHibernate.ISessionFactory> _sessionFactories;

        public static NHibernate.Cfg.Configuration Configuration(ConnectionTarget target)
        {
            System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(
                      DecryptConfigFile(ConfigFileName(target))
                    );
            return new NHibernate.Cfg.Configuration().Configure(reader);
        }

        private ISessionFactory SessionFactory(ConnectionTarget target)
        {
            if (target == null) return null;
            if (!_sessionFactories.ContainsKey(target))
            {
                string entityAssembly = System.Configuration.ConfigurationManager.AppSettings["EntityAssembly"];
                if (entityAssembly == null)
                {
                    throw new CriticalException();
                }
                NHibernate.Cfg.Configuration config = Configuration(target);
                config.AddAssembly(entityAssembly);
                _sessionFactories[target] = config.BuildSessionFactory();
            }
            return (ISessionFactory)_sessionFactories[target];
        }

        private IDictionary<NHibernate.ISession, ISession> _sessionWrappers;

        /// <summary>
        /// Atver jaunu sessiju.
        /// </summary>
        /// <param name="target">Serveris, pie kura slēgties.</param>
        /// <returns>Sessija</returns>
        public ISession OpenSession(ConnectionTarget target)
        {
            IInterceptor interceptor = new Interceptor();
            NHibernate.ISession hsession = SessionFactory(target).OpenSession(interceptor);
            ISession result = new Session(hsession, interceptor);
            result.FlushMode = FlushMode.Commit;
            _sessionWrappers.Add(hsession, result);
            return result;
        }

        /// <summary>
        /// Atver jaunu sessiju.
        /// Tiks izmantots serveris, kas norādīts ar <seealso cref="SetDefaultConnectionTarget(ConnectionTarget)"/>.
        /// </summary>
        /// <returns>Sessija</returns>
        public ISession OpenSession()
        {
            return OpenSession(_defaultConnectionTarget);
        }

        internal ISession GetSessionWrapper(NHibernate.ISession hsession)
        {
            if (_sessionWrappers.ContainsKey(hsession))
                return _sessionWrappers[hsession];
            else
                return null;
        }

        internal void RegisterSessionWrapper(NHibernate.ISession hsession, ISession session)
        {
            _sessionWrappers[hsession] = session;
        }


        internal bool UnregisterSessionWrapper(NHibernate.ISession hsession)
        {
            return _sessionWrappers.Remove(hsession);
        }

        internal IList<NHibernate.ISession> GetSisterSessions(NHibernate.ISession hsession)
        {
            List<NHibernate.ISession> result = new List<NHibernate.ISession>(10);
            NHibernate.ISessionFactory mother = hsession.SessionFactory;
            foreach (NHibernate.ISession s in _sessionWrappers.Keys)
            {
                if (s.IsOpen && s != hsession && s.SessionFactory == mother)
                {
                    result.Add(s);
                }
            }
            return result;
        }

        internal IList<Core.Dal.ISession> GetCoreSisterSessions(NHibernate.ISession hsession)
        {
            List<Core.Dal.ISession> result = new List<Core.Dal.ISession>(10);
            NHibernate.ISessionFactory mother = hsession.SessionFactory;
            foreach (Core.Dal.ISession s in _sessionWrappers.Values)
            {
                if (s.IsOpen && s != hsession && s.SessionFactory == mother)
                {
                    result.Add(s);
                }
            }
            return result;
        }

        private Manager()
        {
            _sessionFactories = new Dictionary<ConnectionTarget, NHibernate.ISessionFactory>(Enum.GetNames(typeof(ConnectionTargetEnum)).Length);
            _sessionWrappers = new Dictionary<NHibernate.ISession, ISession>(10);
        }
    }
    
}

// Lūdzu, Юникод
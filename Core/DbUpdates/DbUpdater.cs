using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;
using Core.Dal;

namespace Core.DbUpdates
{
    public class UpdateProgressEventArgs : EventArgs
    {
        public int currentStep = 0;
        public string progressText = "";

        public UpdateProgressEventArgs(int step, string text)
        {
            currentStep = step;
            progressText = text;
        }
    }

    public delegate void UpdateProgressEventHandler(object sender, UpdateProgressEventArgs e);

    /// <summary>
    /// provides functionality to perfom local DB updates, using *.sql update scripts
    /// installed in .\DbUpdates directory 
    /// </summary>
    public class DbUpdater
    {
        public const string LOCAL_DB_VERSION_PARAM = "VERSION_LOCAL_DB";

        /// <summary>
        /// is used to compare two FileInfo objects in reverse order
        /// </summary>
        private class myFileInfoComparer : System.Collections.IComparer
        {
            // compares skript files by their number
            int System.Collections.IComparer.Compare(Object x, Object y)
            {
                int xVer = VersionNumberFromFileName(((FileInfo)x).Name);
                int yVer = VersionNumberFromFileName(((FileInfo)y).Name);
                if (xVer > yVer) return 1;
                else if (xVer < yVer) return -1;
                else return 0;
            }
        }

        private Dictionary<ConnectionTarget, SqlConnection> _connections =
            new Dictionary<ConnectionTarget, SqlConnection>();


        private SqlConnection Connection(ConnectionTarget target)
        {
            if (!_connections.ContainsKey(target))
            {
                SqlConnection Conn = new System.Data.SqlClient.SqlConnection(ConnectString(target));                
                _connections.Add(target, Conn);
                Conn.Open();
            }
            return _connections[target];
        }

        private void CloseConnections()
        {
            foreach (KeyValuePair<ConnectionTarget, SqlConnection> kvp in _connections)
            {
                if (kvp.Value.State == System.Data.ConnectionState.Open) kvp.Value.Close();
            }
        }

        private string ConnectString(ConnectionTarget target)
        {
            NHibernate.Cfg.Configuration config = Manager.Configuration(target);

            string result = config.GetProperty("connection.connection_string");
            return result;
        }

        private int VersionFromDb(ConnectionTarget target)
        {
            SqlCommand Cmd = Connection(target).CreateCommand();
            Cmd.CommandTimeout = 600;
            Cmd.CommandText = "SELECT PRM_VALUE FROM _SysParameters WHERE PRM_NAME = '" + LOCAL_DB_VERSION_PARAM + "'";
            return int.Parse(Cmd.ExecuteScalar().ToString());
        }

        private int _currentLocalDbVersion = 0;

        /// <summary>
        /// current version of local DB
        /// </summary>
        public int CurrentLocalDBVersion
        {
            get
            {
                if (_currentLocalDbVersion == 0)
                    _currentLocalDbVersion = VersionFromDb(ConnectionTarget.Local);
                return _currentLocalDbVersion;
            }
        }

        /// <summary>
        /// latest version from the DB update scripts
        /// </summary>
        public int RequiredDbVersion
        {
            get
            {
                return VersionFromUpdateScripts();
            }
        }

        /// <summary>
        /// perfroms local DB update, executing all required sql skripts
        /// </summary>
        public void UpdateLocalDb()
        {
            try
            {
                if (UpdateNeeded())
                {
                    BackupLocalDB();
                    int currentVersion = CurrentLocalDBVersion;
                    int requiredVersion = RequiredDbVersion;
                    try
                    {
                        ExecuteUpdateScripts(currentVersion, requiredVersion);
                    }
                    catch (Exception e)
                    {
                        try
                        {
                            RestoreLocalDBFromBackup();
                        }
                        finally
                        {
                            //auditu par kļûdu veidojam vienmēr
                            Logger.DB.LogImmediate(Core.AuditMessages.LocalDBUpdateFailure, currentVersion, requiredVersion, e.ToString());
                        }
                        //auditu par restore veidojam, tikai tad, ja restore pabeidzas veiksmīgi
                        Logger.DB.LogImmediate(Core.AuditMessages.LocalDBRestoredFromBackup);
                        throw e;
                    }
                    Logger.DB.LogImmediate(Core.AuditMessages.LocalDBUpdateSuccess, currentVersion, requiredVersion);
                }
            }
            finally
            {
                CloseConnections();
            }
        }

        /// <summary>
        /// checks, whether the local DB needs updates
        /// </summary>
        public bool UpdateNeeded()
        {
            return (RequiredDbVersion > CurrentLocalDBVersion);
        }

        private string _localDbName = "";

        public string LocalDBName
        {
            get
            {
                if (_localDbName == "")
                    _localDbName = Regex.Match(ConnectString(ConnectionTarget.Local), "Initial Catalog=(?<db>[^;]*)").Groups["db"].Value;
                return _localDbName;
            }
        }

        private void BackupLocalDB()
        {
            string msg = Core.Localization.Instance.TranslateWithDefault("DbUpdater.CreatingDBBackup", "Veidojam DB rezerves kopiju...");
            OnUpdateProgress(new UpdateProgressEventArgs(0, msg));
            SqlCommand Cmd = Connection(ConnectionTarget.Local).CreateCommand();
            Cmd.CommandTimeout = 600;
            string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string backupFileName = appPath + "\\" + LocalDBName + "_BACKUP";
            if (File.Exists(backupFileName))
            {
                File.Delete(backupFileName);
            }
            Cmd.CommandText = "backup database " + LocalDBName + " to DISK='" + backupFileName + "' ";
            Cmd.ExecuteNonQuery();
        }

        private void RestoreLocalDBFromBackup()
        {
            string msg = Core.Localization.Instance.TranslateWithDefault("DbUpdater.RestoringDBFromBackup", "Notika kļûda. Atjaunojam Db no rezerves kopijas...");
            OnUpdateProgress(new UpdateProgressEventArgs(0, msg));
            SqlCommand Cmd = Connection(ConnectionTarget.Local).CreateCommand();
            Cmd.CommandTimeout = 600;
            string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            Cmd.CommandText = "use master";
            Cmd.ExecuteNonQuery();
            Cmd.CommandText = "restore database " + LocalDBName + " from DISK='" + appPath + "\\" + LocalDBName + "_BACKUP' ";
            Cmd.ExecuteNonQuery();
            msg = Core.Localization.Instance.TranslateWithDefault("DbUpdater.DBRestoredFromBackup", "Notika kļûda. DB atjaunota no rezerves kopijas.");
            OnUpdateProgress(new UpdateProgressEventArgs(0, msg));
        }

        private void ExecuteUpdateScripts(int currentVersion, int requiredVersion)
        {
            string msg = "";

            foreach (FileInfo file in updateScripts)
            {
                int fileVersion = VersionNumberFromFileName(file.Name);
                if ((fileVersion > currentVersion) && (fileVersion <= requiredVersion))
                {
                    msg = Core.Localization.Instance.TranslateWithDefault("DbUpdater.ExecutingFile", "Izpildam {0}", file.Name);
                    OnUpdateProgress(new UpdateProgressEventArgs(fileVersion, msg));
                    SqlCommand Cmd = Connection(ConnectionTarget.Local).CreateCommand();
                    Cmd.CommandTimeout = 600;
                    string[] commands = (file.OpenText().ReadToEnd() + "\r\n").Split(new string[] { "\r\nGO\r\n", "\r\ngo\r\n", "\r\nGo\r\n", "\r\ngO\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    if (commands != null)
                    {
                        foreach (string cmd in commands)
                        {
                            Cmd.CommandText = cmd;
                            try
                            {
                                Cmd.ExecuteNonQuery();
                            }
                            catch (Exception e)
                            {
                                throw new Exception(Core.Localization.Instance.TranslateWithDefault("DbUpdater.ErrorExecuting", "Kļûda izpildot {0}: {1}", file.Name, e.Message));
                            }
                        }
                    }
                }
            }
        }

        private FileInfo[] _updateScripts;

        private FileInfo[] updateScripts
        {
            get
            {
                if (_updateScripts == null)
                {
                    DirectoryInfo dir = new DirectoryInfo(".\\DbUpdates");
                    _updateScripts = dir.GetFiles("*.sql", SearchOption.TopDirectoryOnly);
                    if (_updateScripts.Length > 0)
                        Array.Sort(_updateScripts, new myFileInfoComparer());
                }
                return _updateScripts;
            }
        }

        /// <summary>
        /// returns the biggest version number from the update scripts
        /// </summary>
        private int VersionFromUpdateScripts()
        {
            int version = 0;
            if (updateScripts.Length > 0)
            {
                //updateScripts is sorted, so, take the last one
                string fileName = updateScripts[updateScripts.Length - 1].Name;
                version = VersionNumberFromFileName(fileName);
            }
            return version;
        }

        private static int VersionNumberFromFileName(string fileName)
        {
            string version = fileName.Split(new Char[] { '.' }, 2)[0];
            return int.Parse(version);
        }

        public event UpdateProgressEventHandler UpdateProgress;

        protected virtual void OnUpdateProgress(UpdateProgressEventArgs e)
        {
            if (UpdateProgress != null)
                UpdateProgress(this, e);
        }
    }
}

using NVelocity;
using System.IO;
using System.Windows.Forms;

namespace Core
{
    public class NVEngine
    {
        static readonly object mutex = new object();
        private static NVelocity.App.VelocityEngine _instance = null;

        public static NVelocity.App.VelocityEngine Instance
        {
            get
            {
                lock (mutex)
                {
                    if (_instance == null)
                    {
                       _instance = new NVelocity.App.VelocityEngine();
                        // Workaround
                        string currentDirectory = Directory.GetCurrentDirectory();
                        try
                        {
                            Directory.SetCurrentDirectory(Application.StartupPath);
                            _instance.Init();
                        }
                        finally
                        {
                            Directory.SetCurrentDirectory(currentDirectory);
                        }
                    }
                    return _instance;
                }
            }
        }
    }   
}

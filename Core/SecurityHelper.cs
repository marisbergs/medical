using System.Security.Principal;
using System;
using System.ComponentModel;


namespace Core
{
    public static class SecurityHelper
    {
        private enum LogonType :uint
        {
            LOGON32_LOGON_INTERACTIVE = 2,
            LOGON32_LOGON_NETWORK = 3,
            LOGON32_LOGON_BATCH = 4,
            LOGON32_LOGON_SERVICE = 5,
            LOGON32_LOGON_UNLOCK = 7,
            LOGON32_LOGON_NETWORK_CLEARTEXT = 8,
            LOGON32_LOGON_NEW_CREDENTIALS = 9
        }

        private enum LogonProvider :uint
        {
            LOGON32_PROVIDER_DEFAULT = 0,
            LOGON32_PROVIDER_WINNT35 = 1,
            LOGON32_PROVIDER_WINNT40 = 2,
            LOGON32_PROVIDER_WINNT50 = 3
        }

        [System.Runtime.InteropServices.DllImport("advapi32.dll")]
        private static extern bool LogonUser(
            string lpszUsername,
            string lpszDomain,
            string lpszPassword,
            uint dwLogonType,
            uint dwLogonProvider,
            out IntPtr phToken);

        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        private static extern bool CloseHandle(IntPtr handle);


        public static bool ValidatePassword(string username, string password)
        {
            // Extract domain name from username
            string[] parts = username.Split('\\');
            if (parts.Length != 2) return false;
            IntPtr phToken;
            bool result = LogonUser(parts[1], parts[0], password, (uint)LogonType.LOGON32_LOGON_NETWORK, (uint)LogonProvider.LOGON32_PROVIDER_DEFAULT, out phToken);
            CloseHandle(phToken);
            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dal
{
    /// <summary>
    /// Pieslēguma vietu kodi
    /// </summary>
    public enum ConnectionTargetEnum
    {
        /// <summary>
        /// Lokālā datubāze. Konfigurāciju ņems no "hibernate.Local.cfg.xml".
        /// </summary>
        Local = 0,
        /// <summary>
        /// Centrālais serveris. Konfigurāciju ņems no "hibernate.Central.cfg.xml".
        /// </summary>
        Central = 1
    }


    /// <summary>
    /// Pieslēguma vietas
    /// </summary>
    public class ConnectionTarget : EnumWrapper<ConnectionTargetEnum>
    {
        public ConnectionTarget()
            : base()
        {
        }

        public ConnectionTarget(ConnectionTargetEnum value)
            : base(value)
        {
        }

        /// <summary>
        /// Lokālā datubāze. Konfigurāciju ņems no "hibernate.Local.cfg.xml".
        /// </summary>
        public static readonly ConnectionTarget Local = new ConnectionTarget(ConnectionTargetEnum.Local);
        /// <summary>
        /// Centrālais serveris. Konfigurāciju ņems no "hibernate.Central.cfg.xml".
        /// </summary>
        public static readonly ConnectionTarget Central = new ConnectionTarget(ConnectionTargetEnum.Central);

        public new static System.Collections.IList ListSource
        {
            get
            {
                if (_listHolder == null)
                {
                    _listHolder = new System.Collections.ArrayList(2);
                    _listHolder.Add(Central);
                    _listHolder.Add(Local);
                }
                return _listHolder;
            }
        }
    }
}

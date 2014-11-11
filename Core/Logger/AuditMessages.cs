using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    /// <summary>
    /// Core Notikumu veidi (notikumu žurnālam)
    /// </summary>
    public class AuditMessages
    {
        public static Guid LocalDBUpdateSuccess = new Guid("4043dacd-8302-416d-b692-9250f67c0a69");
        public static Guid LocalDBUpdateFailure = new Guid("1b336b21-3a62-4cf6-9962-941971db44b0");
        public static Guid LocalDBRestoredFromBackup = new Guid("66e7a5d8-494c-4e05-88dc-8eb23ff8fc85");
    }
}

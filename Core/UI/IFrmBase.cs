using System;
namespace Core.UI
{
    interface IFrmBase
    {
        void AcceptChanges();
        void MakeReadOnly();
        Core.Dal.ISession PartnerSession { get; set; }
        void RejectChanges();
        Core.Dal.ISession Session { get; set; }
    }
}

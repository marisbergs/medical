using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Controls;

namespace Core.UI
{
    public class DevExpressLocalizer : DevExpress.XtraEditors.Controls.Localizer
    {
        public override string GetLocalizedString(StringId id)
        { 
            return Core.Localization.Instance.Translate("DevEx." + id.ToString());
        }

    }
}

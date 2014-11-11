using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Threading;
using System.Globalization;

public partial class Master : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CultureInfo tr = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        DateTimeFormatInfo dtfi = tr.DateTimeFormat;;
        dtfi.SetAllDateTimePatterns(new String[] {"dd.MM.yyyy"}, 'd');
        dtfi.SetAllDateTimePatterns(new String[] {"yyyy'.gada 'd.MMMM"}, 'D');
        dtfi.DateSeparator = ".";
        dtfi.SetAllDateTimePatterns(new String[] {"HH:mm"}, 'T');

        Thread.CurrentThread.CurrentCulture = tr;
    }
}

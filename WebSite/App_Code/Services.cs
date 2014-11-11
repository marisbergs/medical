using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Entities;
using Core.Bll;
using Core.Dal;

/// <summary>
/// Summary description for Services
/// </summary>
public class Services : Entities.Services
{
	public Services()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public Entities<Services> GetServicesForInternet()
    {
        ConnectionTarget target = ConnectionTarget.Central;
        Manager.Instance.SetDefaultConnectionTarget(target);
        ISession session = Manager.Instance.OpenSession();
        Entities<Services> result;
        result = Entities<Services>.GetAll(session);
            //new Core.Dal.Expressions.Eq("Mark", true));

        return result;
    }
}

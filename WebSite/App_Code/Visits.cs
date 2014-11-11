using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using Entities;
using Core.Bll;
using Core.Dal;

/// <summary>
/// Summary description for Visits
/// </summary>
public class Visits : TimeTable
{
	public Visits()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public List<TimeTable> GetTime()
    {
        List<TimeTable> result = new List<TimeTable>();

        return result;
    }

}

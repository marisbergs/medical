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
using Core.Dal;
using Core.Bll;
using Entities;

public partial class loging : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            txtUsername.Focus();
    }
    protected void cmdLogin_Click(object sender, EventArgs e)
    {
        ConnectionTarget target = ConnectionTarget.Central;
        Manager.Instance.SetDefaultConnectionTarget(target);
        ISession session = Manager.Instance.OpenSession();
        Entities<Patient> pt = Entities<Patient>.GetAll(session,
            new Core.Dal.Expressions.Eq("Number", txtUsername.Text.Trim().Replace("'", "''")),
            new Core.Dal.Expressions.Eq("Password", txtPassword.Text.Trim().Replace("'", "''")));
        if (pt.Count > 0)
        {
            FormsAuthentication.Authenticate("","");
            Session.Add("Id", pt[0].Id);
            FormsAuthentication.RedirectFromLoginPage(pt[0].Number, true);
            Server.Transfer("~/Default.aspx");
        }
        else
        {
            lblError.Text = "Kïudaina parole vai klienta numurs.";
        }
    }
}

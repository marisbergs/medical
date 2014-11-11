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
using Entities;
using Core.Dal;
using Core.Bll;

public partial class registration_psw : System.Web.UI.Page
{
    ISession session = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString.Get("Id") == null)
                Server.Transfer("~/loging.aspx");
            else
                txtId.Value = Request.QueryString.Get("Id");

            ConnectionTarget target = ConnectionTarget.Central;
            Manager.Instance.SetDefaultConnectionTarget(target);
            session = Manager.Instance.OpenSession();
            Patient pt = session.Get<Patient>(new Guid(Request.QueryString.Get("Id")));
            txtUserName.Text = pt.Number;
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        ConnectionTarget target = ConnectionTarget.Central;
        Manager.Instance.SetDefaultConnectionTarget(target);
        session = Manager.Instance.OpenSession();
        Patient patient = session.Get<Patient>(new Guid(txtId.Value));
        patient.Password = txtPassword.Text.Trim();
        session.SaveOrUpdate(patient);
        session.Commit();
        if ((DateTime.Now.Year - patient.BirthDate.Value.Year) > 18)
        {
            FormsAuthentication.RedirectFromLoginPage(txtUserName.Text.Trim(), true);
        }
        else
        {
            Server.Transfer("~/registration/guardian.aspx?id=" + patient.Id.ToString());
        }
    }
}

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

public partial class guardian : System.Web.UI.Page
{
    ISession session = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString.Get("Id") == null)
                Server.Transfer("~/Login.aspx");
            else
                txtId.Value = Request.QueryString.Get("Id");
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        ConnectionTarget target = ConnectionTarget.Central;
        Manager.Instance.SetDefaultConnectionTarget(target);
        session = Manager.Instance.OpenSession();
        Patient pt = session.Get<Patient>(new Guid(txtId.Value));

        Guardian guardian = new Guardian();
        guardian.Patient = pt;
        guardian.Name = txtName.Text.Trim();
        guardian.Surname = txtSurname.Text.Trim();
        if (rbtMother.Checked)
            guardian.Type = Entities.GuardianType.Mother;
        else if (rbtFather.Checked)
            guardian.Type = Entities.GuardianType.Father;
        else
            guardian.Type = Entities.GuardianType.Guardian;
        guardian.Code = txtCode.Text.Trim();
        guardian.Address = txtAddress.Text.Trim();
        guardian.Mail = txtMail.Text.Trim();
        guardian.MobilePhone = txtMobilePhone.Text.Trim();
        //if ((DateTime.Now.Year - patient.BirthDate.Value.Year) > 18)
        //{
            session = Manager.Instance.OpenSession();
            session.SaveOrUpdate(guardian);
            session.Commit();
            FormsAuthentication.RedirectFromLoginPage("loging", true);
            Server.Transfer("~/Default.aspx");
        //}
        //else
        //{
        //    session = Manager.Instance.OpenSession();
        //    session.SaveOrUpdate(patient);
        //    session.Commit();
        //    Server.Transfer("guardian.aspx?id=" + patient.Id.ToString());
        //}
    }
}

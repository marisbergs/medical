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

public partial class registration : System.Web.UI.Page
{
    ISession session = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //ConnectionTarget target = ConnectionTarget.Central;
            //Manager.Instance.SetDefaultConnectionTarget(target);
            //session = Manager.Instance.OpenSession();
            //Patient pt = session.Get<Patient>(new Guid("EEE2371D-59EF-4299-B558-9A32000F9F60"));
            //if (pt != null)
            //{
            //    txtAddress.Text = pt.Address;
            //    txtName.Text = pt.Name;
            //    txtSurname.Text = pt.Surname;
            //    txtCode.Text = pt.Code;
            //    txtMail.Text = pt.Mail;
            //    txtMobilePhone.Text = pt.Phone;
            //    dtpBirthDay.Date = pt.BirthDate.Value;
            //    rbtM.Checked = true;
            //    txtUserName.Text = pt.Username;
            //    txtPassword.Text = pt.Password;
            //    txtSeccondPasword.Text = pt.Password;
            //    Server.Transfer("~/registration/guardian.aspx?id=" + pt.Id.ToString());
            //}
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (rbtF.Checked || rbtM.Checked)
            lblValidateSex.Visible = false;
        else
        {
            lblValidateSex.Visible = true;
            return;
        }

        Patient patient = new Patient();
        patient.Name = txtName.Text.Trim();
        patient.Surname = txtSurname.Text.Trim();
        if (rbtF.Checked)
            patient.Sex = Entities.Sex.Female;
        else
            patient.Sex = Entities.Sex.Male;
        patient.Code = txtCode.Text.Trim();
        patient.Address = txtAddress.Text.Trim();
        DateTime date;
        if (DateTime.TryParse(dtpBirthDay.Date.ToString(), out date))
            patient.BirthDate = date;
        else
            System.Windows.Forms.MessageBox.Show("Ievadîtais datums neatbilst prasîbâm.");
        if (patient.BirthDate > DateTime.Now)
        {
            lblInvalidDate.Text = "Dzimðanas datums nevar bût lielâks par ðodienu.";
            return;
        }
        else
        {
            lblInvalidDate.Text = "";
        }
        patient.Mail = txtMail.Text.Trim();
        patient.Phone = txtMobilePhone.Text.Trim();

        if (patient.BirthDate.HasValue)
        {
            ConnectionTarget target = ConnectionTarget.Central;
            Manager.Instance.SetDefaultConnectionTarget(target);
            session = Manager.Instance.OpenSession();
            // pârbaudam vai nav pacients ar ðâdu personas kodu jau nav reìistrçjies
            Entities<Patient> patients = Entities<Patient>.GetAll(session, new Core.Dal.Expressions.Eq("Code", txtCode.Text.Trim()));
            if (patients.Count > 0)
            {
                lblErrorText.Text = "Pacients ar ðadu personas kodu jau ir reìistrçts.";
                return;
            }
            patient.SetNumber(session);
            session.SaveOrUpdate(patient);
            session.Commit();
            Session.Add("Id", patient.Id);
            Server.Transfer("~/registration/psw.aspx?id=" + patient.Id.ToString());            
        }

        
    }
}

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
using Core.Bll;
using Core.Dal;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page
{
    public Entities.Services service = null;
    private TableCell doctorAddres;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ConnectionTarget target = ConnectionTarget.Central;
            Manager.Instance.SetDefaultConnectionTarget(target);
            ISession session = Manager.Instance.OpenSession();
            cmbGroup.DataSource = Entities<Entities.Speciality>.GetAllOrderBy(session, new NHibernate.Expression.Order("Value", true),
                new Core.Dal.Expressions.Eq("Mark", true), new Core.Dal.Expressions.IsNull("DeleteTime"));
            cmbGroup.DataBind();

            if (cmbGroup.Items.Count > 0 && cmbGroup.SelectedIndex>=0)
            {
                Speciality sp = session.Get<Speciality>(new Guid(cmbGroup.SelectedValue.ToString())); 

                cmbService.DataSource = sp.Services.ActiveItemsWithoutEmpty;
                cmbService.DataBind();
            }

            if (cmbService.Items.Count > 0)
                txtService.Text = cmbService.Items[0].Text;

            Entities<Entities.User> res = new Entities<Entities.User>();
            Entities.User user = new Entities.User(session);
            user.FirstName = "(Visi)";
            user.LastName = "";
            res.Add(user);
            Entities<Entities.User> result = Entities<Entities.User>.GetAllOrderBy(session,
               new NHibernate.Expression.Order[] { new NHibernate.Expression.Order("FirstName", true), new NHibernate.Expression.Order("LastName", true) },
               new Core.Dal.Expressions.Eq("UserServices.Service.Id", new Guid(cmbService.SelectedItem.Value)),
               new Core.Dal.Expressions.IsNull("DeleteTime"));
            foreach (Entities.User var in result)
            {
                res.Add(var);
            }
            cmbDoctor.DataSource = res;
            cmbDoctor.DataBind();

            grdVisits.Columns[0].ItemStyle.Width = 130;
            grdVisits.Columns[0].ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            grdVisits.Columns[1].ItemStyle.Width = 130;
            grdVisits.Columns[1].ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            grdVisits.Columns[2].ItemStyle.Width = 130;
            grdVisits.Columns[2].ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            grdVisits.Columns[3].ItemStyle.Width = 130;
            grdVisits.Columns[3].ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            grdVisits.Columns[4].ItemStyle.Width = 130;
            grdVisits.Columns[4].ItemStyle.HorizontalAlign = HorizontalAlign.Center;
            grdVisits.Columns[5].ItemStyle.Width = 130;
            grdVisits.Columns[5].ItemStyle.HorizontalAlign = HorizontalAlign.Center;
        }
        if (Session["Id"] == null || Session["Id"].ToString() == Guid.Empty.ToString())
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
        Button1.Attributes.Add("onclick", "return Question();");
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        if (cmbService.SelectedItem == null || cmbDoctor.SelectedItem == null)
        {
            grdVisits.DataSource = new Entities<TimeTable>();
            grdVisits.DataBind();
            return;
        }
        ConnectionTarget target = ConnectionTarget.Central;
        Manager.Instance.SetDefaultConnectionTarget(target);
        ISession session = Manager.Instance.OpenSession();
        DateTime startDate;
        if (calendar.SelectedDate == new DateTime(1,1,1))
        {
            startDate = DateTime.Now.Date;
            calendar.SelectedDate = startDate;
        }
        else
        {
            startDate = calendar.SelectedDate;
        }
        if ((int)startDate.DayOfWeek > 1)
            startDate = startDate.AddDays(-(int)startDate.DayOfWeek+1);
        else if (startDate.DayOfWeek == 0)
            startDate = startDate.AddDays(-6);

        grdVisits.Columns[0].HeaderText = startDate.ToShortDateString();
        grdVisits.Columns[1].HeaderText = startDate.AddDays(1).ToShortDateString();
        grdVisits.Columns[2].HeaderText = startDate.AddDays(2).ToShortDateString();
        grdVisits.Columns[3].HeaderText = startDate.AddDays(3).ToShortDateString();
        grdVisits.Columns[4].HeaderText = startDate.AddDays(4).ToShortDateString();
        grdVisits.Columns[5].HeaderText = startDate.AddDays(5).ToShortDateString();

        service = session.Get<Entities.Services>(new Guid(cmbService.SelectedItem.Value));
        Guid userId = new Guid(cmbDoctor.SelectedItem.Value);
        User doctor = null;
        if (userId != Guid.Empty)
        {
            doctor = session.Get<User>(userId);
        }

        SortedDictionary<User, Entities<TimeTable>> list = new SortedDictionary<User, Entities<TimeTable>>();
        Dictionary<DayEnum, Dictionary<User, SortedDictionary<DateTime, object>>> murgs = new Dictionary<DayEnum, Dictionary<User, SortedDictionary<DateTime, object>>>();
        murgs.Add(DayEnum.Monday, new Dictionary<User,SortedDictionary<DateTime,object>>());
        murgs.Add(DayEnum.Tuesday, new Dictionary<User,SortedDictionary<DateTime,object>>());
        murgs.Add(DayEnum.Wednesday, new Dictionary<User,SortedDictionary<DateTime,object>>());
        murgs.Add(DayEnum.Thursday, new Dictionary<User,SortedDictionary<DateTime,object>>());
        murgs.Add(DayEnum.Friday, new Dictionary<User,SortedDictionary<DateTime,object>>());
        murgs.Add(DayEnum.Saturday, new Dictionary<User,SortedDictionary<DateTime,object>>());
        //atlasam visu plânu
        Entities<TimeTable> dataSource = Entities.Visit.GetData(session, startDate, 6, service, doctor);
        
        //izòemam ârâ viziîtes ja tâs nav lietotâja
        //un savâcam pârçjo darba laiku informâciju
        foreach (TimeTable obj in dataSource)
        {
            foreach (Day var in Entities.Day.ListSource)
            {
                //noklusçtais vizîtes ilgums
                int defaultVisitLength = service.IntegerValue.Value;

                // atrodam katra ieraksta dienas vçrtîbas
                object tempValue = Core.ReflectionHelper.GetPropertyValue(obj, Enum.GetName(typeof(DayEnum), var.Value) + "Value");
                if (tempValue != null)
                {
                    //ja tips ir vizîte
                    if (tempValue is Visit)
                    {
                        Visit visit = tempValue as Visit;
                        // salîdzinam vai ir tekoðâ lietotâja vizîte  ja nav tad dzçðam
                        if (visit.Patient.Id.ToString() != Session["Id"].ToString())
                        {
                            Core.ReflectionHelper.SetPropertyValue(obj, Enum.GetName(typeof(DayEnum), var.Value) + "Value", null);
                        }
                        else
                        {
                            if (!murgs[var.Value].ContainsKey(visit.Doctor))
                            {
                                murgs[var.Value].Add(visit.Doctor, new SortedDictionary<DateTime, object>());
                            }
                            murgs[var.Value][visit.Doctor].Add(visit.StartTime, visit);
                        }
                    }
                    if (tempValue is WorkTime)
                    {
                        WorkTime workTime = tempValue as WorkTime;
                        UserService us = null;
                        //atrodam lietotâja atbilstoðo pakalpojumu lai zinâtu laiku
                        foreach (UserService userService in workTime.User.UserServices)
                        {
                            if (userService.Service.Id == service.Id)
                            {
                                us = userService;
                                break;
                            }
                        }
                        //ja lietotâjam ir ðâds pakalpojums 
                        if (us != null)
                        {
                            //pârbaudam vai ârstam nav mainîts vizîtes ilgums
                            if (us.ManualTime.HasValue)
                            {
                                defaultVisitLength = us.ManualTime.Value;
                            }

                            //atrodam brîvâ laika ilgumu
                            double len = workTime.EndTime.TimeOfDay.TotalMinutes - workTime.StartTime.TimeOfDay.TotalMinutes;

                            //ja pieejamais laiks ir îsâks par vizîti tad òemam nâkamo
                            if (len < defaultVisitLength)
                            {
                                continue;
                            }
                            //pieliekam useri
                            if (!murgs[var.Value].ContainsKey(workTime.User))
                            {
                                murgs[var.Value].Add(workTime.User, new SortedDictionary<DateTime, object>());
                            }

                            // ja ilgumâ neietilpst 2 vizîtes tad piedâvâjam sâkuma laiku
                            if (len < defaultVisitLength * 2)
                            {
                                workTime.EndTime = workTime.StartTime.AddMinutes(defaultVisitLength);
                                murgs[var.Value][workTime.User].Add(workTime.StartTime, workTime);
                                continue;
                            }

                            //izveidojam jaunu laiku priekð beigâm
                            WorkTime newWorkTime = new WorkTime(session, workTime.StartTime);
                            newWorkTime.User = workTime.User;
                            newWorkTime.StartTime = workTime.EndTime.AddMinutes(-defaultVisitLength);
                            newWorkTime.EndTime = workTime.EndTime;
                            newWorkTime.FromUserWorkTime = workTime.FromUserWorkTime;
                            newWorkTime.UserWorkTime = workTime.UserWorkTime;
                            newWorkTime.Acity = workTime.Acity;
                            newWorkTime.Room = workTime.Room;
                            newWorkTime.Id = workTime.Id;

                            workTime.EndTime = workTime.StartTime.AddMinutes(defaultVisitLength);
                            murgs[var.Value][workTime.User].Add(workTime.StartTime, workTime);
                            murgs[var.Value][workTime.User].Add(newWorkTime.StartTime, newWorkTime);
                            
                        }
                    }
                }
            }
            
        }
        foreach (KeyValuePair<DayEnum, Dictionary<User, SortedDictionary<DateTime, object>>> var in murgs)
        {
            foreach (KeyValuePair<User, SortedDictionary<DateTime, object>> user in var.Value)
            {
                if (!list.ContainsKey(user.Key))
                {
                    list.Add(user.Key, new Entities<TimeTable>());
                }
            }
        }

        Entities<TimeTable> dataSourceNew = new Entities<TimeTable>();

        foreach (KeyValuePair<User, Entities<TimeTable>>  obj in list)
        {
            TimeTable tb = new TimeTable();
            tb.Doctor = obj.Key;
            tb.ForHeder = true;
            dataSourceNew.Add(tb);

            foreach (KeyValuePair<DayEnum, Dictionary<User, SortedDictionary<DateTime, object>>> var in murgs)
            {
                foreach (KeyValuePair<User, SortedDictionary<DateTime, object>> user in var.Value)
                {
                    if (obj.Key.Id == user.Key.Id)
                    {
                        foreach (KeyValuePair<DateTime, object> val in user.Value)
                        {
                            bool added = false;
                            foreach (TimeTable tt in dataSourceNew)
                            {
                                if (tt.ForHeder == false && tt.Doctor.Id ==user.Key.Id)
                                {
                                    object tempValue = Core.ReflectionHelper.GetPropertyValue(tt, Enum.GetName(typeof(DayEnum), var.Key) + "Value");
                                    if (tempValue == null)
                                    {
                                        Core.ReflectionHelper.SetPropertyValue(tt, Enum.GetName(typeof(DayEnum), var.Key) + "Value", val.Value);
                                        added = true;
                                        break;
                                    }
                                }
                            }
                            if (!added)
                            {
                                TimeTable timeTable = new TimeTable();
                                timeTable.Doctor = obj.Key;
                                timeTable.ForHeder = false;
                                dataSourceNew.Add(timeTable);
                                Core.ReflectionHelper.SetPropertyValue(timeTable, Enum.GetName(typeof(DayEnum), var.Key) + "Value", val.Value);
                            }
                        }
                    }
                }
            }
        }
        if (dataSourceNew.Count == 0)
        {
            TimeTable tt = new TimeTable();
            tt.Sunday = "fsd";
            dataSourceNew.Add(tt);
        }
          

        grdVisits.DataSource = dataSourceNew;
        grdVisits.DataBind();
    }
    protected void cmbService_SelectedIndexChanged(object sender, EventArgs e)
    {
        ConnectionTarget target = ConnectionTarget.Central;
        Manager.Instance.SetDefaultConnectionTarget(target);
        ISession session = Manager.Instance.OpenSession();
        Entities<Entities.User> res = new Entities<Entities.User>();
        Entities<Entities.User> result = new Entities<User>();
        if (cmbService.Items.Count > 0 && cmbService.SelectedIndex >= 0)
        {
            result = Entities<Entities.User>.GetAllOrderBy(session,
                  new NHibernate.Expression.Order[] { new NHibernate.Expression.Order("FirstName", true), new NHibernate.Expression.Order("LastName", true) },
                  new Core.Dal.Expressions.Eq("UserServices.Service.Id", new Guid(cmbService.SelectedItem.Value)),
                  new Core.Dal.Expressions.IsNull("DeleteTime"));
            Entities.User user = new Entities.User(session);
            user.FirstName = "(Visi)";
            user.LastName = "";
            res.Add(user);
            Entities.Services serv = session.Get<Entities.Services>(new Guid(cmbService.SelectedItem.Value));
            txtService.Text = serv.Value;
        }
        foreach (Entities.User var in result)
        {
            res.Add(var);
        }
        cmbDoctor.DataSource = res;
        cmbDoctor.DataBind();
        btnShow_Click(btnShow, new EventArgs());
    }
    protected void grdVisits_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            TimeTable value =(TimeTable)e.Row.DataItem;
            if (value.Doctor == null)
            {
                return;
            }
            if (value.ForHeder)
            {
                e.Row.Cells[0].ColumnSpan = 6;
                e.Row.Cells[0].Width = 800;
                e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Left;
                e.Row.Cells[0].BackColor = System.Drawing.Color.LightGray;
                e.Row.Cells[0].Wrap = false;
                e.Row.Cells[0].Text = value.Doctor.FullName;
                e.Row.Cells[1].Visible = false;
                e.Row.Cells[2].Visible = false;
                e.Row.Cells[3].Visible = false;
                e.Row.Cells[4].Visible = false;
                e.Row.Cells[5].Visible = false;

                // This is used to get the row. 
                e.Row.Cells[0].ID = e.Row.RowIndex.ToString();
                doctorAddres = e.Row.Cells[0];

            }
            else
            {
                int i = 0;
                foreach (TableCell var in e.Row.Cells)
                {
                    var.ID = e.Row.RowIndex + "" + i;
                    i++;
                }

                e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
                e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Center;
                e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Center;
                e.Row.Cells[3].HorizontalAlign = HorizontalAlign.Center;
                e.Row.Cells[4].HorizontalAlign = HorizontalAlign.Center;
                e.Row.Cells[5].HorizontalAlign = HorizontalAlign.Center;
                e.Row.Cells[6].HorizontalAlign = HorizontalAlign.Center;

                if (value.MondayValue == null)
                {
                    e.Row.Cells[0].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$","_") + "');");
                    e.Row.Cells[0].BackColor = System.Drawing.Color.LightGray;
                }
                else
                {
                    e.Row.Cells[0].Text = value.Monday.Replace("\r\n", "<br>");
                    if (value.MondayValue is WorkTime)
                    {
                        e.Row.Cells[0].BackColor = System.Drawing.Color.Yellow;
                        string parentId = ((WorkTime)(value.MondayValue)).Id.ToString() == Guid.Empty.ToString() ?
                            ((WorkTime)(value.MondayValue)).UserWorkTime.Id.ToString() :
                            ((WorkTime)(value.MondayValue)).Id.ToString();
                        e.Row.Cells[0].Attributes.Add("onClick", "Visit(this.id, 'visible', '" +
                            doctorAddres.UniqueID.Replace("$", "_") + "', '" +
                            ((WorkTime)(value.MondayValue)).StartTime.ToShortDateString() + "', '" +
                            ((WorkTime)(value.MondayValue)).StartTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.MondayValue)).EndTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.MondayValue)).Room.Id.ToString() + "', '" +
                            ((WorkTime)(value.MondayValue)).Acity.ToString() + "', '" +
                            parentId + "', '" +
                            value.Doctor.Id.ToString() + "', '" +
                            ((WorkTime)(value.MondayValue)).StartTime.ToString() + "');");   
                    }
                    else
                    {
                        e.Row.Cells[0].BackColor = System.Drawing.Color.LightGray;
                        e.Row.Cells[0].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    }
                }

                if (value.TuesdayValue == null)
                {
                    e.Row.Cells[1].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    e.Row.Cells[1].BackColor = System.Drawing.Color.LightGray;
                }
                else
                {
                    e.Row.Cells[1].Text = value.Tuesday.Replace("\r\n", "<br>");
                    if (value.TuesdayValue is WorkTime)
                    {
                        e.Row.Cells[1].BackColor = System.Drawing.Color.Yellow;
                        string parentId = ((WorkTime)(value.TuesdayValue)).Id.ToString() == Guid.Empty.ToString() ?
                            ((WorkTime)(value.TuesdayValue)).UserWorkTime.Id.ToString() :
                            ((WorkTime)(value.TuesdayValue)).Id.ToString();
                        e.Row.Cells[1].Attributes.Add("onClick", "Visit(this.id, 'visible', '" +
                            doctorAddres.UniqueID.Replace("$", "_") + "', '" +
                            ((WorkTime)(value.TuesdayValue)).StartTime.ToShortDateString() + "', '" +
                            ((WorkTime)(value.TuesdayValue)).StartTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.TuesdayValue)).EndTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.TuesdayValue)).Room.Id.ToString() + "', '" +
                            ((WorkTime)(value.TuesdayValue)).Acity.ToString() + "', '" +
                            parentId + "', '" +
                            value.Doctor.Id.ToString() + "', '" +
                            ((WorkTime)(value.TuesdayValue)).StartTime.ToString() + "');");   
                    }
                    else
                    {
                        e.Row.Cells[1].BackColor = System.Drawing.Color.LightGray;
                        e.Row.Cells[1].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    }
                }

                if (value.WednesdayValue == null)
                {
                    e.Row.Cells[2].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    e.Row.Cells[2].BackColor = System.Drawing.Color.LightGray;
                }
                else
                {
                    e.Row.Cells[2].Text = value.Wednesday.Replace("\r\n", "<br>");
                    if (value.WednesdayValue is WorkTime)
                    {
                        e.Row.Cells[2].BackColor = System.Drawing.Color.Yellow;
                        string parentId = ((WorkTime)(value.WednesdayValue)).Id.ToString() == Guid.Empty.ToString() ?
                            ((WorkTime)(value.WednesdayValue)).UserWorkTime.Id.ToString() :
                            ((WorkTime)(value.WednesdayValue)).Id.ToString();
                        e.Row.Cells[2].Attributes.Add("onClick", "Visit(this.id, 'visible', '" +
                            doctorAddres.UniqueID.Replace("$", "_") + "', '" +
                            ((WorkTime)(value.WednesdayValue)).StartTime.ToShortDateString() + "', '" +
                            ((WorkTime)(value.WednesdayValue)).StartTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.WednesdayValue)).EndTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.WednesdayValue)).Room.Id.ToString() + "', '" +
                            ((WorkTime)(value.WednesdayValue)).Acity.ToString() + "', '" +
                            parentId + "', '" +
                            value.Doctor.Id.ToString() + "', '" +
                            ((WorkTime)(value.WednesdayValue)).StartTime.ToString() + "');");  
                    }
                    else
                    {
                        e.Row.Cells[2].BackColor = System.Drawing.Color.LightGray;
                        e.Row.Cells[2].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    }
                }

                if (value.ThursdayValue == null)
                {
                    e.Row.Cells[3].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    e.Row.Cells[3].BackColor = System.Drawing.Color.LightGray;
                }
                else
                {
                    e.Row.Cells[3].Text = value.Thursday.Replace("\r\n", "<br>");
                    if (value.ThursdayValue is WorkTime)
                    {
                        e.Row.Cells[3].BackColor = System.Drawing.Color.Yellow;
                        string parentId = ((WorkTime)(value.ThursdayValue)).Id.ToString() == Guid.Empty.ToString() ?
                            ((WorkTime)(value.ThursdayValue)).UserWorkTime.Id.ToString() :
                            ((WorkTime)(value.ThursdayValue)).Id.ToString();
                        e.Row.Cells[3].Attributes.Add("onClick", "Visit(this.id, 'visible', '" +
                            doctorAddres.UniqueID.Replace("$", "_") + "', '" +
                            ((WorkTime)(value.ThursdayValue)).StartTime.ToShortDateString() + "', '" +
                            ((WorkTime)(value.ThursdayValue)).StartTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.ThursdayValue)).EndTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.ThursdayValue)).Room.Id.ToString() + "', '" +
                            ((WorkTime)(value.ThursdayValue)).Acity.ToString() + "', '" +
                            parentId + "', '" +
                            value.Doctor.Id.ToString() + "', '" +
                            ((WorkTime)(value.ThursdayValue)).StartTime.ToString() + "');");   
                    }
                    else
                    {
                        e.Row.Cells[3].BackColor = System.Drawing.Color.LightGray;
                        e.Row.Cells[3].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    }
                }

                if (value.FridayValue == null)
                {
                    e.Row.Cells[4].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    e.Row.Cells[4].BackColor = System.Drawing.Color.LightGray;
                }
                else
                {
                    e.Row.Cells[4].Text = value.Friday.Replace("\r\n", "<br>");
                    if (value.FridayValue is WorkTime)
                    {
                        e.Row.Cells[4].BackColor = System.Drawing.Color.Yellow;
                        string parentId = ((WorkTime)(value.FridayValue)).Id.ToString() == Guid.Empty.ToString() ?
                            ((WorkTime)(value.FridayValue)).UserWorkTime.Id.ToString() :
                            ((WorkTime)(value.FridayValue)).Id.ToString();
                        e.Row.Cells[4].Attributes.Add("onClick", "Visit(this.id, 'visible', '" +
                            doctorAddres.UniqueID.Replace("$", "_") + "', '" +
                            ((WorkTime)(value.FridayValue)).StartTime.ToShortDateString() + "', '" +
                            ((WorkTime)(value.FridayValue)).StartTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.FridayValue)).EndTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.FridayValue)).Room.Id.ToString() + "', '" +
                            ((WorkTime)(value.FridayValue)).Acity.ToString() + "', '" +
                            parentId + "', '" +
                            value.Doctor.Id.ToString() + "', '" +
                            ((WorkTime)(value.FridayValue)).StartTime.ToString() + "');");  
                    }
                    else
                    {
                        e.Row.Cells[4].BackColor = System.Drawing.Color.LightGray;
                        e.Row.Cells[4].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    }
                }

                if (value.SaturdayValue == null)
                {
                    e.Row.Cells[5].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    e.Row.Cells[5].BackColor = System.Drawing.Color.LightGray;
                }
                else
                {
                    e.Row.Cells[5].Text = value.Saturday.Replace("\r\n", "<br>");
                    if (value.SaturdayValue is WorkTime)
                    {
                        e.Row.Cells[5].BackColor = System.Drawing.Color.Yellow;
                        string parentId = ((WorkTime)(value.SaturdayValue)).Id.ToString() == Guid.Empty.ToString() ?
                            ((WorkTime)(value.SaturdayValue)).UserWorkTime.Id.ToString() :
                            ((WorkTime)(value.SaturdayValue)).Id.ToString();
                        e.Row.Cells[5].Attributes.Add("onClick", "Visit(this.id, 'visible', '" +
                            doctorAddres.UniqueID.Replace("$", "_") + "', '" +
                            ((WorkTime)(value.SaturdayValue)).StartTime.ToShortDateString() + "', '" +
                            ((WorkTime)(value.SaturdayValue)).StartTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.SaturdayValue)).EndTime.ToShortTimeString() + "', '" +
                            ((WorkTime)(value.SaturdayValue)).Room.Id.ToString() + "', '" +
                            ((WorkTime)(value.SaturdayValue)).Acity.ToString() + "', '" +
                            parentId + "', '" +
                            value.Doctor.Id.ToString() + "', '" +
                            ((WorkTime)(value.SaturdayValue)).StartTime.ToString() + "');");                       
                    }
                    else
                    {
                        e.Row.Cells[5].BackColor = System.Drawing.Color.LightGray;
                        e.Row.Cells[5].Attributes.Add("onClick", "Visit(this.id, 'hidden', '" + doctorAddres.UniqueID.Replace("$", "_") + "');");
                    }
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ConnectionTarget target = ConnectionTarget.Central;
        Manager.Instance.SetDefaultConnectionTarget(target);
        ISession session = Manager.Instance.OpenSession();
        Patient patient = session.Get<Patient>(Session["Id"]);
        Entities.User doctor = session.Get<Entities.User>(new Guid(txtDoctorId.Value));
        Entities.Services service = session.Get<Entities.Services>(new Guid(cmbService.SelectedValue.ToString()));
        Entities.Room room = session.Get<Entities.Room>(new Guid(txtRoomId.Value));
        Visit visit = new Visit(session);
        visit.Patient = patient;
        visit.Doctor = doctor;
        visit.Service = service;
        bool added = false;
        foreach (UserService serv in doctor.UserServices)
        {
            if (serv.Service.Id == service.Id)
            {
                if (serv.ManualTime.HasValue)
                {
                    visit.Length = serv.ManualTime.Value;
                    added = true;
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        if (!added)
        {
            visit.Length = service.IntegerValue.Value;
        }
        if (service.SecondIntegerValue.HasValue)
            visit.LengthBefore = service.SecondIntegerValue.Value;
        if (service.ThirdIntegerValue.HasValue)
            visit.LengthAfter = service.ThirdIntegerValue.Value;
        visit.Room = room;
        DateTime date;
        if (DateTime.TryParse(txtVisitDate.Value, out date))
        {
            visit.StartTime = date;
        }
        visit.ParentId = new Guid(txtParentId.Value);
        if (txtAcyity.Value == true.ToString())
            visit.Acyity = true;
        
        session.SaveOrUpdate(visit);
        session.Commit();

        btnShow_Click(this, new EventArgs());
    }
    protected void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
        ConnectionTarget target = ConnectionTarget.Central;
        Manager.Instance.SetDefaultConnectionTarget(target);
        ISession session = Manager.Instance.OpenSession();

        if (cmbGroup.Items.Count > 0 && cmbGroup.SelectedIndex >= 0)
        {
            Speciality sp = session.Get<Speciality>(new Guid(cmbGroup.SelectedValue.ToString()));

            cmbService.DataSource = sp.Services.ActiveItemsWithoutEmpty;
            cmbService.DataBind();
            cmbService_SelectedIndexChanged(cmbService, new EventArgs());
        }
    }
    protected void calendar_SelectionChanged(object sender, EventArgs e)
    {
        btnShow_Click(btnShow, new EventArgs());
    }
    protected void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnShow_Click(btnShow, new EventArgs());
    }
}

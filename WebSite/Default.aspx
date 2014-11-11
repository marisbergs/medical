<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Premium Medical" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript">

function Visit(Id, visible, doctor, date, startTime, endTime, roomId, acyity, parentId, doctorId, visitDate) {
    document.all['visit'].style.visibility = visible; 
    if (Id != '')
    {
        document.all[Id].style.color='blue';
        document.all[Id].style.fontWeight='bold';
    }
    if (document.all['previous'].value != '' && document.all['previous'].value != Id)
    {
        document.all[document.all['previous'].value].style.color='#8C4510';
        document.all[document.all['previous'].value].style.fontWeight='normal';
    }
    document.all['previous'].value = Id; 
    document.all['<%= txtDoctor.ClientID %>'].value = document.all[doctor].innerHTML;
    document.all['<%= txtTimeFrom.ClientID %>'].value = startTime;
    document.all['<%= txtTimeTo.ClientID %>'].value = endTime;
    document.all['<%= txtDoctorId.ClientID %>'].value = doctorId;
    document.all['<%= txtVisitDate.ClientID %>'].value = visitDate;
    document.all['<%= txtDate.ClientID %>'].value = date;
    document.all['<%= txtRoomId.ClientID %>'].value = roomId;
    document.all['<%= txtAcyity.ClientID %>'].value = acyity;
    document.all['<%= txtParentId.ClientID %>'].value = parentId;
}

function Question()
{
    return confirm ('Vai tieðâm vçlaties pieteikt vizîti pie ' + document.all['<%= txtDoctor.ClientID %>'].value + ' '+document.all['<%= txtDate.ClientID %>'].value+' plkst '+document.all['<%= txtTimeFrom.ClientID %>'].value+'?');     
}
</script>

    <input id="previous" type="hidden" />
    <input id="doctor" type="hidden" value="txtDoctor" />
    <table style="width:1000px;">
        <tr>
            <td align="right">
                <asp:Label ID="Label1" runat="server" Text="Pakalpojumu grupa:"></asp:Label>
            </td>
            <td align="left">
                <asp:DropDownList ID="cmbGroup" runat="server" DataTextField="Value" DataValueField="Id" AutoPostBack="True" Width="426px" OnSelectedIndexChanged="cmbGroup_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label7" runat="server" Text="Pakalpojums:"></asp:Label>
            </td>
            <td align="left">
                <asp:DropDownList ID="cmbService" runat="server" DataTextField="Value" DataValueField="Id" AutoPostBack="True" Width="426px" OnSelectedIndexChanged="cmbService_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label2" runat="server" Text="Ârsts:"></asp:Label>
            </td>
            <td align="left">                
                <asp:DropDownList ID="cmbDoctor" runat="server" DataTextField="FullName" DataValueField="Id" Width="360px" AutoPostBack="True" OnSelectedIndexChanged="cmbDoctor_SelectedIndexChanged">
                </asp:DropDownList>&nbsp;<asp:Button ID="btnShow" runat="server" Text="Parâdît" OnClick="btnShow_Click" />
            </td>
        </tr>
        <tr>
            <td valign="top" align="left">
                <asp:Calendar ID="calendar" runat="server" Font-Bold="True" Font-Size="Small" Height="141px" ShowGridLines="True" Width="176px" NextPrevFormat="ShortMonth" OnSelectionChanged="calendar_SelectionChanged">
                    <SelectedDayStyle BackColor="Gray" />
                    <DayStyle Font-Bold="True" Font-Size="Small" />
                    <WeekendDayStyle Font-Bold="True" Font-Size="Small" ForeColor="Red" />
                    <OtherMonthDayStyle Font-Bold="False" Font-Size="X-Small" />
                </asp:Calendar>
                <table id="visit" style="visibility:hidden;" border="0">
                    <tr>
                        <td style="width: 169px">
                            <asp:Label ID="Label3" runat="server" Text="Vizîtes pieteikums" Font-Bold="True" Font-Size="Small"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 169px">
                            <asp:Label ID="Label6" runat="server" Text="Pakalpojums:" Font-Bold="True" Font-Size="Small"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 169px">
                            <asp:TextBox ID="txtService" runat="server" Font-Bold="True" Font-Size="Small" Height="72px"
                                ReadOnly="True" TextMode="MultiLine" Width="162px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 169px">
                            <asp:Label ID="Label4" runat="server" Text="Ârsts:" Font-Bold="True" Font-Size="Small"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 169px">
                            <asp:TextBox ID="txtDoctor" runat="server" Font-Bold="True" Font-Size="Small" ReadOnly="True"
                                Width="162px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 169px">
                            <asp:Label ID="Label5" runat="server" Text="Vizîtes laiks:" Font-Bold="True" Font-Size="Small"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 169px">
                            <asp:TextBox ID="txtTimeFrom" runat="server" Width="40px" Font-Bold="True" Font-Size="Small" ReadOnly="True"></asp:TextBox>
                            lîdz
                            <asp:TextBox ID="txtTimeTo" runat="server" Width="40px" Font-Bold="True" Font-Size="Small" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 169px">
                            <asp:Button ID="Button1" runat="server" Text="Pieteikt" OnClick="Button1_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 169px">
                            <asp:HiddenField ID="txtDoctorId" runat="server" />
                            <asp:HiddenField ID="txtVisitDate" runat="server" />
                            <asp:HiddenField ID="txtRoomId" runat="server" />
                            <asp:HiddenField ID="txtAcyity" runat="server" />
                            <asp:HiddenField ID="txtParentId" runat="server" /><asp:HiddenField ID="txtDate" runat="server" />
                        </td>
                    </tr>
                </table>
            </td>
            <td valign="top">
                <asp:GridView ID="grdVisits" runat="server" AutoGenerateColumns="False"
                    Width="800px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="0" Font-Bold="False" Font-Size="Small" HorizontalAlign="Center" PageSize="1000" OnRowDataBound="grdVisits_RowDataBound" style="padding-right: 0px; padding-left: 0px; padding-bottom: 0px; margin: 0px; padding-top: 0px">
                    <Columns>
                        <asp:BoundField DataField="Monday" HeaderText="Monday" SortExpression="Monday" >
                            
                        </asp:BoundField>
                        <asp:BoundField DataField="Tuesday" HeaderText="Tuesday" SortExpression="Tuesday" >
                            <ControlStyle BorderStyle="Solid" BorderWidth="1px" Font-Bold="False" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Wednesday" HeaderText="Wednesday" SortExpression="Wednesday" />
                        <asp:BoundField DataField="Thursday" HeaderText="Thursday" SortExpression="Thursday" />
                        <asp:BoundField DataField="Friday" HeaderText="Friday" SortExpression="Friday" />
                        <asp:BoundField DataField="Saturday" HeaderText="Saturday" SortExpression="Saturday" />
                        <asp:BoundField DataField="Sunday" HeaderText="Sunday" SortExpression="Sunday" Visible="False" />
                        <asp:CheckBoxField DataField="Doctor" HeaderText="Doctor" SortExpression="Doctor"
                            Visible="False" />
                        <asp:CheckBoxField DataField="MondayAcyity" HeaderText="MondayAcyity" SortExpression="MondayAcyity"
                            Visible="False" />
                        <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" Visible="False" />
                        <asp:BoundField DataField="TuesdayId" HeaderText="TuesdayId" SortExpression="TuesdayId"
                            Visible="False" />
                        <asp:CheckBoxField DataField="ForVisit" HeaderText="ForVisit" SortExpression="ForVisit"
                            Visible="False" />
                        <asp:CheckBoxField DataField="IsValid" HeaderText="IsValid" ReadOnly="True" SortExpression="IsValid"
                            Visible="False" />
                        <asp:CheckBoxField DataField="WednesdayAcyity" HeaderText="WednesdayAcyity" SortExpression="WednesdayAcyity"
                            Visible="False" />
                        <asp:BoundField DataField="WednesdayId" HeaderText="WednesdayId" SortExpression="WednesdayId"
                            Visible="False" />
                        <asp:BoundField DataField="Error" HeaderText="Error" ReadOnly="True" SortExpression="Error"
                            Visible="False" />
                        <asp:BoundField DataField="ThursdayId" HeaderText="ThursdayId" SortExpression="ThursdayId"
                            Visible="False" />
                        <asp:BoundField DataField="DeleteTime" HeaderText="DeleteTime" ReadOnly="True" SortExpression="DeleteTime"
                            Visible="False" />
                        <asp:CheckBoxField DataField="IsDirty" HeaderText="IsDirty" SortExpression="IsDirty"
                            Visible="False" />
                        <asp:CheckBoxField DataField="SundayAcyity" HeaderText="SundayAcyity" SortExpression="SundayAcyity"
                            Visible="False" />
                        <asp:CheckBoxField DataField="TuesdayAcyity" HeaderText="TuesdayAcyity" SortExpression="TuesdayAcyity"
                            Visible="False" />
                        <asp:CheckBoxField DataField="CanEdit" HeaderText="CanEdit" ReadOnly="True" SortExpression="CanEdit"
                            Visible="False" />
                        <asp:BoundField DataField="SundayId" HeaderText="SundayId" SortExpression="SundayId"
                            Visible="False" />
                        <asp:BoundField DataField="SaturdayId" HeaderText="SaturdayId" SortExpression="SaturdayId"
                            Visible="False" />
                        <asp:CheckBoxField DataField="CanSee" HeaderText="CanSee" ReadOnly="True" SortExpression="CanSee"
                            Visible="False" />
                        <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" Visible="False" />
                        <asp:CheckBoxField DataField="Selected" HeaderText="Selected" SortExpression="Selected"
                            Visible="False" />
                        <asp:BoundField DataField="DeleteNotes" HeaderText="DeleteNotes" SortExpression="DeleteNotes"
                            Visible="False" />
                        <asp:CheckBoxField DataField="CanDelete" HeaderText="CanDelete" ReadOnly="True" SortExpression="CanDelete"
                            Visible="False" />
                        <asp:CheckBoxField DataField="ThursdayAcyity" HeaderText="ThursdayAcyity" SortExpression="ThursdayAcyity"
                            Visible="False" />
                        <asp:BoundField DataField="Source" HeaderText="Source" SortExpression="Source" Visible="False" />
                        <asp:BoundField DataField="UpdateTime" HeaderText="UpdateTime" ReadOnly="True" SortExpression="UpdateTime"
                            Visible="False" />
                        <asp:BoundField DataField="MondayId" HeaderText="MondayId" SortExpression="MondayId"
                            Visible="False" />
                        <asp:CheckBoxField DataField="SaturdayAcyity" HeaderText="SaturdayAcyity" SortExpression="SaturdayAcyity"
                            Visible="False" />
                        <asp:BoundField DataField="Version" HeaderText="Version" SortExpression="Version"
                            Visible="False" />
                        <asp:CheckBoxField DataField="CanSave" HeaderText="CanSave" ReadOnly="True" SortExpression="CanSave"
                            Visible="False" />
                        <asp:BoundField DataField="FridayId" HeaderText="FridayId" SortExpression="FridayId"
                            Visible="False" />
                        <asp:CheckBoxField DataField="IsActive" HeaderText="IsActive" SortExpression="IsActive"
                            Visible="False" />
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <RowStyle BackColor="#FFF7E7" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                        ForeColor="#8C4510" HorizontalAlign="Center" VerticalAlign="Top" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" Font-Size="Small" ForeColor="White" />
                    <AlternatingRowStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    <asp:ObjectDataSource ID="bndVisits" runat="server" SelectMethod="GetTime" TypeName="Visits">
    </asp:ObjectDataSource>
</asp:Content>
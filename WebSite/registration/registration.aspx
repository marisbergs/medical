<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" Title="Premium Medical" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <table border="0">
        <tr>
            <td style="width: 146px; padding-right:10;" align="right">
                <asp:Label ID="Label1" runat="server" Text="Vârds:"></asp:Label></td>
            <td style="width: 506px;" align="left">
                <asp:TextBox ID="txtName"   runat="server" Width="294px" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtName"
                    ErrorMessage="Obligâti aizpildâms lauks" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="padding-right: 10; width: 146px;" align="right">
                <asp:Label ID="Label2" runat="server" Text="Uzvârds:"></asp:Label></td>
            <td align="left" style="width: 506px">
                <asp:TextBox ID="txtSurname" runat="server" Width="294px" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtSurname"
                    ErrorMessage="Obligâti aizpildâms lauks" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="padding-right: 10; width: 146px;" align="right">
                <asp:Label ID="Label3" runat="server" Text="Dzimðanas diena:"></asp:Label></td>
            <td align="left" style="width: 506px">
                <cc1:GMDatePicker ID="dtpBirthDay" runat="server" InitialValueMode="Null" YearDropDownRange="140" FirstDayOfWeek="Monday" CalendarTheme="Green" ShowTodayButton="False">
                </cc1:GMDatePicker>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Obligâti aizpildâms lauks" ControlToValidate="dtpBirthDay" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:Label ID="lblInvalidDate" runat="server" ForeColor="Red"></asp:Label></td>
        </tr>
        <tr>
            <td style="padding-right: 10; width: 146px;" align="right">
                <asp:Label ID="Label4" runat="server" Text="Dzimums:"></asp:Label></td>
            <td align="left" style="width: 506px">
                <asp:RadioButton ID="rbtF"  runat="server" Text="Sieviete" GroupName="Sex" />
                <asp:RadioButton ID="rbtM" runat="server" Text="Vîrietis" GroupName="Sex" />&nbsp;
                <asp:Label ID="lblValidateSex" runat="server" ForeColor="Red" Text="Obligâti aizpildâms lauks"
                    Visible="False"></asp:Label></td>
        </tr>
        <tr>
            <td style="padding-right: 10; width: 146px;" align="right">
                <asp:Label ID="Label13" runat="server" Text="Personas kods:"></asp:Label></td>
            <td align="left" style="width: 506px">
                <asp:TextBox ID="txtCode" runat="server" Width="294px" MaxLength="12"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Obligâti aizpildâms lauks" ControlToValidate="txtCode" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="padding-right: 10; width: 146px;" align="right">
                <asp:Label ID="Label14" runat="server" Text="Adrese:"></asp:Label></td>
            <td align="left" style="width: 506px">
                <asp:TextBox ID="txtAddress" runat="server" Width="294px" MaxLength="100"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Obligâti aizpildâms lauks" ControlToValidate="txtAddress" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="padding-right: 10; width: 146px;" align="right">
                <asp:Label ID="Label11" runat="server" Text="Mob. tel.:"></asp:Label></td>
            <td align="left" style="width: 506px">
                <asp:TextBox ID="txtMobilePhone" runat="server" Width="294px" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Obligâti aizpildâms lauks" ControlToValidate="txtMobilePhone" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="padding-right: 10; width: 146px;" align="right">
                <asp:Label ID="Label12" runat="server" Text="E-pasts:"></asp:Label></td>
            <td align="left" style="width: 506px">
                <asp:TextBox ID="txtMail" runat="server" Width="294px" MaxLength="100"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtMail"
                    ErrorMessage="Obligâti aizpildâms lauks" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
                <tr>
                    <td align="center" colspan="2" style="padding-right: 10px">
                        <asp:Label ID="lblErrorText" runat="server" ForeColor="Red"></asp:Label></td>
                </tr>
        <tr>
            <td style="padding-right: 10;" align="center" colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="Saglabât" OnClick="btnSave_Click" /></td>
        </tr>
    </table>
</asp:Content>


<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeFile="psw.aspx.cs" Inherits="registration_psw" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0">
        <tr>
            <td align="right" style="padding-right: 10px; width: 146px; height: 21px">
                <asp:Label ID="Label5" runat="server" Text="Klienta numurs:"></asp:Label></td>
            <td align="left" style="width: 506px; height: 21px">
                <asp:TextBox ID="txtUserName" runat="server" MaxLength="15" Width="208px" BorderStyle="None"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserName"
                    Display="Dynamic" ErrorMessage="Obligâti aizpildâms lauks"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="right" style="padding-right: 10px; width: 146px; height: 21px">
                <asp:Label ID="Label6" runat="server" Text="Parole:"></asp:Label></td>
            <td align="left" style="width: 506px; height: 21px">
                <asp:TextBox ID="txtPassword" runat="server" MaxLength="15" TextMode="Password" Width="208px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPassword"
                    Display="Dynamic" ErrorMessage="Obligâti aizpildâms lauks"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="right" style="padding-right: 10px; width: 146px; height: 21px">
                <asp:Label ID="label34" runat="server" Text="Parole atkârtoti:"></asp:Label></td>
            <td align="left" style="width: 506px; height: 21px">
                <asp:TextBox ID="txtSeccondPasword" runat="server" MaxLength="15" TextMode="Password"
                    Width="208px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword"
                    ControlToValidate="txtSeccondPasword" Display="Dynamic" ErrorMessage="Paroles nesakrît"></asp:CompareValidator><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtSeccondPasword"
                        Display="Dynamic" ErrorMessage="Obligâti aizpildâms lauks"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="padding-right: 10px">
                <asp:Label ID="lblErrorText" runat="server" ForeColor="Red"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="padding-right: 10px">
                <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Saglabât" /></td>
        </tr>
    </table>
    <asp:HiddenField ID="txtId" runat="server" />
</asp:Content>


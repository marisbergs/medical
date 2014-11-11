<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeFile="loging.aspx.cs" Inherits="loging" Title="Premium Medical" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="width: 1000px; text-align: center;">
    <br />
    <table border="0" cellpadding="0" cellspacing="0" width="350">
        <tr>
            <td align="center" colspan="2" style="font-weight: bold; font-size: 12px; color: black;
                background-color: transparent">
                <asp:Label ID="lblTitle" runat="server" meta:resourcekey="lblTitleResource1">Autorizâcija</asp:Label></td>
        </tr>
        <tr>
            <td align="right" style="width: 146px">
                <asp:Label ID="lblUserName" runat="server" Font-Bold="True" Font-Size="Small" meta:resourcekey="lblUserNameResource1">Klienta numurs:</asp:Label></td>
            <td align="left" style="width: 174px">
                &nbsp;<asp:TextBox ID="txtUsername" runat="server" meta:resourcekey="txtUserNameResource1"
                    Width="150px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUsername"
                    Font-Bold="True" Font-Size="Small" meta:resourcekey="RequiredFieldValidator2Resource1"
                    Text="*"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="right" style="height: 24px; width: 146px;">
                <asp:Label ID="lblPassword" runat="server" Font-Bold="True" Font-Size="Small" meta:resourcekey="PasswordLabelResource1">Parole:</asp:Label></td>
            <td align="left" style="width: 174px; height: 24px;">
                &nbsp;<asp:TextBox ID="txtPassword" runat="server" meta:resourcekey="txtPasswordResource1"
                    TextMode="Password" Width="150px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                    Font-Bold="True" Font-Size="Small" meta:resourcekey="RequiredFieldValidator1Resource1"
                    Text="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 146px">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Size="Small" NavigateUrl="~/registration/registration.aspx">Reìistrâcija</asp:HyperLink>
                &nbsp; &nbsp;
            </td>
            <td align="left" style="width: 174px">
                <asp:Button ID="cmdLogin" runat="server" meta:resourcekey="cmdLoginResource1" Text="Apstiprinât"
                    Width="100px" Font-Bold="True" Font-Size="Small" OnClick="cmdLogin_Click" /></td>
        </tr>
        <tr>
            <td align="left" colspan="2" style="color: red;">
                <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="Small" Width="319px"></asp:Label>&nbsp;
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="text-align: left; height: 9px;">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableTheming="False"
                    Font-Bold="True" Font-Size="Small" Font-Strikeout="False" Style="text-align: left" />
                &nbsp;&nbsp;
            </td>
        </tr>
    </table>
    </div>
</asp:Content>


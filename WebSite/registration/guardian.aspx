<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeFile="guardian.aspx.cs" Inherits="guardian" Title="Premium Medical" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0">
        <tr>
            <td align="left" style="padding-right: 10px;" colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Pacients ir b�rns vecum� l�dz 18 gadiem, nepiecie�ams aizpild�t ar� �o sada�u"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" style="padding-right: 10px; width: 146px">
                <asp:Label ID="Label4" runat="server" Text="Aizbildnis:"></asp:Label></td>
            <td align="left" style="width: 503px">
                &nbsp;
                <asp:RadioButton ID="rbtMother" runat="server" GroupName="1" Text="M�te" />&nbsp;
                <asp:RadioButton ID="rbtFather" runat="server" GroupName="1" Text="T�vs" />
                <asp:RadioButton ID="rbtOther" runat="server" GroupName="1" Text="Aizbildnis" /></td>
        </tr>
        <tr>
            <td align="right" style="padding-right: 10px; width: 146px">
                <asp:Label ID="Label3" runat="server" Text="V�rds:"></asp:Label></td>
            <td align="left" style="width: 503px">
                <asp:TextBox ID="txtName" runat="server" MaxLength="50" Width="294px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                    ErrorMessage="Oblig�ti aizpild�ms lauks" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="right" style="padding-right: 10px; width: 146px">
                <asp:Label ID="Label2" runat="server" Text="Uzv�rds:"></asp:Label></td>
            <td align="left" style="width: 503px">
                <asp:TextBox ID="txtSurname" runat="server" MaxLength="50" Width="294px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtSurname"
                    ErrorMessage="Oblig�ti aizpild�ms lauks" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="right" style="padding-right: 10px; width: 146px">
                <asp:Label ID="Label13" runat="server" Text="Personas kods:"></asp:Label></td>
            <td align="left" style="width: 503px">
                <asp:TextBox ID="txtCode" runat="server" MaxLength="30" Width="294px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCode"
                    ErrorMessage="Oblig�ti aizpild�ms lauks" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="right" style="padding-right: 10px; width: 146px">
                <asp:Label ID="Label14" runat="server" Text="Adrese:"></asp:Label></td>
            <td align="left" style="width: 503px">
                <asp:TextBox ID="txtAddress" runat="server" MaxLength="100" Width="294px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAddress"
                    ErrorMessage="Oblig�ti aizpild�ms lauks" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="right" style="padding-right: 10px; width: 146px">
                <asp:Label ID="Label11" runat="server" Text="Mob. tel.:"></asp:Label></td>
            <td align="left" style="width: 503px">
                <asp:TextBox ID="txtMobilePhone" runat="server" MaxLength="50" Width="294px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtMobilePhone"
                    ErrorMessage="Oblig�ti aizpild�ms lauks" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="right" style="padding-right: 10px; width: 146px">
                <asp:Label ID="Label12" runat="server" Text="E-pasts:"></asp:Label></td>
            <td align="left" style="width: 503px">
                <asp:TextBox ID="txtMail" runat="server" MaxLength="100" Width="294px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtMail"
                    ErrorMessage="Oblig�ti aizpild�ms lauks" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="padding-right: 10px">
                <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Saglab�t" />
                <asp:HiddenField ID="txtId" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>


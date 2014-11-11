<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
            <ItemTemplate>
                Surname:
                <asp:Label ID="SurnameLabel" runat="server" Text='<%# Bind("Surname") %>'></asp:Label><br />
                Code:
                <asp:Label ID="CodeLabel" runat="server" Text='<%# Bind("Code") %>'></asp:Label><br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>'></asp:Label><br />
                &nbsp;
            </ItemTemplate>
        </asp:FormView>
        &nbsp;</div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Patient"
            InsertMethod="SetPatient" SelectMethod="GetPatient" TypeName="Patient">
            <InsertParameters></InsertParameters>
            </asp:ObjectDataSource>
    </form>
</body>
</html>

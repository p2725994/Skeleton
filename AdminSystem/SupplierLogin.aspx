<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierLogin.aspx.cs" Inherits="SupplierLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 11px; top: 11px; position: absolute; height: 22px" Text="Supplier Book LoginPage"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 13px; top: 116px; position: absolute; height: 27px" Text="Password"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 12px; top: 73px; position: absolute" Text="UserName"></asp:Label>
        <asp:Button ID="btnLoginin" runat="server" style="z-index: 1; left: 94px; top: 171px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 171px; position: absolute; left: 171px" Text="Cancel" />
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 105px; top: 70px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 107px; top: 112px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 342px; top: 106px; position: absolute"></asp:Label>
    </form>
</body>
</html>

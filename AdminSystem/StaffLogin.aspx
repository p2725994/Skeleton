<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div> 
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 76px; top: 74px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 77px; top: 109px; position: absolute" Text="Password:"></asp:Label>
        <asp:Label ID="lblStaffLogin" runat="server" style="z-index: 1; left: 24px; top: 29px; position: absolute" Text="Staff Login Form"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 157px; top: 73px; position: absolute; bottom: 498px" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 157px; top: 110px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 159px; top: 165px; position: absolute; width: 47px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 221px; top: 165px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 340px; top: 85px; position: absolute"></asp:Label>
    </form>
</body>
</html>

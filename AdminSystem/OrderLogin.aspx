<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Order Login Page"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="top: 125px; left: 40px; position: absolute; height: 19px; width: 34px" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="top: 125px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="top: 170px; left: 40px; position: absolute; height: 19px; width: 34px" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="top: 170px; left: 120px; position: absolute; height: 22px; width: 128px" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="top: 230px; left: 120px; position: absolute; height: 26px; width: 56px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="top: 230px; left: 190px; position: absolute; height: 26px; width: 56px" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="top: 125px; left: 290px; position: absolute; height: 19px; width: 100px"></asp:Label>
    </form>
</body>
</html>

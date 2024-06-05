<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerLoginHeader" runat="server" style="z-index: 1; left: 216px; top: 50px; position: absolute" Text="Customer Login Page"></asp:Label>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 140px; top: 92px; position: absolute; height: 27px" Text="UserName :" width="95px"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 140px; top: 139px; position: absolute; height: 27px; width: 95px" Text="Password :"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" height="22px" style="z-index: 1; top: 92px; position: absolute; width: 164px; left: 280px"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" height="22px" style="z-index: 1; left: 280px; top: 133px; position: absolute; width: 164px" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnCancel" runat="server" height="26" style="z-index: 1; position: absolute; left: 358px; bottom: 322px" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 598px; top: 84px; position: absolute; height: 38px; width: 67px"></asp:Label>
            <asp:Button ID="btnLogin" runat="server" height="26px" OnClick="btnLogin_Click" style="z-index: 1; left: 278px; position: absolute; bottom: 322px;" Text="Login" width="60px" />
        </div>
    </form>
</body>
</html>

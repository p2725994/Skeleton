<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLoginPage.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Login</title>
    <link href="StaffLogin.css" rel="stylesheet" />
</head>
<body>
    <div class="center">
        <h1>Staff Login</h1>
        <form id="form1" runat="server">
            <div class="text_Field">
                <asp:Label ID="lblUserName" runat="server"  Text="UserName:"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server" ></asp:TextBox>
            </div>
            <div class="text_Field">
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="button">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            </div>
             <div class="button">
                 <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
             </div>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
            </form>
        </div>
    
</body>
</html>


<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>R-ASAP+</title>
    <link href="TeamMainMenu.css" rel="stylesheet" />
</head>
<body>
    <div class="center">
    <h1>R-ASAP+ Main Menu</h1>
    <form id="form1" runat="server">
        <div class="button">
            <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" Text="Staff"/>
        </div>
       <div class="button">
            <asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click" />
        </div>
        <div class="button">
            <asp:Button ID="btnCustomer" runat="server" Text="Customer" OnClick="btnCustomer_Click" />
        </div>
        <div class="button">
            <asp:Button ID="btnStock" runat="server" Text="Stock" OnClick="btnStock_Click" />
        </div>
        <div class="button">
            <asp:Button ID="btnSupplier" runat="server" Text="Supplier" OnClick="btnSupplier_Click" />
        </div>
        </form>
    </div>
</body>
</html>

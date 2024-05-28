<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnStaff" runat="server" height="26px" OnClick="btnStaff_Click" style="z-index: 1; left: 21px; top: 109px; position: absolute" Text="Staff" width="84px" />
            <asp:Label ID="lblMenu" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 175px; top: 36px; position: absolute" Text="R-ASAP+ Main Menu"></asp:Label>
            <asp:Button ID="btnOrder" runat="server" height="26px" style="z-index: 1; left: 235px; top: 109px; position: absolute" Text="Order" width="84px" OnClick="btnOrder_Click" />
            <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 127px; top: 109px; position: absolute" Text="Customer" OnClick="btnCustomer_Click" />
            <asp:Button ID="btnStock" runat="server" height="26px" style="z-index: 1; left: 352px; top: 109px; position: absolute" Text="Stock" width="84px" OnClick="btnStock_Click" />
            <asp:Button ID="btnSupplier" runat="server" height="26px" style="z-index: 1; left: 461px; top: 109px; position: absolute" Text="Supplier" width="84px" OnClick="btnSupplier_Click" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnyes" runat="server" OnClick="btnyes_Click" style="z-index: 1; left: 3px; top: 82px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 101px; top: 81px; position: absolute" Text="No" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>


<!DOCTYPE html>

<"html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form3" runat="server">
        <div>       </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 8px; top: 25px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 24px; top: 63px; position: absolute; width: 62px" Text="Yes" />
        <asp:Button ID="Button2" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; left: 96px; top: 62px; position: absolute" Text="No" width="62px" />
    </form>
</body>


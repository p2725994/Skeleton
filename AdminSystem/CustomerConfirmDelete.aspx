<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 14px; top: 97px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <p>
            <asp:Button ID="btnConfirmDeleteYes" runat="server" OnClick="btnConfirmDeleteYes_Click" style="z-index: 1; left: 15px; top: 132px; position: absolute; width: 75px; right: 720px" Text="Yes" />
        </p>
        <asp:Button ID="btnConfirmDeleteNo" runat="server" height="26px" OnClick="btnConfirmDeleteNo_Click" style="z-index: 1; left: 108px; top: 132px; position: absolute" Text="No" width="75px" />
    </form>
</body>
</html>

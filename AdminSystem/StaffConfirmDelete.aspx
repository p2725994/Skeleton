<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Confirm Delete</title>
    <link href="StaffDelete.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 58px; top: 17px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
            <asp:Button ID="btnNo" runat="server"  OnClick="btnNo_Click"  style="z-index: 1; left: 208px; top: 58px; position: absolute" Text="No"/>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click"  style="z-index: 1; left: 23px; top: 58px; position: absolute" Text="Yes" />
        </div>
    </form>
</body>
</html>

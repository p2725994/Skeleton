﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="393px" Width="517px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 18px; top: 439px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 68px; top: 439px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 479px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 60px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 225px; width: 272px;"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 140px; top: 390px; position: absolute" Text="Clear Filter" />
        </p>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 10px; top: 280px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 80px; top: 280px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 450px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="top: 280px; left: 150px; position: absolute; height: 26px; width: 56px" Text="Delete" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 10px; top: 350px; position: absolute" Text="Enter a delivery address"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 170px; top: 350px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 10px; top: 390px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="top: 390px; left: 340px; position: absolute; height: 26px; width: 130px" Text="Return to Main Menu" Width="130px" />
    </form>
</body>
</html>

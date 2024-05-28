<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 312px; position: absolute; height: 22px; width: 68px;" Text="Add" />
         <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 219px; position: absolute; bottom: 335px; height: 22px;" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 117px; top: 314px; position: absolute; width: 57px; height: 22px;" Text="Edit" />
        <asp:ListBox ID="lstStockList" runat="server" Style="z-index: 1; left: -4px; top: -4px; position: absolute; height: 302px; width: 355px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="lblEnterName" runat="server" Text="Enter a Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 124px; top: 376px; position: absolute; width: 118px;"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="BtnApplyFilter_Click" Text="Apply Filter" Height="23px" style="margin-top: 6px" Width="101px" />
        <asp:Button ID="btnClearFilter" runat="server" Height="27px" OnClick="BtnClearFilter_Click" Text="Clear Filter" style="margin-left: 38px" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
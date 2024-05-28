<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        sproc_tblstock_Delete
          <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 0px; top: 405px; position: absolute; height: 22px; width: 68px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 90px; top: 408px; position: absolute; width: 57px; height: 22px;" Text="Edit" />
        <p>
            &nbsp;</p>
        <p>
        <asp:ListBox ID="lstStockList" runat="server" Style="z-index: 1; left: 3px; top: 14px; position: absolute; height: 376px; width: 423px"></asp:ListBox>
        </p>
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
        <asp:Button runat="server" Text="Delete" ID="btnDelete" OnClick="btnDelete_Click" Height="21px" Width="51px"></asp:Button>
        </p>
        <p>
        <asp:Button ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 588px; position: absolute" Text="[Error]" />
            <asp:Label ID="lblEnterName" runat="server" Text="Enter a Name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" OnTextChanged="TxtFilter_TextChanged" Width="128px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="BtnApplyFilter_Click" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" Height="27px" OnClick="BtnClearFilter_Click" Text="Clear Filter" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
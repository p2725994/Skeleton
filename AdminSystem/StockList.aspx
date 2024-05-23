<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStockList" runat="server" Style="z-index: 1; left: 18px; top: 7px; position: absolute; height: 376px; width: 423px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>
        sproc_tblstock_Delete
          <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 32px; top: 416px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 109px; top: 414px; position: absolute" Text="Edit" />
        <p>
            &nbsp;</p>
        <asp:Button runat="server" Text="Button" ID="btnDelete" OnClick="btnDelete_Click"></asp:Button>
        <p>
            &nbsp;</p>
        <asp:Button ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 460px; position: absolute" Text="Error" />
    </form>
</body>
</html>
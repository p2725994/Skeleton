<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
</head>
<body>
    <form id="form1" runat="server" class="form-container">
        <asp:ListBox ID="lstStockList" runat="server" style="height: 300px; width: 350px;"></asp:ListBox>
        
        <div class="button-group">
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click1" style="height: 25px; width: 75px;" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" style="height: 25px; width: 75px; margin-left: 10px;" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" style="height: 25px; width: 75px; margin-left: 10px;" />
        </div>

        <div class="filter-group">
            <asp:Label ID="lblEnterName" runat="server" Text="Enter a Name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="width: 150px;"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="BtnApplyFilter_Click" Text="Apply Filter" style="height: 25px; width: 100px;" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="BtnClearFilter_Click" Text="Clear Filter" style="height: 25px; width: 100px;" />
        </div>

        <asp:Label ID="lblError" runat="server" CssClass="error-label"></asp:Label>
    </form>
</body>
</html>
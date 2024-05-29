<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 180px; top: 374px; position: absolute" Text="Delete" />
      <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 36px; top: -1px; position: absolute; height: 297px; width: 1215px" OnSelectedIndexChanged="lstSupplierList_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 13px; top: 371px; position: absolute" Text="Add" />
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 97px; top: 372px; position: absolute; width: 37px;" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 420px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtFilter" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 139px; top: 483px; position: absolute; right: 416px; height: 22px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 11px; top: 482px; position: absolute" Text="Enter the address"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 13px; top: 530px; position: absolute; width: 76px" Text="Apply Filter" />
        </p>
        <p>
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 120px; top: 532px; position: absolute; height: 31px; width: 92px" Text="Clear Filter" />
        </p>
    </form>
</body>
</html>

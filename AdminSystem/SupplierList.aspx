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
      <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 8px; top: 63px; position: absolute; height: 297px; width: 1215px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 13px; top: 371px; position: absolute" Text="Add" />
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 97px; top: 372px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 420px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>

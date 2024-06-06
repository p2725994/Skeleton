<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier List</title>
  
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">          
                <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 401px; top: 141px; position: absolute; width: 134px;"></asp:TextBox>
                <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 453px; top: 427px; position: absolute"></asp:Label>
                <asp:Label ID="lblEnterEmail" runat="server" style="z-index: 1; left: 415px; top: 112px; position: absolute; width: 120px; right: 398px;" Text="Enter an Address"></asp:Label>
            <asp:ListBox ID="lstSupplierList" runat="server" Style="z-index: 1; left: 14px; top: 39px; position: absolute; height: 396px; width: 332px;"></asp:ListBox>
                <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 376px; top: 365px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 455px; position: absolute; top: 367px;" Text="Edit"  OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 541px; position: absolute; top: 364px;" Text="Delete" OnClick="btnDelete_Click" />
                <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 512px; top: 239px; position: absolute" Text="Clear Filter" OnClick="btnClearFilter_Click"  />
                <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 362px; top: 239px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click"  />
                
        </div>
    </form>
</body>
</html>

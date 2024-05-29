<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>          
                <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 463px; top: 54px; position: absolute; width: 118px;"></asp:TextBox>
                <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 450px; position: absolute"></asp:Label>
                <asp:Label ID="lblEnterEmail" runat="server" style="z-index: 1; left: 358px; top: 56px; position: absolute; right: 854px;" Text="Enter an Email"></asp:Label>
                <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 470px; top: 105px; position: absolute" Text="Clear Filter" height="26px" width="100px" OnClick="btnClearFilter_Click"  />
                <asp:Button ID="btnMenu" runat="server" OnClick="btnMenu_Click" style="z-index: 1; left: 365px; top: 235px; position: absolute" Text="Return to Main Menu" />
                <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 14px; top: 39px; position: absolute; height: 396px; width: 332px;"></asp:ListBox>
                <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 360px; top: 105px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click"  />
                <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 360px; top: 309px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 411px; position: absolute; top: 309px;" Text="Edit"  OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 461px; position: absolute; top: 309px;" Text="Delete" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>

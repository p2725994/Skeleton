<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:ListBox ID="lstStaffList" runat="server" Height="377px" Width="328px"></asp:ListBox>
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 364px; top: 179px; position: absolute; bottom: 438px; width: 55px; right: 188px;" Text="Add" height="26px" />
                <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 444px; position: absolute; bottom: 438px;" Text="Edit" OnClick="btnEdit_Click" height="26px" width="55px" />
                <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 467px; top: 31px; position: absolute; width: 118px;"></asp:TextBox>
                <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 404px; position: absolute"></asp:Label>
                <asp:Label ID="lblEnterEmail" runat="server" style="z-index: 1; left: 363px; top: 32px; position: absolute; right: 427px;" Text="Enter an Email"></asp:Label>
                <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 360px; top: 105px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click"  />
                <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 472px; top: 105px; position: absolute" Text="Clear Filter" height="26px" width="100px" OnClick="btnClearFilter_Click"  />
        </div>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 520px; position: absolute; bottom: 438px;" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="z-index: 1; left: 8px; top: 30px; position: absolute; height: 227px; width: 372px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 44px; top: 263px; position: absolute" Text="Add" height="29px" width="51px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 424px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; top: 263px; position: absolute; height: 29px; width: 51px; left: 185px" Text="Delete" />
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
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click1" style="z-index: 1; left: 116px; top: 263px; position: absolute" Text="Edit" height="29px" width="51px" />
        <asp:TextBox ID="txtFirstname" runat="server" style="z-index: 1; top: 316px; position: absolute; height: 26px; width: 165px; left: 211px"></asp:TextBox>
        <p>
            <asp:Label ID="lblEnterFirstname" runat="server" style="z-index: 1; left: 13px; top: 322px; position: absolute; right: 511px" Text="Please enter the Firstname"></asp:Label>
        </p>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 53px; top: 368px; position: absolute; height: 21px; width: 92px; right: 577px" Text="ApplyFilter" />
        <asp:Button ID="btnClearFilter" runat="server" height="21px" OnClick="btnClearFilter_Click" style="z-index: 1; top: 368px; position: absolute; left: 161px" Text="Clear Filter" width="92px" />
    </form>
</body>
</html>

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
        <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="z-index: 1; left: 268px; top: 14px; position: absolute; height: 227px; width: 372px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 37px; top: 276px; position: absolute" Text="Add" height="29px" width="51px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click1" style="z-index: 1; left: 119px; top: 276px; position: absolute" Text="Edit" height="29px" width="51px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 424px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; top: 276px; position: absolute; height: 29px; width: 51px; left: 206px" Text="Delete" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>

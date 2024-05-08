<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 667px">
    <form id="form1" runat="server">
        <div>
        &nbsp;Supplier Data Entry Page<br />
            <br />
            <br />
            <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 13px; top: 44px; position: absolute; height: 18px; width: 70px" Text="Supplier ID"></asp:Label>
            <br />
            <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 113px; top: 68px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblSupplierEmail" runat="server" style="z-index: 1; left: 13px; top: 98px; position: absolute" Text="Email"></asp:Label>
            <asp:TextBox ID="txtSuppplierEmail" runat="server" style="z-index: 1; left: 65px; top: 97px; position: absolute"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:TextBox ID="txtSupplierAddress" runat="server" style="z-index: 1; left: 72px; top: 125px; position: absolute"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:TextBox ID="TextSupplierId" runat="server" style="z-index: 1; left: 99px; top: 42px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 11px; top: 70px; position: absolute; height: 16px; width: 113px; margin-top: 0px" Text="Supplier Name "></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblSupplierAddress" runat="server" style="z-index: 1; left: 14px; top: 124px; position: absolute" Text="Address"></asp:Label>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 338px">
    <form id="form1" runat="server">
        <div>
            This is the Supplier data entry</div>
        <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 12px; top: 45px; position: absolute; bottom: 586px;" Text="SupplierId" width="83px"></asp:Label>
        <p>
            <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 85px; top: 46px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 107px; top: 81px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 11px; top: 81px; position: absolute" Text="Supplier Name " width="83px"></asp:Label>
        <asp:Label ID="lblSupplierProduct" runat="server" style="z-index: 1; left: 14px; top: 173px; position: absolute; right: 1413px" Text="Supplier Product" width="83px"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server" style="z-index: 1; left: 139px; top: 130px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierEmail" runat="server" style="z-index: 1; left: 9px; top: 123px; position: absolute" Text="Supplier Email" width="83px"></asp:Label>
        </p>
        <asp:Label ID="lblSupplierDeliveryDate" runat="server" style="z-index: 1; left: 12px; top: 222px; position: absolute" Text="Delivery Date"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtSupplierDeliveryDate" runat="server" style="z-index: 1; left: 133px; top: 221px; position: absolute; bottom: 595px;"></asp:TextBox>
            <asp:TextBox ID="txtSupplierProduct" runat="server" style="z-index: 1; left: 138px; top: 175px; position: absolute; height: 20px;"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkSupplierFromUk" runat="server" style="z-index: 1; left: 16px; top: 321px; position: absolute" Text="SupplierFromUK" />
        <asp:Button ID="btnOK" runat="server"  style="z-index: 1; left: 10px; top: 505px; position: absolute" Text="OK" OnClick="btnOK_Click1" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 92px; top: 507px; position: absolute" Text="Cancel" OnClick="btnCancel_Click"  />
            <asp:TextBox ID="txtSupplierAddress" runat="server" style="z-index: 1; left: 138px; top: 265px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 428px; position: absolute; height: 19px"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 545px; top: 59px; position: absolute" Text="Find" />
        <asp:Label ID="lblSupplierAddress" runat="server" style="z-index: 1; left: 8px; top: 265px; position: absolute" Text="SupplierAddress"></asp:Label>
    </form>
</body>
</html>

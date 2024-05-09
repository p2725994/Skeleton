<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 468px">
    <form id="form1" runat="server">
        <div>
            This is the Supplier data entry</div>
        <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 12px; top: 45px; position: absolute" Text="SupplierId"></asp:Label>
        <p>
            <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 85px; top: 46px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 107px; top: 81px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 11px; top: 81px; position: absolute" Text="Supplier Name "></asp:Label>
        <asp:Label ID="lblSupplierProduct" runat="server" style="z-index: 1; left: 8px; top: 148px; position: absolute; right: 856px" Text="Supplier Product"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server" style="z-index: 1; left: 116px; top: 111px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierEmail" runat="server" style="z-index: 1; left: 9px; top: 110px; position: absolute" Text="Supplier Email"></asp:Label>
        </p>
        <asp:Label ID="lblSupplierDeliveryDate" runat="server" style="z-index: 1; left: 9px; top: 178px; position: absolute" Text="Delivery Date"></asp:Label>
        <p>
            <asp:TextBox ID="txtSupplierProduct" runat="server" style="z-index: 1; left: 124px; top: 148px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtSupplierDeliveryDate" runat="server" style="z-index: 1; left: 120px; top: 182px; position: absolute"></asp:TextBox>
        </p>
        <asp:CheckBox ID="SupplierFromUK" runat="server" style="z-index: 1; left: 9px; top: 212px; position: absolute" />
        <asp:Button ID="btnOK" runat="server"  style="z-index: 1; left: 11px; top: 290px; position: absolute" Text="OK" OnClick="btnOK_Click1" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 249px; position: absolute; height: 19px"></asp:Label>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 78px; top: 291px; position: absolute" Text="Cancel"  />
        </p>
    </form>
</body>
</html>

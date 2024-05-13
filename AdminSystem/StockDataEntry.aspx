<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            <asp:TextBox ID="txtProduct_id" runat="server" style="z-index: 1; left: 228px; top: 55px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <strong></strong>
        </p>
        <p>
            <strong>
            <asp:Label ID="lblProduct_Description" runat="server" style="z-index: 1; left: 9px; top: 164px; position: absolute" Text="Product_Description"></asp:Label>
            <asp:TextBox ID="txtProduct_Description" runat="server" style="z-index: 1; left: 232px; top: 167px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblProduct_id" runat="server" style="z-index: 1; left: 16px; top: 56px; position: absolute; height: 579px; width: 386px" Text="Product_id"></asp:Label>
            </strong>
        </p>
        <p>
            <strong></strong>
        </p>
        <p>
            <strong>
            <asp:Label ID="lblProduct_Name" runat="server" style="z-index: 1; left: 10px; top: 110px; position: absolute; height: 22px" Text="Product_Name"></asp:Label>
            </strong>
        </p>
        <p style="width: 141px">
            <strong></strong>
        </p>
        <p>
            <strong>
            <asp:TextBox ID="txtProduct_Name" runat="server" OnTextChanged="txtProduct_Name_TextChanged" style="z-index: 1; left: 230px; top: 110px; position: absolute; height: 17px"></asp:TextBox>
            <asp:TextBox ID="txtProduct_Expiry" runat="server" OnTextChanged="txtProduct_Expiry_TextChanged" style="z-index: 1; left: 230px; top: 218px; position: absolute"></asp:TextBox>
            </strong>
        </p>
        <strong>&nbsp;&nbsp;
        <asp:Label ID="lblProduct_Expiry" runat="server" style="z-index: 1; left: 12px; top: 220px; position: absolute; height: 25px; width: 120px" Text="Product_Expiry"></asp:Label>
        <asp:Label ID="lblProduct_Quantity" runat="server" style="z-index: 1; left: 11px; top: 268px; position: absolute" Text="Product_Quantity"></asp:Label>
        <asp:TextBox ID="txtProduct_Quantity" runat="server" style="z-index: 1; left: 231px; top: 269px; position: absolute"></asp:TextBox>
        </strong>
        <p>
            <strong></strong>
        </p>
        <p>
            <strong></strong>
        </p>
        <p>
            <strong>
            <asp:TextBox ID="txtProduct_Price" runat="server" style="z-index: 1; left: 227px; top: 310px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblProduct_price" runat="server" style="z-index: 1; left: 9px; top: 314px; position: absolute" Text="Product_Price"></asp:Label>
            </strong>
        </p>
        <p>
            <strong></strong>
        </p>
        <p>
            <strong>
            <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 232px; top: 363px; position: absolute; height: 25px" Text="Available" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 29px; top: 413px; position: absolute" Text="Error"></asp:Label>
            </strong>
        </p>
        <p>
            <strong>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 35px; top: 458px; position: absolute" Text="OK" />
            </strong>
        </p>
        <p>
            <strong>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 143px; top: 457px; position: absolute" Text="Cancel" />
            </strong>
        </p>
    </form>
</body>
</html>


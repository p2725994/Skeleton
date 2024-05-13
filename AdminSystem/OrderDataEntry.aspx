<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 61px">
    &nbsp;<form id="form1" runat="server">
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 42px; top: 35px; position: absolute" Text="Order ID" width="105px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 158px; top: 35px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkPurchased" runat="server" style="z-index: 1; left: 158px; top: 132px; position: absolute" Text="Purchased" />
        </p>
        <asp:Label ID="lblOrderTotal" runat="server" style="z-index: 1; left: 42px; top: 71px; position: absolute" Text="Order Total" width="105px"></asp:Label>
        <asp:Label ID="lblDatePlaced" runat="server" style="z-index: 1; left: 42px; top: 107px; position: absolute; margin-bottom: 0px" Text="Date Placed" width="105px"></asp:Label>
        <asp:TextBox ID="txtOrderTotal" runat="server" style="z-index: 1; left: 158px; top: 70px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDatePlaced" runat="server" style="z-index: 1; left: 158px; top: 106px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtDeliveryAddress" runat="server" style="z-index: 1; left: 158px; top: 161px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtNoOfItems" runat="server" style="z-index: 1; left: 158px; top: 192px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 42px; top: 271px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 41px; top: 315px; position: absolute" Text="OK" />
            <asp:Label ID="lblDeliveryAddress" runat="server" style="z-index: 1; left: 42px; top: 162px; position: absolute; right: 730px;" Text="Delivery Address"></asp:Label>
        <asp:Label ID="lblNoOfItems" runat="server" style="z-index: 1; left: 42px; top: 193px; position: absolute" Text="Number of items" width="105px"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 100px; top: 315px; position: absolute" Text="Cancel" />
        <asp:CheckBox ID="chkIsGift" runat="server" style="z-index: 1; left: 158px; top: 223px; position: absolute" Text="Is a Gift" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 324px; top: 35px; position: absolute; right: 497px" Text="Find" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

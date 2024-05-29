<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 886px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProduct_Id" runat="server" style="z-index: 1; left: 10px; top: 16px; position: absolute; height: 20px; width: 72px;" Text="Product ID"></asp:Label>
            <asp:TextBox ID="txtProduct_Id" runat="server" style="z-index: 1; left: 114px; top: 14px; position: absolute; right: 1px" width="168px"></asp:TextBox>

            <asp:Label ID="lblProduct_Name" runat="server" style="z-index: 1; left: 10px; top: 50px; position: absolute" Text="Name" width="72px"></asp:Label>
            <asp:TextBox ID="txtProduct_Name" runat="server" style="z-index: 1; left: 114px; top: 49px; position: absolute" width="168px"></asp:TextBox>

            <asp:Label ID="lblProduct_Description" runat="server" style="z-index: 1; left: 10px; top: 86px; position: absolute" Text="Description" width="72px"></asp:Label>
            <asp:TextBox ID="txtProduct_Description" runat="server" style="z-index: 1; left: 114px; top: 88px; position: absolute" width="168px"></asp:TextBox>

            <asp:Label ID="lblProduct_Quantity" runat="server" style="z-index: 1; left: 10px; top: 123px; position: absolute" Text="Quantity" width="72px"></asp:Label>
            <asp:TextBox ID="txtProduct_Quantity" runat="server" style="z-index: 1; left: 114px; top: 124px; position: absolute" width="168px"></asp:TextBox>

            <asp:Label ID="lblProduct_Price" runat="server" style="z-index: 1; left: 10px; top: 161px; position: absolute; margin-top: 0px" Text="Price" width="72px"></asp:Label>
            <asp:TextBox ID="txtProduct_Price" runat="server" style="z-index: 1; left: 114px; top: 158px; position: absolute" width="168px"></asp:TextBox>

            <asp:Label ID="lblProduct_Expiry" runat="server" style="z-index: 1; left: 10px; top: 194px; position: absolute" Text="Expiry Date"></asp:Label>
            <asp:TextBox ID="txtProduct_Expiry" runat="server" style="z-index: 1; left: 114px; top: 193px; position: absolute"></asp:TextBox>

            <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 114px; top: 227px; position: absolute; bottom: 626px;" Text="  Availabe" />
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 263px; position: absolute" width="72px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 113px; top: 304px; position: absolute; width: 59px" Text="Cancel" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 303px; position: absolute; height: 26px;" Text="OK" width="59px" />
        <p>
            <asp:Button ID="btnFind" runat="server" Height="29px" style="z-index: 1; left: 304px; top: 17px; position: absolute"  Text="Find" width="59px" OnClick="btnFind_Click" />
        </p>
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 264px; top: 303px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>

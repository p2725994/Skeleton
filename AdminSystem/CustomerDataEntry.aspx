<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 9px; top: 71px; position: absolute" Text="Customer ID"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 369px; top: 70px; position: absolute; height: 25px; width: 58px" Text="Find" />
        </p>
        <p>
            <asp:TextBox ID="txtCustomerFirstname" runat="server" BorderColor="White" height="22px" OnTextChanged="TextBox1_TextChanged1" style="z-index: 1; left: 201px; top: 106px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerFirstname" runat="server" style="z-index: 1; left: 9px; top: 106px; position: absolute" Text="Firstname" width="79px" height="19px"></asp:Label>
        <p>
            <asp:Label ID="lblCustomerLastname" runat="server" style="z-index: 1; left: 9px; top: 140px; position: absolute" Text="Lastname" width="79px" height="19px"></asp:Label>
            <asp:Label ID="lblCustomerPhone" runat="server" style="z-index: 1; left: 9px; top: 211px; position: absolute; height: 19px" Text="Phone" width="79px"></asp:Label>
            <asp:TextBox ID="txtCustomerEmail" runat="server" BorderColor="White" height="22px" style="z-index: 1; left: 201px; top: 175px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 9px; top: 179px; position: absolute; height: 19px" Text="Email" width="79px"></asp:Label>
        </p>
        <asp:Label ID="lblCustomerBirthdate" runat="server" style="z-index: 1; left: 9px; top: 249px; position: absolute" Text="Birthdate" width="79px" height="19px"></asp:Label>
        <asp:TextBox ID="txtCustomerPhone" runat="server" BorderColor="White" height="22px" style="z-index: 1; left: 201px; top: 212px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtCustomerBirthdate" runat="server" BorderColor="White" height="22px" style="z-index: 1; left: 201px; top: 250px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtCustomerLastname" runat="server" BorderColor="White" height="22px" style="z-index: 1; left: 201px; top: 138px; position: absolute" width="128px" OnTextChanged="txtCustomerLastname_TextChanged"></asp:TextBox>
            <asp:Button ID="btnReturnMainMenu" runat="server" style="z-index: 1; left: 214px; top: 375px; position: absolute; width: 85px" Text="Main Menu" />
        </p>
        <p>
            <asp:CheckBox ID="chkVerified" runat="server" style="z-index: 1; left: 86px; top: 280px; position: absolute" Text="Verified" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 321px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 51px; top: 375px; position: absolute; width: 67px; height: 26px;" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 125px; top: 375px; position: absolute" Text="Cancel" height="26px" width="67px" />
        </p>
        <p>
            <asp:TextBox ID="txtCustomerID" runat="server" BorderColor="White" height="22px" OnTextChanged="txtCustomerID_TextChanged" style="z-index: 1; left: 201px; top: 70px; position: absolute" width="128px"></asp:TextBox>
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
    <link href="StaffEntry.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="center">
            <asp:Label ID="lblStaffNo" runat="server" style="z-index: 1; left: 10px; top: 16px; position: absolute; height: 20px; width: 72px;" Text="Staff No"></asp:Label>
            <asp:TextBox ID="txtStaffNo" runat="server" style="z-index: 1; left: 114px; top: 14px; position: absolute; right: 1px" width="168px"></asp:TextBox>
            <asp:Label ID="lblStaffFirstname" runat="server" style="z-index: 1; left: 10px; top: 50px; position: absolute" Text="Firstname" width="72px"></asp:Label>
            <asp:TextBox ID="txtStaffFirstname" runat="server" style="z-index: 1; left: 114px; top: 49px; position: absolute" width="168px"></asp:TextBox>
            <asp:Label ID="lblStaffSurname" runat="server" style="z-index: 1; left: 10px; top: 86px; position: absolute; bottom: 554px; margin-top: 0px" Text="Surname" width="72px"></asp:Label>
            <asp:TextBox ID="txtStaffSurname" runat="server" style="z-index: 1; left: 114px; top: 88px; position: absolute" width="168px"></asp:TextBox>
            <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 10px; top: 123px; position: absolute" Text="Email" width="72px"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 114px; top: 124px; position: absolute" width="168px"></asp:TextBox>
            <asp:Label ID="lblStaffPassword" runat="server" style="z-index: 1; left: 10px; top: 161px; position: absolute; margin-top: 0px" Text="Password" width="72px"></asp:Label>
            <asp:TextBox ID="txtStaffPassword" runat="server" style="z-index: 1; left: 114px; top: 158px; position: absolute" width="168px"></asp:TextBox>
            <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 10px; top: 194px; position: absolute" Text="Date Joined"></asp:Label>
            <asp:TextBox ID="txtDateJoined" runat="server" style="z-index: 1; left: 114px; top: 193px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkIsOnShift" runat="server" style="z-index: 1; left: 114px; top: 227px; position: absolute" Text="  On Shift" />
            <asp:Button ID="btnFind" runat="server"  OnClick="btnFind_Click" style="z-index: 1; left: 318px; top: 14px; position: absolute"  Text="Find" />
            <asp:Button ID="btnMenu" runat="server" OnClick="btnMenu_Click" style="z-index: 1; left: 318px; top: 55px; position: absolute" Text="Return to Main Menu" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 18px; top: 318px; position: absolute;" Text="Cancel"  />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 319px; top: 103px; position: absolute" width="72px"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 17px; top: 274px; position: absolute" Text="OK" />
        </div>
    </form>
</body>
</html>

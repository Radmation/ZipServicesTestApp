<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestZipServices.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="lblCityState" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Button" OnClick="btnSubmit_Click" />

    </div>
    </form>
</body>
</html>

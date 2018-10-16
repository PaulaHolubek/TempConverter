<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TempConversionForm.aspx.cs" Inherits="TempConverter.Web.TempConversionForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" Text="TEMPERATURE CONVERSION TOOL"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Temperature in Celcius:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbTempC" runat="server" BorderWidth="1px" Font-Size="Large"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Temperature in Farenheit:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbTempF" runat="server" BorderWidth="1px" Font-Size="Large"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
&nbsp;<asp:Button ID="btnCtoF" runat="server" Height="46px" OnClick="btnCtoF_Click" Text="Convert C-F" Width="97px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFtoC" runat="server" Height="46px" OnClick="btnFtoC_Click" Text="Convert F-C" Width="97px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" Height="46px" OnClick="btnClear_Click" Text="Clear" Width="97px" />
        </div>
    </form>
</body>
</html>

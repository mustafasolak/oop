<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dongu_azalis.aspx.cs" Inherits="dongu.dongu_azalis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Btn_Dongu" runat="server" OnClick="Btn_Dongu_Click" Text="Button" />
            <br />
            <asp:ListBox ID="List_Dongu" runat="server" Height="553px" Width="153px"></asp:ListBox>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication10.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        başlangıç<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        koşul<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        artırım<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="254px"></asp:ListBox>
    </form>
</body>
</html>

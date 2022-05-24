<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ÇAY ADET<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; 5 TL<br />
            SİMİT ADET<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp; 4 TL<br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="41px" OnClick="Button1_Click" Text="TOPLA" Width="135px" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>

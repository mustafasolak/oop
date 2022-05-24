<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dongu.aspx.cs" Inherits="WebApplication5.dongu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            başlangıç<asp:TextBox ID="Txt_Basla" runat="server"></asp:TextBox>
            <br />
            Artış
            <asp:TextBox ID="Txt_Artis" runat="server"></asp:TextBox>
            <br />
            koşul <asp:TextBox ID="Txt_Kosul" runat="server"></asp:TextBox>
            <br />
&nbsp;<asp:ListBox ID="List_Dongu" runat="server" Height="187px" Width="84px"></asp:ListBox>
            <asp:Button ID="Btn_Basla" runat="server" OnClick="Btn_Basla_Click" Text="Button" Width="79px" />
            <asp:Label ID="Lbl_Hata" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>

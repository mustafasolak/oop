<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rastgele.aspx.cs" Inherits="WebApplication5.rastgele" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Tahmin 
            <asp:TextBox ID="Txt_tahminedilen" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Btn_SayiUret" runat="server" OnClick="Btn_SayiUret_Click" Text="Tahmin yap" Width="198px" />
            <asp:Label ID="Lbl_Sonuc" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:Label ID="Lbl_Hak" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>

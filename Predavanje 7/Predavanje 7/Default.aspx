<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="KOrisničko ime:"></asp:Label>
            <asp:TextBox ID="tb_korisnik" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Lozinka:"></asp:Label>
            <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Prijavi se</asp:LinkButton> &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lb_poruka" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

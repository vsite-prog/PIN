<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registracija</title>
</head>
<body>
    <form id="form1" runat="server">
        <h4> Registracija korisnika</h4>
        <div>
             <asp:Label ID="lb_poruka" runat="server" Text=" " /><br />
            <asp:Label ID="Label1" runat="server" Text="Korisničko ime: "></asp:Label>
            <asp:TextBox ID="tb_kime" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Lozinka: "></asp:Label>
            <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Puno ime: "></asp:Label>
            <asp:TextBox ID="tb_pime" runat="server"></asp:TextBox><br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Spremi korisnika</asp:LinkButton><br /><br />
            <h4> Korisnici </h4>
            <div id="korisnici" runat="server" /><br />
            <asp:GridView ID="gv_korisnici" runat="server"></asp:GridView>
        </div>
    </form>
</body>

</html>

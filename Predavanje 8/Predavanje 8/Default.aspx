<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <h4> Registracija </h4>
            <asp:Label ID="lb_poruka" runat="server" Text=" ime:" /><br />
            <asp:Label ID="Label1" runat="server" Text="Korisničko ime:"></asp:Label>
            <asp:TextBox ID="tb_kime" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Korisnička lozinka:"></asp:Label>
            <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Korisnik puno ime:"></asp:Label>
            <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox><br /><br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Registriraj se</asp:LinkButton>
       
            <br /><br /><br />
            <asp:GridView ID="gv_korisnici" runat="server"></asp:GridView>
            <br />
        <div id="korisniciDiv" runat="server">

        </div>
        
        </div>

    </form>
</body>
</html>


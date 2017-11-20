<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gv_korisnici" runat="server"></asp:GridView>
            <br />
            <h4>Prijava korisnika</h4>
            <asp:Label ID="Label1" runat="server" Text="KOrisničko ime: "></asp:Label>
            <asp:TextBox ID="tb_kime" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Lozinka:   "></asp:Label>
            <asp:TextBox ID="tb_lozinka" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Puno ime:  "></asp:Label>
            <asp:TextBox ID="tb_pime" runat="server"></asp:TextBox>
            <br /><br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Prijava</asp:LinkButton>
        </div>
    </form>
</body>
</html>

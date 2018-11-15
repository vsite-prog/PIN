<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <h4> Korisnici Grid view</h4>
            <asp:GridView ID="gv_korisnici" runat="server"></asp:GridView>
            <h4> KOrisnici labela</h4>
            <asp:Label ID="lb_korisnici" runat="server" Text=""></asp:Label>
                        <br />
                        <br />
                        Unesi Korisnika:<br />
                        <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox>
        <br />
        Lozinka:&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Spremi" OnClick="Button1_Click" />
    </form>
</body>
</html>

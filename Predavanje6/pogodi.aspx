<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pogodi.aspx.cs" Inherits="pogodi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    <h4> Pogodi osobu</h4>
    <asp:Label ID="lb_rez" runat="server" ForeColor="Red"></asp:Label><br /><br />
    <asp:Label ID="Label1" runat="server" Text="Ime:" AssociatedControlID="tb_ime"></asp:Label>
    <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Prezime:" AssociatedControlID="tb_prezime"></asp:Label>
    <asp:TextBox ID="tb_prezime" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="bt_provjeri" runat="server" Text="Provjeri" OnClick="bt_provjeri_Click" />
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="brodovi" runat="server">

        </div>
    <div><asp:Label ID="lb_greska" runat="server" Text="" ></asp:Label><br /><br />
    <asp:Label ID="Label1" runat="server" Text="Naziv: " AssociatedControlID="tb_naziv"></asp:Label>
    <asp:TextBox ID="tb_naziv" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Luka: " AssociatedControlID="tb_luka"></asp:Label>
    <asp:TextBox ID="tb_luka" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="Godina: " AssociatedControlID="tb_godina"></asp:Label>
    <asp:TextBox ID="tb_godina" runat="server" ></asp:TextBox><br />
    
    <asp:Button ID="bt_spremi" runat="server" Text="Spremi" OnClick="bt_spremi_Click" />
    </div>
    </form>

</body>
</html>

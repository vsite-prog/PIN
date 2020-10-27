<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:Label ID="lb_poruka" runat="server" Text=" ime:" /><br />
            <asp:Label ID="Label1" runat="server" Text="Korisničko ime:"></asp:Label>
            <asp:TextBox ID="tb_kime" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Korisnička lozinka:"></asp:Label>
            <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox><br />
               <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Registriraj se</asp:LinkButton>
       
            <br /><br />
        </div>
    </form>
</body>
</html>

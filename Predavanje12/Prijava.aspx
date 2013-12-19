<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Prijava.aspx.cs" Inherits="Prijava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lb_greska" runat="server" Text=""></asp:Label><br />

        Korisničko ime: <asp:textbox ID="tb_kime" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="KOrisničko ime ne smije biti prazno!" ControlToValidate="tb_kime"></asp:RequiredFieldValidator><br />
    Lozinka: <asp:textbox ID="tb_lozinka" runat="server" TextMode="Password"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Lozinka ne smije biti prazno!" ControlToValidate="tb_lozinka"></asp:RequiredFieldValidator><br />
   
   <asp:Button ID="bt_prijava" runat="server" Text="Prijava" OnClick="bt_prijava_Click" />
    </div>
    </form>
</body>
</html>

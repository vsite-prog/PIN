<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registracija.aspx.cs" Inherits="Registracija" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="KOrisničko ime:"></asp:Label>
        <asp:TextBox ID="tb_kime" runat="server"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_kime" ErrorMessage="Ime obavezno!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Lozinka:"></asp:Label>
        <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tb_lozinka" ErrorMessage="Lozinka  obavezna!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
                <asp:Label ID="Label3" runat="server" Text="Lozinka ponovo:"></asp:Label>
        <asp:TextBox ID="tb_lozinka_ponovo" runat="server" TextMode="Password"></asp:TextBox> 
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tb_lozinka" ControlToValidate="tb_lozinka_ponovo" ErrorMessage="Lozinke moraju biti iste!" ForeColor="Red"></asp:CompareValidator>
        <br /><vr></vr>
        <asp:Button ID="Button1" runat="server" Text="Registriraj se" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>

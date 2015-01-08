<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="lb_greska" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="KOrisničko ime:"></asp:Label>
        <asp:TextBox ID="tb_kime" runat="server"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_kime" ErrorMessage="Ime obavezno!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Lozinka:"></asp:Label>
        <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tb_lozinka" ErrorMessage="Lozinka  obavezna!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Prijava</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>

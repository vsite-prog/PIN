<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4>Login</h4>
        <asp:Label ID="label_greska" runat="server" Text=""></asp:Label><br />
    
 <asp:Label ID="Label1" runat="server" Text="KOrisničko ime:"></asp:Label>
        <asp:TextBox ID="tb_kime" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Korisičko ime obvezno!" ForeColor="Red" ControlToValidate="tb_kime"></asp:RequiredFieldValidator><br />
        
        <asp:Label ID="Label2" runat="server" Text="Lozinka:"></asp:Label>
        <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox>
      <br />
        <asp:Button ID="Button1" runat="server" Text="Prijava" OnClick="Button1_Click" />


    </div>
    </form>
</body>
</html>

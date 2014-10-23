<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    Korisničko ime: <asp:textbox ID="tb_kime" runat="server"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="KOrisničko ime ne smije biti prazno!" ControlToValidate="tb_kime"></asp:RequiredFieldValidator><br />
    Lozinka: <asp:textbox ID="tb_lozinka" runat="server" TextMode="Password"></asp:textbox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Lozinka ne smije biti prazno!" ControlToValidate="tb_lozinka"></asp:RequiredFieldValidator><br />
    Lozinka ponovo: <asp:textbox ID="tb_ponovo_lozinka" runat="server" TextMode="Password"></asp:textbox><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Lozinke nisu iste!" ControlToValidate="tb_ponovo_lozinka" ControlToCompare="tb_lozinka" ></asp:CompareValidator><br /><br />
   <asp:Button ID="bt_reg" runat="server" Text="Registracija" OnClick="bt_reg_Click" /> </div>
    </form>
    
</body>
</html>

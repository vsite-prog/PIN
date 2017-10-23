<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registracija.aspx.cs" Inherits="Registracija" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <asp:label id="lb_greska" runat="server" text=" " ForeColor="Red"></asp:label>
        <br />
        <asp:label runat="server" text="Unesi korisničko ime: "></asp:label>
        <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_ime" ForeColor= "Red" ErrorMessage ="Unesite ime!!!"></asp:RequiredFieldValidator>
        <br />
                <asp:label runat="server" text="Unesi lozinku: "></asp:label>
        <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tb_lozinka" ForeColor= "Red" ErrorMessage ="Unesite lozinku!!!" />
        <br />
                        <asp:label runat="server" text="Ponovo lozinku: "></asp:label>
        <asp:TextBox ID="tb_lozinka_ponovo" runat="server" TextMode="Password"></asp:TextBox><asp:CompareValidator ID="CompareValidator1" ControlToValidate="tb_lozinka_ponovo" ControlToCompare="tb_lozinka" runat="server" ErrorMessage="Lozinke nisu iste!!!"></asp:CompareValidator>
            <br />
                        <asp:label runat="server" text="Unesi puno ime: "></asp:label>
        <asp:TextBox ID="tb_puno_ime" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tb_puno_ime" ForeColor= "Red" ErrorMessage ="Unesite puno ime!!!" />
            <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Spremi</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>

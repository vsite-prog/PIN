<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Prijava.aspx.cs" Inherits="Prijava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" id="lb_greska" Text="" ForeColor="Red"></asp:Label><br />
    
Unesi korisničko ime: <asp:TextBox ID="tb_ime" runat="server" ></asp:TextBox>
<br />
Unesi lozinku: <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox>
    </div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Prijava</asp:LinkButton>
    </form>
</body>
</html>

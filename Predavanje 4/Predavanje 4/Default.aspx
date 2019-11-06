<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pred 4</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Literal ID="lt_tekst" runat="server"></asp:Literal>
            <p id="p_client">Nema me na serveru..</p>
            <p id="par1" runat="server"> Ovdje piše neki tekst...
            </p>
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
             <br />
             <asp:Label ID="lb_nesto" runat="server" Text="POčetni tekst..." Font-Bold="True"></asp:Label>
            <br /><br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Klikni_Me">Promijeni tekst</asp:LinkButton>
             <asp:LinkButton ID="LinkButton2" runat="server" OnClick="Odi_Klik">Odi na kalkulator</asp:LinkButton>
        </div>
    </form>
</body>
</html>

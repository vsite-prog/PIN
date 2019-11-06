<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Broj postback-ova:
            <asp:Label ID="lb_postback" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Button ID="Button1" runat="server" Text="POstBackaj" />  
            <asp:Button ID="Button2" runat="server" Text="Pošalji tekst u drugu stranicu!" OnClick="Button2_Click" />
            <br />
             <asp:Button ID="Button3" runat="server" Text="Spremi u cookie" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>

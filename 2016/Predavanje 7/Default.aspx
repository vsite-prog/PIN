<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <h4> Dobro došli prijavljeni korisniče!</h4><br />
        <asp:Label ID="lb_user" runat="server" Text=""></asp:Label><br />
        <asp:LinkButton ID="lb_odjava" runat="server" OnClick="lb_odjava_Click">Odjava</asp:LinkButton>
    </div>
    </form>
</body>
</html>

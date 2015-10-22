<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"  EnableViewState="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
        <asp:Label ID="lb_broj" runat="server"  ForeColor="Red" Text=""></asp:Label>
        <br />
        <asp:Label ID="lb_tajna" runat="server"  ForeColor="Blue" Text=""></asp:Label>

        <br /><br />
        <asp:Button ID="bt_greska" runat="server" Text="Okini grešku" OnClick="bt_greska_Click" />
    </form>
</body>
</html>

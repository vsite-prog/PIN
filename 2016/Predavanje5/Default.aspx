<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID ="lb_viewstate" runat="server" />
        <asp:Label ID ="label1" runat="server" />
        <br />
        <br />
        <asp:LinkButton ID="lb_butt1" runat="server" OnClick="lb_butt1_Click">LinkButton</asp:LinkButton><br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Redirect_Click">Odi na drugu stranu</asp:LinkButton>
    </div>
    </form>
</body>
</html>

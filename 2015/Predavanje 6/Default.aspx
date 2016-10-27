<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="body" runat="server">
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddl_boja" runat="server" OnSelectedIndexChanged="ddl_boja_SelectedIndexChanged" AutoPostBack="true">
             <asp:ListItem>Bijela</asp:ListItem>
            <asp:ListItem>Crvena</asp:ListItem>
            <asp:ListItem>Roza</asp:ListItem>
            <asp:ListItem>Zelena</asp:ListItem>
        </asp:DropDownList>

        <asp:LinkButton ID="lb_odi_dalje" runat="server" OnClick="lb_odi_dalje_Click">LinkButton</asp:LinkButton>
    </div>
    </form>
</body>
</html>

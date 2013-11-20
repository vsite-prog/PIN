<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body runat="server" id="PageBody">
    
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Odaberi boju:"></asp:Label>
    <asp:DropDownList ID="ddl_boja" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_boja_SelectedIndexChanged">
        <asp:ListItem>bijela</asp:ListItem>
        <asp:ListItem>plava</asp:ListItem>
        <asp:ListItem>crvena</asp:ListItem>
        </asp:DropDownList><br /><br />
        Odaberi traženu osobu: <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="John Wayne">Osoba 1</asp:ListItem>
            <asp:ListItem Value="Tom Jones">Osoba 2</asp:ListItem>
            <asp:ListItem Value="James Dean">Osoba 3</asp:ListItem>
        </asp:DropDownList>

    </div>
    </form>
</body>
</html>

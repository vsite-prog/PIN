<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Predavanje 6</title>
</head>
<body id="body" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_boja" runat="server" OnSelectedIndexChanged="Boja_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem>Bijela</asp:ListItem>
                <asp:ListItem>Crvena</asp:ListItem>
                <asp:ListItem>Zelena</asp:ListItem>
                <asp:ListItem>Plava</asp:ListItem>
            </asp:DropDownList>
        </div>

                <asp:Label ID="lb_poruka" runat="server" Text=" "></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Pogodi tajni broj: "></asp:Label>
        <asp:TextBox ID="tb_broj" runat="server"></asp:TextBox><br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Pogađam</asp:LinkButton>
    </form>
</body>
</html>

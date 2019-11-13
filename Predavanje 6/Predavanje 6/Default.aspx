<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="body" runat="server">
    <form id="form1" runat="server">
        <div>
        
        <asp:DropDownList ID="ddl_pozadina" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>Bijela</asp:ListItem>
            <asp:ListItem>Crvena</asp:ListItem>
            <asp:ListItem>Plava</asp:ListItem>
            <asp:ListItem>Zelena</asp:ListItem>
            </asp:DropDownList>
        </div>
        <p>
             <asp:Label ID="lb_poruka" runat="server" Text=" "></asp:Label>
            </p>
        <p>
             <asp:Label ID="lbl" runat="server" Text="Pogodi broj:  "></asp:Label>
             <asp:TextBox ID="tb_unos" runat="server"></asp:TextBox>
        </p>
        <asp:button runat="server" text="POgodi" OnClick="Unnamed1_Click" />
    </form>
</body>
</html>


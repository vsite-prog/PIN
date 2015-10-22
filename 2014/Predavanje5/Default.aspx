<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lb_poruka" runat="server" Text="Label"></asp:Label>
    <div>
        <br />
        <asp:TextBox ID="tb_a" runat="server"></asp:TextBox>
        <asp:DropDownList ID="ddl_oper" runat="server" >
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="tb_b" runat="server"></asp:TextBox>
&nbsp;<asp:Literal ID="Literal1" runat="server" Text="="></asp:Literal>

        <asp:Label ID="lb_reza" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="lb_racunaj" runat="server" OnClick="lb_racunaj_Click">Računaj</asp:LinkButton><br /><br />
        
    
        <asp:Button ID="bt_nazad" runat="server" Text="Vrati seee" />
    
    </div>
    </form>
</body>
</html>

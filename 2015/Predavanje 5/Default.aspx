<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lb_otvaranje" runat="server" Text=""></asp:Label>
        <p>
            <asp:Literal ID="lt_txt" runat="server"></asp:Literal>
            <asp:Label ID="lb_text" runat="server" Text="Haj"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lb_poruka" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:TextBox ID="tb_a" runat="server"></asp:TextBox> &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1"  AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
        </asp:DropDownList>&nbsp;&nbsp;
        <asp:TextBox ID="tb_b" runat="server"></asp:TextBox>&nbsp;&nbsp;
        <asp:Label ID="lb_rez" runat="server"></asp:Label>
        <br /><br />
        <asp:LinkButton ID="lb_racunaj" runat="server" OnClick="lb_racunaj_Click">Računaj</asp:LinkButton>
        <br />
    
        <asp:LinkButton ID="lB_pritisni" runat="server" OnClick="lB_pritisni_Click">Pritisni me</asp:LinkButton>
    </div>
    </form>
</body>
</html>

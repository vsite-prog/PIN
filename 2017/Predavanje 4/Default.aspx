<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb_status" runat="server" Text=""></asp:Label> <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Unesi nešto:" AssociatedControlID="tb_unos"></asp:Label>
            <asp:TextBox ID="tb_unos" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Sad me ima sad me nema</asp:LinkButton>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="KLikni" OnClick="Button1_Click"  />
            <br />
            <br />
       
            <h4>Kalkulator</h4>
            <asp:Label ID="Label2" runat="server" Text="Unesi broj1: " AssociatedControlID="tb_broj1"></asp:Label>
            <asp:TextBox ID="tb_broj1" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Unesi broj2: " AssociatedControlID="tb_broj2"></asp:Label>
            <asp:TextBox ID="tb_broj2" runat="server"></asp:TextBox><br /><br />
            <asp:DropDownList ID="ddl_operator" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem>Operacija?</asp:ListItem>
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:TextBox ID="tb_rezultat" runat="server" ReadOnly="true" Enabled="false"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>

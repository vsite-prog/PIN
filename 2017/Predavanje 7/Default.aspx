<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb_otvaranje" runat="server" Text="" /><br /><br />
            <asp:Panel ID="pn_login" runat="server"><br />
                 <asp:Label ID="lb_greska" runat="server" Text="" ForeColor="Red"></asp:Label><br />
                <asp:Label ID="Label1" runat="server" Text="Korisničko ime:"></asp:Label>
                <asp:TextBox ID="tb_uname" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Lozinka:"></asp:Label>
                <asp:TextBox ID="tb_psw" runat="server" TextMode="Password"></asp:TextBox><br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Prijava</asp:LinkButton>
            </asp:Panel>
            <asp:Panel ID="pn_logout" runat="server" Visible="false">
                 <asp:Label ID="lb_user" runat="server" Text="Korisničko ime:"></asp:Label><br />
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Odjava</asp:LinkButton>
            </asp:Panel>

        </div>
    </form>
</body>
</html>

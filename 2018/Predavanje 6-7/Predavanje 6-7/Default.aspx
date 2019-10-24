<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body  runat="server" id="body">
    <form id="form1" runat="server">
        <div>
            <asp:label runat="server" ID="lb_aplikacija" text="" ></asp:label>
            <h4>POstavke</h4>
            <asp:label runat="server" text="Postavi boju pozadine:" AssociatedControlID="ddl_pozadina"></asp:label>
            &nbsp;
            <asp:DropDownList ID="ddl_pozadina"  AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddl_pozadina_SelectedIndexChanged">
                <asp:ListItem>Crvena</asp:ListItem>
                <asp:ListItem>Plava</asp:ListItem>
                <asp:ListItem>Default</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
        <asp:Panel ID="pn_prijava" runat="server">
            <asp:Label ID="lb_greska" runat="server"  ForeColor="Red"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Kor. ime: "></asp:Label>
        <asp:TextBox ID="tb_ime" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Lozinka: "></asp:Label>
        <asp:TextBox ID="tb_lozinka" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Prijava_Click">Prijava</asp:LinkButton>
            <br />
        </asp:Panel>
            <asp:Panel ID="pn_odjava" runat="server">
            <br />
            <asp:Label ID="lb_prijava" runat="server" Text="Dobar dan: "></asp:Label><br />
            <asp:LinkButton ID="lb_odjava" runat="server" OnClick="lb_odjava_Click" >Odjava</asp:LinkButton>
            <br />
           </asp:Panel>
        </div>

        <p>
            <asp:Button ID="Button1" runat="server" Text="Booooom" OnClick="Button1_Click" />
        </p>

    </form>

</body>

</html>

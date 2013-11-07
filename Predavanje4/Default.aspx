<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Serverske kontrole</title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p id="p1" runat="server"></p>
        <asp:Label runat="server" Text="Unesite:" ID="lb_nesto"></asp:Label>
        <asp:TextBox ID="tb_normalni" runat="server"></asp:TextBox><br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="1">Izbor1</asp:ListItem>
            <asp:ListItem Value="2">Izbor2</asp:ListItem>
            <asp:ListItem Value="3">Izbor3</asp:ListItem>
        </asp:DropDownList><br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Ovo je poveznica ali dugme</asp:LinkButton>
        <br />
        <br />
        <asp:TextBox ID="tb_veliki" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
    <asp:Literal ID="Literal1" runat="server" Text="Ovo je običan tekst!"></asp:Literal>
    </div>
        <asp:Button ID="bt_postback" runat="server" Text="Button" OnClick="bt_postback_Click" />
    </form>
    
</body>
</html>

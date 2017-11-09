<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body  id="body" runat="server">
    <form id="form1" runat="server">
        <div >
            <h4>Postavke:</h4>
            Boja pozadine: <asp:DropDownList ID="ddl_boja" runat="server" OnSelectedIndexChanged="ddl_boja_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem>---Odaberi---</asp:ListItem>
                <asp:ListItem Value="Zuta">Žuta</asp:ListItem>
                <asp:ListItem>Crvena</asp:ListItem>
                <asp:ListItem>Zelena</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Unesi tajni broj:"></asp:Label>
        &nbsp;<asp:TextBox ID="tb_tajna" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Pogađaj</asp:LinkButton>
        </div>
    </form>
</body>
</html>

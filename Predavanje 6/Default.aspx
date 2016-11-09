<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body  runat="server" id="body">
    <form id="form1" runat="server">
    <div>
        Odaberi boju: <asp:DropDownList ID="ddl_boja" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_boja_SelectedIndexChanged">
            <asp:ListItem>Crvena</asp:ListItem>
            <asp:ListItem>Roza</asp:ListItem>
            <asp:ListItem>Plava</asp:ListItem>
            <asp:ListItem>Normalno</asp:ListItem>
        </asp:DropDownList><br />
        <br />
    <asp:label runat="server" text="Unesi pojam: "></asp:label>
        <asp:TextBox ID="tb_pojam" runat="server"></asp:TextBox>
        <br /><br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">POšalji</asp:LinkButton>
    </div>
    </form>
</body>
</html>

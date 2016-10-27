<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lb_poruka" runat="server" Text="" ForeColor="Red"></asp:Label>
        <asp:Button ID="bt_mostovi" OnClick="bt_mostovi_Click" runat="server" Text="Učitaj" />
    <h4> Mostovi</h4>
        <div id="tableDiv" runat="server"></div>
    </div>
        <br /><br />
        <h4>Unesi most</h4>
        <asp:Label ID="Label1" runat="server" Text="Naziv: " ></asp:Label>
        <asp:TextBox ID="tb_naziv" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Mjesto: " ></asp:Label>
        <asp:TextBox ID="tb_mjesto" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Unesi" />
    </form>
</body>
</html>

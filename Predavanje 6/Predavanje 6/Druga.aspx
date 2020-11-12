<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Druga.aspx.cs" Inherits="Druga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Text="Spremi tajni broj (0-100): "></asp:Label>
        <asp:TextBox ID="tb_brpj" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Spremi</asp:LinkButton>
        </div>
    </form>
</body>
</html>

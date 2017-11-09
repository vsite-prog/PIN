<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Druga.aspx.cs" Inherits="Druga2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body id="body" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:label runat="server" ID="lb_poruka" Text=""></asp:label>
            <br />
            <asp:label runat="server" Text="Pogodi tajni broj:"></asp:label>
            <asp:TextBox ID="tb_broj" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Pogodi" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

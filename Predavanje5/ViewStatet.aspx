<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewStatet.aspx.cs" Inherits="ViewStatet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nesto"></asp:Label>
    
    </div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Dugme1</asp:LinkButton>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Unesi pojam:" AssociatedControlID="tb_pojam"></asp:Label>
    
        <asp:TextBox ID="tb_pojam" runat="server"></asp:TextBox>
        <asp:Label ID="lb_unos" runat="server" Text=""></asp:Label>
    <br />
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Zapamti</asp:LinkButton>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Druga.aspx.cs" Inherits="Druga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="body" runat="server">
    <form id="form1" runat="server">
        <div>
            <p>
             <asp:Label ID="lbl" runat="server" Text="Unesi broj do 100:  "></asp:Label>
             <asp:TextBox ID="tb_broj" runat="server" TextMode="Password"></asp:TextBox>
        </p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Spremi</asp:LinkButton>
        </div>
    </form>
</body>
</html>

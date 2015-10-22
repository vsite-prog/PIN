<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb_greska" runat="server" Text="" ForeColor="Red"></asp:Label><br /><br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Pokaži životinje</asp:LinkButton>
        <div id="tableDiv" runat="server">
    
        </div>
        </div>
    </form>
</body>
</html>

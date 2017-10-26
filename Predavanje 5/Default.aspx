<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label" EnableViewState="false"></asp:Label><br />
            <asp:Label ID="lb_postback" runat="server" Text="" ></asp:Label><br />
             <asp:Label ID="Label2" runat="server" Text="Unesi broj:" AssociatedControlID="tb_broj" />
            <asp:TextBox ID="tb_broj" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="ViewState" OnClick="Button1_Click" />
        </div>
        
    </form>
</body>
</html>
